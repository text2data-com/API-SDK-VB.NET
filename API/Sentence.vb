Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web

Namespace text2data.Api.DTO

    Public Class Sentence
        Public Property SentenceNumber() As Integer
            Get
                Return m_SentenceNumber
            End Get
            Set(value As Integer)
                m_SentenceNumber = value
            End Set
        End Property
        Private m_SentenceNumber As Integer

        Public Property Text() As String
            Get
                Return m_Text
            End Get
            Set(value As String)
                m_Text = value
            End Set
        End Property
        Private m_Text As String

        Public Property SentimentResultString() As String
            Get
                Return m_SentimentResultString
            End Get
            Set(value As String)
                m_SentimentResultString = value
            End Set
        End Property
        Private m_SentimentResultString As String

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

        Public Property Relevance() As Integer
            Get
                Return m_Relevance
            End Get
            Set(value As Integer)
                m_Relevance = value
            End Set
        End Property
        Private m_Relevance As Integer
    End Class

End Namespace