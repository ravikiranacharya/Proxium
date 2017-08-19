Imports System.IO
Imports System.IO.File

Public Class Proxies
    Private Contents As String
    Public Sub New(ByVal _Contents As String)
        Me.Contents = _Contents
    End Sub

    Public Function GetProxys() As List(Of Proxy)
        Dim ProxyList As New List(Of Proxy)
        Dim ProxysArray() As String = Nothing
        If Contents Is Nothing Then
            Return New List(Of Proxy)
        End If
        ProxysArray = Contents.Split(Environment.NewLine)
        For i = 1 To ProxysArray.Length - 2
            Try
                Dim IPPort As String() = ProxysArray(i).Split(":")
                Dim Acc As New Proxy With {
                    .IPAddress = IPPort(0),
                    .Port = IPPort(1)
                }
                ProxyList.Add(Acc)
            Catch ex As Exception
            End Try
        Next
        Return ProxyList
    End Function
End Class
