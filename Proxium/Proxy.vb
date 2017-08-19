Imports System.Net

Public Class Proxy
    Private _IPAddress As String
    Public Property IPAddress() As String
        Get
            Return _IPAddress
        End Get
        Set(ByVal value As String)
            _IPAddress = value
        End Set
    End Property
    Private _Port As String
    Public Property Port() As String
        Get
            Return _Port
        End Get
        Set(ByVal value As String)
            _Port = value
        End Set
    End Property
    Private _Working As Boolean
    Public Property Working() As Boolean
        Get
            Return _Working
        End Get
        Set(ByVal value As Boolean)
            _Working = value
        End Set
    End Property

    Public Sub CheckProxy()
        Try
            Dim myProxy As WebProxy = New WebProxy(IPAddress & ":" & Port)
            Dim r As HttpWebRequest = HttpWebRequest.Create("http://www.google.com")
            r.UserAgent = "Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/29.0.1547.2 Safari/537.36"
            r.Timeout = 3000
            r.Proxy = myProxy
            Dim re As HttpWebResponse = r.GetResponse()
            Working = True
        Catch ex As Exception
            Working = False
        End Try
    End Sub
End Class