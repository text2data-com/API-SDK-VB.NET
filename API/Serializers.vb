Imports System.Web.Script.Serialization
Imports System.IO
Imports System.Xml.Serialization
Imports System.Text

Public Class Serializers
    Public Shared Function FromJSON(Of T)(json As String) As T
        Dim jss = New JavaScriptSerializer()

        Return jss.Deserialize(Of T)(json)
    End Function

    Public Shared Function ToJSON(Of T)(objectDto As T) As String
        Dim jss = New JavaScriptSerializer()

        Return jss.Serialize(objectDto)
    End Function

    Public Shared Function SerializeXML(Of T)(obj As T) As String
        Dim result As String = String.Empty
        Using ms = New MemoryStream()
            Dim serializer = New XmlSerializer(obj.[GetType]())
            serializer.Serialize(ms, obj)
            result = Encoding.UTF8.GetString(ms.ToArray())
        End Using
        Return result
    End Function

    Public Shared Function DeserializeXML(Of T)(input As String) As T
        Dim obj As T = Nothing
        Using ms = New MemoryStream(Encoding.UTF8.GetBytes(input))
            Dim serializer = New XmlSerializer(GetType(T))
            obj = DirectCast(serializer.Deserialize(ms), T)
        End Using
        Return obj
    End Function

End Class
