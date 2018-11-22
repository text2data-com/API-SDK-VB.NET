Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports System.Net
Imports System.Text
Imports System.Web.Script.Serialization
Imports text2data.text2data.Api.DTO

Namespace text2data.Api

    Public Class API
        Public Const ApiUrl As String = "http://api.text2data.com/root/"
        Public Const ApiSerializeFormat As SerializeFormats = SerializeFormats.Json
        Public Const ApiUseCompression As Boolean = True

        Public Shared Function GetDocumentAnalysisResult(ByVal reqDoc As Document) As DocumentResult
            Dim docRes As DocumentResult = SendRequest(reqDoc)

            Return docRes
        End Function

        Private Shared Function SendRequest(requestDto As Document) As DocumentResult
            Try
                requestDto.SerializeFormat = CInt(ApiSerializeFormat)
                ServicePointManager.ServerCertificateValidationCallback = Function(a, b, c, d) True

                Dim request = DirectCast(WebRequest.Create(ApiUrl), HttpWebRequest)
                request.Method = "POST"
                If ApiUseCompression Then
                    request.Headers.Add("Accept-Encoding", "gzip,deflate")
                    request.AutomaticDecompression = DecompressionMethods.GZip Or DecompressionMethods.Deflate
                End If
                request.ContentType = If(ApiSerializeFormat = SerializeFormats.Json, "application/json", "application/xml")
                request.Timeout = 60000 'should be between 30s to max 1 min for very long documents

                Using requestWriter = New StreamWriter(request.GetRequestStream())
                    If ApiSerializeFormat = SerializeFormats.Json Then
                        requestWriter.Write(Serializers.ToJSON(Of Document)(requestDto))
                    Else
                        requestWriter.Write(Serializers.SerializeXML(Of Document)(requestDto))
                    End If
                End Using

                Dim response = DirectCast(request.GetResponse(), HttpWebResponse)
                Using resStream = response.GetResponseStream()
                    Using reader = New StreamReader(resStream)
                        If ApiSerializeFormat = SerializeFormats.Json Then
                            Return Serializers.FromJSON(Of DocumentResult)(reader.ReadToEnd())
                        Else
                            Return Serializers.DeserializeXML(Of DocumentResult)(reader.ReadToEnd())
                        End If
                    End Using
                End Using
            Catch ex As Exception
                Return New DocumentResult() With {.Status = CInt(DocumentResultStatus.GenericError), .ErrorMessage = ex.Message}
            End Try
        End Function
    End Class
End Namespace
