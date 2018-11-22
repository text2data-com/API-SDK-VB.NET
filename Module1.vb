Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports text2data.text2data.Api.DTO
Imports text2data.text2data.Api

Module Module1

    Sub Main()
        Dim inputText As String = "I am not negative about the LG brand."
        Dim privateKey As String = "----------------------" 'add your private key here (you can find it in the admin panel once you sign-up)
        Dim secret As String = ""  'this should be set-up in admin panel as well
        '/////////////////////////

        Dim doc = New Document() With {.DocumentText = inputText, .IsTwitterContent = False, .UserCategoryModelName = "", .PrivateKey = privateKey, .Secret = secret}
        Dim docResult = API.GetDocumentAnalysisResult(doc) 'execute request

        If docResult.Status = CInt(DocumentResultStatus.OK) Then 'check status
            'display document level score
            Console.WriteLine(String.Format("This document is: {0}{1} {2}", docResult.DocSentimentPolarity, docResult.DocSentimentResultString, docResult.DocSentimentValue.ToString("0.000")))

            If docResult.Entities IsNot Nothing AndAlso docResult.Entities.Any() Then
                Console.WriteLine(Environment.NewLine + "Entities:")
                For Each entity As SentencePart In docResult.Entities
                    Console.WriteLine(String.Format("{0} ({1}) {2}{3} {4}", entity.Text, entity.KeywordType, entity.SentimentPolarity, entity.SentimentResult, entity.SentimentValue.ToString("0.0000")))
                Next
            End If

            If docResult.Keywords IsNot Nothing AndAlso docResult.Keywords.Any() Then
                Console.WriteLine(Environment.NewLine + "Keywords:")
                For Each keyword As SentencePart In docResult.Keywords
                    Console.WriteLine(String.Format("{0} {1}{2} {3}", keyword.Text, keyword.SentimentPolarity, keyword.SentimentResult, keyword.SentimentValue.ToString("0.0000")))
                Next
            End If

            'display more information below if required 
        Else
            Console.WriteLine(docResult.ErrorMessage)
        End If

        Console.ReadLine()
    End Sub

End Module
