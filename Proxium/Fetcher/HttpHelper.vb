Imports System.Net
Imports System.IO

Module HttpHelper
    Public Function GetResponse(ByVal Url As String) As String
        Try
            Dim W As HttpWebRequest = HttpWebRequest.Create(Url)
            W.Timeout = 10000
            W.UserAgent = "Just another HTTP Request"
            Dim Response As HttpWebResponse = CType(W.GetResponse(), HttpWebResponse)
            Dim dStream As Stream = Response.GetResponseStream()
            Dim rdr As New StreamReader(dStream)
            Dim respStr As String = rdr.ReadToEnd()
            Return respStr
        Catch ex As Exception
        End Try
        Return Nothing
    End Function
End Module
