Imports System.Text.RegularExpressions

Module StringHelper
    Public Function GetBetween(ByVal input As String, ByVal str1 As String, ByVal str2 As String, ByVal ind As Integer) As String
        Dim temp As String = Regex.Split(input, str1)(ind + 1)
        Return Regex.Split(temp, str2)(0)
    End Function
End Module
