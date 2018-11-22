
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web

Namespace text2data.Api.DTO
    Public Class PartOfSpeech
        Public Property Text() As String
            Get
                Return m_Text
            End Get
            Set(value As String)
                m_Text = value
            End Set
        End Property
        Private m_Text As String

        Public Property Subject() As String
            Get
                Return m_Subject
            End Get
            Set(value As String)
                m_Subject = value
            End Set
        End Property
        Private m_Subject As String

        Public Property Action() As String
            Get
                Return m_Action
            End Get
            Set(value As String)
                m_Action = value
            End Set
        End Property
        Private m_Action As String

        Public Property [Object]() As String
            Get
                Return m_Object
            End Get
            Set(value As String)
                m_Object = value
            End Set
        End Property
        Private m_Object As String

        Public Property ObjectSentimentResultString() As String
            Get
                Return m_ObjectSentimentResultString
            End Get
            Set(value As String)
                m_ObjectSentimentResultString = value
            End Set
        End Property
        Private m_ObjectSentimentResultString As String

        Public Property ObjectSentimentValue() As Double
            Get
                Return m_ObjectSentimentValue
            End Get
            Set(value As Double)
                m_ObjectSentimentValue = value
            End Set
        End Property
        Private m_ObjectSentimentValue As Double

        Public Property ObjectSentimentPolarity() As String
            Get
                Return m_ObjectSentimentPolarity
            End Get
            Set(value As String)
                m_ObjectSentimentPolarity = value
            End Set
        End Property
        Private m_ObjectSentimentPolarity As String
    End Class
End Namespace

