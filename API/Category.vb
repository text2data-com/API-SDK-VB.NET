Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web

Namespace text2data.Api.DTO

    Public Class Category
        Public Property CategoryName() As String
            Get
                Return m_CategoryName
            End Get
            Set(value As String)
                m_CategoryName = value
            End Set
        End Property
        Private m_CategoryName As String

        Public Property Score() As Double
            Get
                Return m_Score
            End Get
            Set(value As Double)
                m_Score = value
            End Set
        End Property
        Private m_Score As Double
    End Class

End Namespace