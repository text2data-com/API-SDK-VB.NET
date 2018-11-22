
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web

Namespace text2data.Api.DTO
    Public Class SlangWord
        Public Property SlangWordText() As String
            Get
                Return m_SlangWordText
            End Get
            Set(value As String)
                m_SlangWordText = value
            End Set
        End Property
        Private m_SlangWordText As String

        Public Property SlangWordTranslation() As String
            Get
                Return m_SlangWordTranslation
            End Get
            Set(value As String)
                m_SlangWordTranslation = value
            End Set
        End Property
        Private m_SlangWordTranslation As String
    End Class
End Namespace

