
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web

Namespace text2data.Api.DTO
    Public Class SentencePart
        Public Property Text() As String
            Get
                Return m_Text
            End Get
            Set(value As String)
                m_Text = value
            End Set
        End Property
        Private m_Text As String

        Public Property SentenceText() As String
            Get
                Return m_SentenceText
            End Get
            Set(value As String)
                m_SentenceText = value
            End Set
        End Property
        Private m_SentenceText As String

        Public Property Mentions() As Integer
            Get
                Return m_Mentions
            End Get
            Set(value As Integer)
                m_Mentions = value
            End Set
        End Property
        Private m_Mentions As Integer

        Public Property SentencePartType() As String
            Get
                Return m_SentencePartType
            End Get
            Set(value As String)
                m_SentencePartType = value
            End Set
        End Property
        Private m_SentencePartType As String

        Public Property KeywordType() As String
            Get
                Return m_KeywordType
            End Get
            Set(value As String)
                m_KeywordType = value
            End Set
        End Property
        Private m_KeywordType As String

        Public Property SentimentResult() As String
            Get
                Return m_SentimentResult
            End Get
            Set(value As String)
                m_SentimentResult = value
            End Set
        End Property
        Private m_SentimentResult As String

        Public Property SentimentValue() As Double
            Get
                Return m_SentimentValue
            End Get
            Set(value As Double)
                m_SentimentValue = value
            End Set
        End Property
        Private m_SentimentValue As Double

        Public Property SentimentPolarity() As String
            Get
                Return m_SentimentPolarity
            End Get
            Set(value As String)
                m_SentimentPolarity = value
            End Set
        End Property
        Private m_SentimentPolarity As String
    End Class
End Namespace

