Imports System.Threading
Imports System.Text.RegularExpressions
Imports System.Net
Imports System.ComponentModel
Imports System.Windows.Forms.ListView

Public Class Form1

    Private Sub StopFetchingToolStripMenuItem_Click(sender As Object, e As EventArgs)
        NumberOfThreads = MaximumThreads
        UpdateStatus("Aborted Fetching.", SparkToast.PopupStyle.Critical)
    End Sub

    Private ListOfLinks As List(Of String)
    Private Completed As Integer
    Private R As New Random
    Private ListArray As List(Of ListViewItem)
    Private FetchedProxies As List(Of Proxy)

    Private Async Sub ScrapeProxies()
        Await Fetch()
    End Sub

    Private Async Function Fetch() As Task
        ListOfLinks = New List(Of String)
        ListArray = New List(Of ListViewItem)
        FetchedProxies = New List(Of Proxy)

        Completed = 0
        NumberOfThreads = 1

        NumberOfLinks = SparkNumericUpDown1.Value
        MaximumThreads = SparkNumericUpDown1.Value
        NumberOfLinks = 100
        ResetCount()
        UpdateStatus("Contacting the source...", SparkToast.PopupStyle.Information)
        Dim events As New List(Of ManualResetEvent)

        Try
            Dim Source As String = HttpHelper.GetResponse("https://orca.tech/community-proxy-list/")
            Dim NumberOfLinksFound As Integer
            If Source <> Nothing Then
                NumberOfLinksFound = Regex.Matches(Source, "href").Count
                If NumberOfLinksFound < 1 Then
                    Throw New Exception()
                    Exit Function
                End If
                UpdateStatus("Reading from source...", SparkToast.PopupStyle.Information)
                For i = 0 To NumberOfLinksFound - 1
                    ListOfLinks.Add(GetBetween(Source, "href='", "'", i))
                Next
                'UpdateStatus("Creating sub threads...", SparkToast.PopupStyle.Information)

                Dim options = New ParallelOptions() With {.MaxDegreeOfParallelism = MaximumThreads}
                Await Task.Run(Function()
                                   Try
                                       ServicePointManager.DefaultConnectionLimit = NumberOfLinks
                                       Parallel.For(0, NumberOfLinks - 1, options, Function(link)
                                                                                       Try
                                                                                           Dim A As Boolean = FetchProxies(link)
                                                                                       Catch ex As Exception
                                                                                       End Try
                                                                                       Return False
                                                                                   End Function)

                                       Return Nothing
                                   Catch ex As Exception
                                   End Try
                                   Return Nothing
                               End Function)
                UpdateStatus("Fetching complete.", SparkToast.PopupStyle.Success)
            Else
            End If
        Catch ex As Exception
            If Not TypeOf (ex) Is TaskCanceledException Then
                UpdateStatus("Unable to contact source", SparkToast.PopupStyle.Critical)
            End If
            UpdateStatus("Fetching complete.", SparkToast.PopupStyle.Success)
        End Try

    End Function

    Private Sub UpdateStatus(ByVal Status As String, ByVal Style As SparkToast.PopupStyle)
        Invoke(New MethodInvoker(Sub()
                                     SparkToast1.Text = Status
                                     SparkToast1.Style = Style
                                 End Sub))
    End Sub
    Private Sub UpdateCount(ByVal Count As Integer)
        Invoke(New MethodInvoker(Sub()
                                     Label3.Text = CInt(Label3.Text) + Count
                                 End Sub))
    End Sub
    Private Sub ResetCount()
        Invoke(New MethodInvoker(Sub()
                                     Label3.Text = 0
                                 End Sub))
    End Sub

    Private Function FetchProxies(i As Integer) As Boolean
        Try
            Dim Round As Integer = i
            UpdateStatus("Fetching from source " & Round, SparkToast.PopupStyle.Information)
            Dim Content As String = HttpHelper.GetResponse("https://orca.tech/community-proxy-list/" & ListOfLinks(R.Next(0, ListOfLinks.Count - 1)))
            Dim Proxies As New Proxies(Content)
            Dim LvItemArray As New List(Of ListViewItem)
            For Each P As Proxy In Proxies.GetProxys
                Dim LvItem As New ListViewItem(P.IPAddress)
                LvItem.SubItems.Add(P.Port)
                LvItemArray.Add(LvItem)
                FetchedProxies.Add(P)
            Next
            ListArray.AddRange(LvItemArray)
            UpdateCount(Proxies.GetProxys.Count)
            Invoke(New MethodInvoker(Sub()
                                         ListView1.Items.AddRange(LvItemArray.ToArray)
                                     End Sub))
            Return True
        Catch ex As Exception
        End Try
        Return False
    End Function

    Private Sub SparkNumericUpDown1_ValueChanged(sender As Object, e As EventArgs)
        NumberOfLinks = CInt(SparkNumericUpDown1.Value)
        MaximumThreads = CInt(SparkNumericUpDown1.Value)
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Environment.Exit(0)
    End Sub


    Private Sub RemoveItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveItemToolStripMenuItem.Click
        If ListView1.SelectedItems.Count > 0 Then
            For Each I As ListViewItem In ListView1.SelectedItems
                ListView1.Items.Remove(I)
                ListArray.Remove(I)
            Next
        End If
    End Sub

    Private Sub RemoveAllItemsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveAllItemsToolStripMenuItem.Click
        If ListView1.Items.Count > 0 Then
            Dim Confirm As DialogResult = MessageBox.Show("Do you really want to clear the list?", "Confirmation!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If Confirm = Windows.Forms.DialogResult.Yes Then
                ListView1.Items.Clear()
                ListArray.Clear()
                ResetCount()
            Else
                Exit Sub
            End If
        End If
    End Sub

    Private Sub ExportAllItemsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportAllItemsToolStripMenuItem.Click
        If ListView1.Items.Count < 1 Then
            Exit Sub
        End If
        Dim t As New Thread(AddressOf Export)
        t.SetApartmentState(ApartmentState.STA)
        t.Start()
    End Sub
    Private Sub Export()
        Dim S As New SaveFileDialog
        Dim Path As String = Nothing
        With S
            .DefaultExt = "Text Files(*.txt)|*.txt"
            .Filter = "All Files(*.*)|*.*"
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                Path = .FileName
            Else : Exit Sub
            End If
        End With
        Dim Combo As String = Nothing
        UpdateStatus("Exporting...", SparkToast.PopupStyle.Information)
        For Each i In FetchedProxies
            Combo &= i.IPAddress & ":" & i.Port & Environment.NewLine
        Next
        IO.File.WriteAllText(Path, Combo)
        UpdateStatus("Export Complete.", SparkToast.PopupStyle.Success)
    End Sub

    Private Sub MoveToCheckerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MoveToCheckerToolStripMenuItem.Click
        Dim Adder As New Thread(AddressOf DuplicateListView)
        Adder.SetApartmentState(ApartmentState.STA)
        Adder.Start()
    End Sub

    Private Sub DuplicateListView()
        UpdateStatus("Moving to Checker.", SparkToast.PopupStyle.Information)
        Invoke(New MethodInvoker(Sub()
                                     ListView1.Items.Clear()
                                     ListView2.Items.AddRange(ListArray.ToArray)
                                 End Sub))
        For Each I In FetchedProxies.ToArray
            'ChkProxies.Add(New Proxys.Proxy With {.IPAddress = I.IPAddress, .Port = I.Port})
        Next
        UpdateStatus("Moved to Checker.", SparkToast.PopupStyle.Success)
    End Sub


    Private Sub StartFetching()
        ListView1.Items.Clear()

        UpdateStatus("Attempting to connect", SparkToast.PopupStyle.Information)
        Dim ScrapeThread As Thread = New Thread(AddressOf ScrapeProxies)
        ScrapeThread.SetApartmentState(ApartmentState.MTA)
        ScrapeThread.Start()
    End Sub


    Private Sub StartFetchingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StartFetchingToolStripMenuItem.Click
        StartFetching()
    End Sub

    Private CheckProxiesList As List(Of Proxy)
    Private WorkingProxies As List(Of Proxy)
    Private Async Sub ImportFromFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportFromFileToolStripMenuItem.Click
        ResetCount()
        CheckProxiesList = New List(Of Proxy)
        MaximumThreads = SparkNumericUpDown1.Value
        Using O As New OpenFileDialog
            O.Title = "Select Proxy List"
            O.Filter = "All Files(*.*)|*.*"
            O.DefaultExt = "Text Files(*.txt)|*.txt"
            If O.ShowDialog = Windows.Forms.DialogResult.OK Then
                ListView2.Items.Clear()
                UpdateStatus("Importing proxies...", SparkToast.PopupStyle.Information)
                ''Code to add proxies to list
                Await Task.Run(Sub()
                                   Invoke(New MethodInvoker(Sub()
                                                                Dim Proxies As New Proxies(IO.File.ReadAllText(O.FileName))
                                                                Dim LvItemArray As New List(Of ListViewItem)
                                                                For Each P As Proxy In Proxies.GetProxys
                                                                    Dim LvItem As New ListViewItem(P.IPAddress)
                                                                    LvItem.SubItems.Add(P.Port)
                                                                    LvItem.SubItems.Add("")
                                                                    LvItemArray.Add(LvItem)
                                                                    CheckProxiesList.Add(P)
                                                                Next
                                                                UpdateCount(Proxies.GetProxys.Count)
                                                                Invoke(New MethodInvoker(Sub()
                                                                                             ListView2.Items.AddRange(LvItemArray.ToArray)
                                                                                         End Sub))

                                                            End Sub))


                               End Sub)
                
                UpdateStatus("Imported successfully.", SparkToast.PopupStyle.Success)
            End If
        End Using
    End Sub

    Private Async Sub StartCheckingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StartCheckingToolStripMenuItem.Click
        UpdateStatus("Checking Proxies...", SparkToast.PopupStyle.Information)
        ''Code to check proxies
        Label4.Text = 0
        Label6.Text = 0
        Dim options = New ParallelOptions() With {.MaxDegreeOfParallelism = SparkNumericUpDown1.Value}
        Await Task.Run(Sub()
                           Invoke(New MethodInvoker(Sub()
                                                        Parallel.For(0, ListView2.Items.Count - 1, options, Sub(i)
                                                                                                                Try
                                                                                                                    Dim myProxy As WebProxy = New WebProxy(ListView2.Items(i).Text & ":" & ListView2.Items(i).SubItems(1).Text)
                                                                                                                    Dim r As HttpWebRequest = HttpWebRequest.Create("http://www.google.com")
                                                                                                                    r.UserAgent = "Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/29.0.1547.2 Safari/537.36"
                                                                                                                    r.Timeout = 1000
                                                                                                                    r.Proxy = myProxy
                                                                                                                    Dim re As HttpWebResponse = r.GetResponse()
                                                                                                                    UpdateCheckerStatus(i, True)
                                                                                                                Catch ex As Exception
                                                                                                                    UpdateCheckerStatus(i, False)
                                                                                                                End Try

                                                                                                            End Sub)
                                                    End Sub))


                       End Sub)

        UpdateStatus("Checking completed.", SparkToast.PopupStyle.Information)
    End Sub

    Public Sub UpdateCheckerStatus(ByVal index As Integer, ByVal Working As Boolean)
        Invoke(New MethodInvoker(Sub()
                                     If Working Then
                                         ListView2.Items(index).SubItems(2).Text = "Works"
                                         ListView2.Items(index).SubItems(2).BackColor = Color.Green
                                         Label6.Text = CInt(Label6.Text) + 1
                                     Else
                                         ListView2.Items(index).SubItems(2).Text = "Invalid"
                                         'Lvitem.SubItems(2).BackColor = Color.Red
                                     End If
                                     Label4.Text = CInt(Label4.Text) + 1
                                 End Sub))
    End Sub
    Private Sub RemoveSelectedItemsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveSelectedItemsToolStripMenuItem.Click
        If ListView2.SelectedItems.Count > 0 Then
            For Each I As ListViewItem In ListView2.SelectedItems
                ListView2.Items.Remove(I)
            Next
        End If
    End Sub

    Private Sub RemoveAllItemsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RemoveAllItemsToolStripMenuItem1.Click
        If ListView2.Items.Count > 0 Then
            Dim Confirm As DialogResult = MessageBox.Show("Do you really want to clear the list?", "Confirmation!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If Confirm = Windows.Forms.DialogResult.Yes Then
                ListView2.Items.Clear()
                ResetCount()
                Label4.Text = 0
            Else
                Exit Sub
            End If
        End If
    End Sub

    Private Sub ExportSelectedItemsToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ExportAllItemsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExportAllItemsToolStripMenuItem1.Click
        'If ListView2.Items.Count < 1 Then
        '    Exit Sub
        'End If
        'Dim t As New Thread(AddressOf ExportCheckedProxies)
        't.SetApartmentState(ApartmentState.STA)
        't.Start()
    End Sub

    'Private Sub ExportCheckedProxies()
    '    Dim S As New SaveFileDialog
    '    Dim Path As String = Nothing
    '    With S
    '        .DefaultExt = "Text Files(*.txt)|*.txt"
    '        .Filter = "All Files(*.*)|*.*"
    '        If .ShowDialog = Windows.Forms.DialogResult.OK Then
    '            Path = .FileName
    '        Else : Exit Sub
    '        End If
    '    End With
    '    Dim Combo As String = Nothing
    '    UpdateStatus("Exporting...", SparkToast.PopupStyle.Information)
    '    For Each i In WorkingProxies
    '        Combo &= i.IPAddress & ":" & i.Port & Environment.NewLine
    '    Next
    '    IO.File.WriteAllText(Path, Combo)
    '    UpdateStatus("Export Complete.", SparkToast.PopupStyle.Success)
    'End Sub

End Class
