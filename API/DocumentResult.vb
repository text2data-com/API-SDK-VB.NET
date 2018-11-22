Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web

Namespace text2data.Api.DTO

     Public Class DocumentResult
        Private m_DocSentimentResultString As String
        Public Property DocSentimentResultString() As String
            Get
                Return m_DocSentimentResultString
            End Get
            Set(ByVal value As String)
                m_DocSentimentResultString = value
            End Set
        End Property

        Private m_DocSentimentValue As Double
        Public Property DocSentimentValue() As Double
            Get
                Return m_DocSentimentValue
            End Get
            Set(ByVal value As Double)
                m_DocSentimentValue = value
            End Set
        End Property

        Public Property DocSentimentPolarity() As String
            Get
                Return m_DocSentimentPolarity
            End Get
            Set(value As String)
                m_DocSentimentPolarity = value
            End Set
        End Property
        Private m_DocSentimentPolarity As String
		
		 Public Property Subjectivity() As String
            Get
                Return m_Subjectivity
            End Get
            Set(value As String)
                m_Subjectivity = value
            End Set
        End Property
        Private m_Subjectivity As String
		
        Public Property Summarization() As String
            Get
                Return m_Summarization
            End Get
            Set(value As String)
                m_Summarization = value
            End Set
        End Property
        Private m_Summarization As String

        Public Property NegativePhraseCount() As Integer
            Get
                Return m_NegativePhraseCount
            End Get
            Set(value As Integer)
                m_NegativePhraseCount = value
            End Set
        End Property
        Private m_NegativePhraseCount As Integer

        Public Property PositivePhraseCount() As Integer
            Get
                Return m_PositivePhraseCount
            End Get
            Set(value As Integer)
                m_PositivePhraseCount = value
            End Set
        End Property
        Private m_PositivePhraseCount As Integer

        Public Property NeutralPhraseCount() As Integer
            Get
                Return m_NeutralPhraseCount
            End Get
            Set(value As Integer)
                m_NeutralPhraseCount = value
            End Set
        End Property
        Private m_NeutralPhraseCount As Integer

        Public Property Entities() As List(Of SentencePart)
            Get
                Return m_Entities
            End Get
            Set(value As List(Of SentencePart))
                m_Entities = value
            End Set
        End Property
        Private m_Entities As List(Of SentencePart)

        Public Property Themes() As List(Of SentencePart)
            Get
                Return m_Themes
            End Get
            Set(value As List(Of SentencePart))
                m_Themes = value
            End Set
        End Property
        Private m_Themes As List(Of SentencePart)

        Public Property Keywords() As List(Of SentencePart)
            Get
                Return m_Keywords
            End Get
            Set(value As List(Of SentencePart))
                m_Keywords = value
            End Set
        End Property
        Private m_Keywords As List(Of SentencePart)

        Public Property Citations() As List(Of SentencePart)
            Get
                Return m_Citations
            End Get
            Set(value As List(Of SentencePart))
                m_Citations = value
            End Set
        End Property
        Private m_Citations As List(Of SentencePart)

        Public Property SlangWords() As List(Of SlangWord)
            Get
                Return m_SlangWords
            End Get
            Set(value As List(Of SlangWord))
                m_SlangWords = value
            End Set
        End Property
        Private m_SlangWords As List(Of SlangWord)

        Public Property SwearWords() As List(Of SlangWord)
            Get
                Return m_SwearWords
            End Get
            Set(value As List(Of SlangWord))
                m_SwearWords = value
            End Set
        End Property
        Private m_SwearWords As List(Of SlangWord)

        Public Property CoreSentences() As List(Of Sentence)
            Get
                Return m_CoreSentences
            End Get
            Set(value As List(Of Sentence))
                m_CoreSentences = value
            End Set
        End Property
        Private m_CoreSentences As List(Of Sentence)

        Public Property PartsOfSpeech() As List(Of PartOfSpeech)
            Get
                Return m_PartsOfSpeech
            End Get
            Set(value As List(Of PartOfSpeech))
                m_PartsOfSpeech = value
            End Set
        End Property
        Private m_PartsOfSpeech As List(Of PartOfSpeech)

        Public Property AutoCategories() As List(Of Category)
            Get
                Return m_AutoCategories
            End Get
            Set(value As List(Of Category))
                m_AutoCategories = value
            End Set
        End Property
        Private m_AutoCategories As List(Of Category)

        Public Property UserCategories() As List(Of Category)
            Get
                Return m_UserCategories
            End Get
            Set(value As List(Of Category))
                m_UserCategories = value
            End Set
        End Property
        Private m_UserCategories As List(Of Category)

        Public Property CloudTagHTML() As String
            Get
                Return m_CloudTagHTML
            End Get
            Set(value As String)
                m_CloudTagHTML = value
            End Set
        End Property
        Private m_CloudTagHTML As String

        Public Property ResultTextHtml() As String
            Get
                Return m_ResultTextHtml
            End Get
            Set(value As String)
                m_ResultTextHtml = value
            End Set
        End Property
        Private m_ResultTextHtml As String

        Public Property ErrorMessage() As String
            Get
                Return m_ErrorMessage
            End Get
            Set(value As String)
                m_ErrorMessage = value
            End Set
        End Property
        Private m_ErrorMessage As String

        Public Property Status() As Integer
            Get
                Return m_Status
            End Get
            Set(value As Integer)
                m_Status = value
            End Set
        End Property
        Private m_Status As Integer
		
		Public Property TransactionTotalCreditsLeft() As Integer
            Get
                Return m_TransactionTotalCreditsLeft
            End Get
            Set(value As Integer)
                m_TransactionTotalCreditsLeft = value
            End Set
        End Property
        Private m_TransactionTotalCreditsLeft As Integer
		
		Public Property TransactionUseByDate() As DateTime
            Get
                Return m_TransactionUseByDate
            End Get
            Set(value As DateTime)
                m_TransactionUseByDate = value
            End Set
        End Property
        Private m_TransactionUseByDate As DateTime
			
        Public Property TransactionCurrentDay() As Integer
            Get
                Return m_TransactionCurrentDay
            End Get
            Set(value As Integer)
                m_TransactionCurrentDay = value
            End Set
        End Property
        Private m_TransactionCurrentDay As Integer
		
		Public Property TransactionDailyLimit() As Integer
            Get
                Return m_TransactionDailyLimit
            End Get
            Set(value As Integer)
                m_TransactionDailyLimit = value
            End Set
        End Property
        Private m_TransactionDailyLimit As Integer

    End Class

End Namespace