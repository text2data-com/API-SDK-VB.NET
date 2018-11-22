
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web

Namespace text2data.Api.DTO
    Public Class Document
        Public Property DocumentText() As String
            Get
                Return m_DocumentText
            End Get
            Set(value As String)
                m_DocumentText = Value
            End Set
        End Property
        Private m_DocumentText As String

        Public Property IsTwitterContent() As Boolean
            Get
                Return m_IsTwitterContent
            End Get
            Set(value As Boolean)
                m_IsTwitterContent = Value
            End Set
        End Property
        Private m_IsTwitterContent As Boolean

        'trained model name leave empty for default
        Public Property UserCategoryModelName() As String
            Get
                Return m_UserCategoryModelName
            End Get
            Set(value As String)
                m_UserCategoryModelName = value
            End Set
        End Property
        Private m_UserCategoryModelName As String

        Public Property PrivateKey() As String
            Get
                Return m_PrivateKey
            End Get
            Set(value As String)
                m_PrivateKey = Value
            End Set
        End Property
        Private m_PrivateKey As String

        Public Property Secret() As String
            Get
                Return m_secret
            End Get
            Set(value As String)
                m_secret = value
            End Set
        End Property
        Private m_secret As String
		
		'//default: EN
		Public Property DocumentLanguage() As String
            Get
                Return m_DocumentLanguage
            End Get
            Set(value As String)
                m_DocumentLanguage = Value
            End Set
        End Property
        Private m_DocumentLanguage As String

        Public Property SerializeFormat() As Integer
            Get
                Return m_SerializeFormat
            End Get
            Set(value As Integer)
                m_SerializeFormat = value
            End Set
        End Property
        Private m_SerializeFormat As Integer

        Public Property LoadHtmlInfo() As Boolean
            Get
                Return m_LoadHtmlInfo
            End Get
            Set(value As Boolean)
                m_LoadHtmlInfo = value
            End Set
        End Property
        Private m_LoadHtmlInfo As Boolean

    End Class
End Namespace

