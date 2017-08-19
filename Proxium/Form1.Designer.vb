<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ItemSelectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveAllItemsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProxySelectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportAllItemsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MoveToCheckerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartFetchingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddHostToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveHostToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearHostsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip3 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ListOperationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveSelectedItemsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveAllItemsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProxyOperationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportAllItemsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CheckerOperationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartCheckingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportFromFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SparkForm1 = New Proxium.SparkForm()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SparkNumericUpDown2 = New Proxium.SparkNumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SparkToast1 = New Proxium.SparkToast()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SparkNumericUpDown1 = New Proxium.SparkNumericUpDown()
        Me.SparkTabControl1 = New Proxium.SparkTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.ListView3 = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SparkControlBox1 = New Proxium.SparkControlBox()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.ContextMenuStrip3.SuspendLayout()
        Me.SparkForm1.SuspendLayout()
        CType(Me.SparkNumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SparkNumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SparkTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ItemSelectionToolStripMenuItem, Me.ProxySelectionToolStripMenuItem, Me.StartFetchingToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(165, 70)
        '
        'ItemSelectionToolStripMenuItem
        '
        Me.ItemSelectionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RemoveItemToolStripMenuItem, Me.RemoveAllItemsToolStripMenuItem})
        Me.ItemSelectionToolStripMenuItem.Name = "ItemSelectionToolStripMenuItem"
        Me.ItemSelectionToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.ItemSelectionToolStripMenuItem.Text = "List Operations"
        '
        'RemoveItemToolStripMenuItem
        '
        Me.RemoveItemToolStripMenuItem.Name = "RemoveItemToolStripMenuItem"
        Me.RemoveItemToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.RemoveItemToolStripMenuItem.Text = "Remove Selected Items"
        '
        'RemoveAllItemsToolStripMenuItem
        '
        Me.RemoveAllItemsToolStripMenuItem.Name = "RemoveAllItemsToolStripMenuItem"
        Me.RemoveAllItemsToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.RemoveAllItemsToolStripMenuItem.Text = "Remove All Items"
        '
        'ProxySelectionToolStripMenuItem
        '
        Me.ProxySelectionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportAllItemsToolStripMenuItem, Me.MoveToCheckerToolStripMenuItem})
        Me.ProxySelectionToolStripMenuItem.Name = "ProxySelectionToolStripMenuItem"
        Me.ProxySelectionToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.ProxySelectionToolStripMenuItem.Text = "Proxy Operations"
        '
        'ExportAllItemsToolStripMenuItem
        '
        Me.ExportAllItemsToolStripMenuItem.Name = "ExportAllItemsToolStripMenuItem"
        Me.ExportAllItemsToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.ExportAllItemsToolStripMenuItem.Text = "Export All Items"
        '
        'MoveToCheckerToolStripMenuItem
        '
        Me.MoveToCheckerToolStripMenuItem.Name = "MoveToCheckerToolStripMenuItem"
        Me.MoveToCheckerToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.MoveToCheckerToolStripMenuItem.Text = "Move to Checker"
        '
        'StartFetchingToolStripMenuItem
        '
        Me.StartFetchingToolStripMenuItem.Name = "StartFetchingToolStripMenuItem"
        Me.StartFetchingToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.StartFetchingToolStripMenuItem.Text = "Start Fetching"
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddHostToolStripMenuItem, Me.RemoveHostToolStripMenuItem, Me.ClearHostsToolStripMenuItem})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(146, 70)
        '
        'AddHostToolStripMenuItem
        '
        Me.AddHostToolStripMenuItem.Name = "AddHostToolStripMenuItem"
        Me.AddHostToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.AddHostToolStripMenuItem.Text = "Add Host"
        '
        'RemoveHostToolStripMenuItem
        '
        Me.RemoveHostToolStripMenuItem.Name = "RemoveHostToolStripMenuItem"
        Me.RemoveHostToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.RemoveHostToolStripMenuItem.Text = "Remove Host"
        '
        'ClearHostsToolStripMenuItem
        '
        Me.ClearHostsToolStripMenuItem.Name = "ClearHostsToolStripMenuItem"
        Me.ClearHostsToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.ClearHostsToolStripMenuItem.Text = "Clear Hosts"
        '
        'ContextMenuStrip3
        '
        Me.ContextMenuStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListOperationsToolStripMenuItem, Me.ProxyOperationsToolStripMenuItem, Me.ToolStripSeparator1, Me.CheckerOperationsToolStripMenuItem, Me.ImportFromFileToolStripMenuItem})
        Me.ContextMenuStrip3.Name = "ContextMenuStrip3"
        Me.ContextMenuStrip3.Size = New System.Drawing.Size(179, 98)
        '
        'ListOperationsToolStripMenuItem
        '
        Me.ListOperationsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RemoveSelectedItemsToolStripMenuItem, Me.RemoveAllItemsToolStripMenuItem1})
        Me.ListOperationsToolStripMenuItem.Name = "ListOperationsToolStripMenuItem"
        Me.ListOperationsToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.ListOperationsToolStripMenuItem.Text = "List Operations"
        '
        'RemoveSelectedItemsToolStripMenuItem
        '
        Me.RemoveSelectedItemsToolStripMenuItem.Name = "RemoveSelectedItemsToolStripMenuItem"
        Me.RemoveSelectedItemsToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.RemoveSelectedItemsToolStripMenuItem.Text = "Remove Selected Items"
        '
        'RemoveAllItemsToolStripMenuItem1
        '
        Me.RemoveAllItemsToolStripMenuItem1.Name = "RemoveAllItemsToolStripMenuItem1"
        Me.RemoveAllItemsToolStripMenuItem1.Size = New System.Drawing.Size(196, 22)
        Me.RemoveAllItemsToolStripMenuItem1.Text = "Remove All Items"
        '
        'ProxyOperationsToolStripMenuItem
        '
        Me.ProxyOperationsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportAllItemsToolStripMenuItem1})
        Me.ProxyOperationsToolStripMenuItem.Name = "ProxyOperationsToolStripMenuItem"
        Me.ProxyOperationsToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.ProxyOperationsToolStripMenuItem.Text = "Proxy Operations"
        '
        'ExportAllItemsToolStripMenuItem1
        '
        Me.ExportAllItemsToolStripMenuItem1.Name = "ExportAllItemsToolStripMenuItem1"
        Me.ExportAllItemsToolStripMenuItem1.Size = New System.Drawing.Size(156, 22)
        Me.ExportAllItemsToolStripMenuItem1.Text = "Export All Items"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(175, 6)
        '
        'CheckerOperationsToolStripMenuItem
        '
        Me.CheckerOperationsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartCheckingToolStripMenuItem})
        Me.CheckerOperationsToolStripMenuItem.Name = "CheckerOperationsToolStripMenuItem"
        Me.CheckerOperationsToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.CheckerOperationsToolStripMenuItem.Text = "Checker Operations"
        '
        'StartCheckingToolStripMenuItem
        '
        Me.StartCheckingToolStripMenuItem.Name = "StartCheckingToolStripMenuItem"
        Me.StartCheckingToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.StartCheckingToolStripMenuItem.Text = "Start Checking"
        '
        'ImportFromFileToolStripMenuItem
        '
        Me.ImportFromFileToolStripMenuItem.Name = "ImportFromFileToolStripMenuItem"
        Me.ImportFromFileToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.ImportFromFileToolStripMenuItem.Text = "Import From File"
        '
        'SparkForm1
        '
        Me.SparkForm1.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.SparkForm1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.SparkForm1.BorderRadius = 0
        Me.SparkForm1.Controls.Add(Me.Label8)
        Me.SparkForm1.Controls.Add(Me.SparkNumericUpDown2)
        Me.SparkForm1.Controls.Add(Me.Label6)
        Me.SparkForm1.Controls.Add(Me.Label7)
        Me.SparkForm1.Controls.Add(Me.Label4)
        Me.SparkForm1.Controls.Add(Me.Label5)
        Me.SparkForm1.Controls.Add(Me.SparkToast1)
        Me.SparkForm1.Controls.Add(Me.Label3)
        Me.SparkForm1.Controls.Add(Me.Label2)
        Me.SparkForm1.Controls.Add(Me.Label1)
        Me.SparkForm1.Controls.Add(Me.SparkNumericUpDown1)
        Me.SparkForm1.Controls.Add(Me.SparkTabControl1)
        Me.SparkForm1.Controls.Add(Me.SparkControlBox1)
        Me.SparkForm1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SparkForm1.DrawSeparator = False
        Me.SparkForm1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SparkForm1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.SparkForm1.IconRectangle = New System.Drawing.Rectangle(15, 13, 32, 32)
        Me.SparkForm1.Location = New System.Drawing.Point(0, 0)
        Me.SparkForm1.Name = "SparkForm1"
        Me.SparkForm1.SeparatorColor = System.Drawing.Color.White
        Me.SparkForm1.Size = New System.Drawing.Size(397, 553)
        Me.SparkForm1.TabIndex = 0
        Me.SparkForm1.Text = "Proxium"
        Me.SparkForm1.TextLocation = New System.Drawing.Point(55, 20)
        Me.SparkForm1.TopLeftColor = System.Drawing.Color.Sienna
        Me.SparkForm1.TopLeftRectangle = New System.Drawing.Rectangle(0, 0, 450, 140)
        Me.SparkForm1.TopRightColor = System.Drawing.Color.White
        Me.SparkForm1.TopRightRectangle = New System.Drawing.Rectangle(0, 0, 0, 40)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(8, 494)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 15)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Scrape Degree:"
        '
        'SparkNumericUpDown2
        '
        Me.SparkNumericUpDown2.BackColor = System.Drawing.Color.Sienna
        Me.SparkNumericUpDown2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.SparkNumericUpDown2.BorderRadius = 0
        Me.SparkNumericUpDown2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SparkNumericUpDown2.ForeColor = System.Drawing.Color.White
        Me.SparkNumericUpDown2.HighlightColor = System.Drawing.Color.Sienna
        Me.SparkNumericUpDown2.Location = New System.Drawing.Point(95, 488)
        Me.SparkNumericUpDown2.LowerRectangleColor = System.Drawing.Color.Sienna
        Me.SparkNumericUpDown2.Maximum = New Decimal(New Integer() {250, 0, 0, 0})
        Me.SparkNumericUpDown2.Name = "SparkNumericUpDown2"
        Me.SparkNumericUpDown2.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.SparkNumericUpDown2.Size = New System.Drawing.Size(89, 27)
        Me.SparkNumericUpDown2.TabIndex = 17
        Me.SparkNumericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.SparkNumericUpDown2.UpperRectangleColor = System.Drawing.Color.Sienna
        Me.SparkNumericUpDown2.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Green
        Me.Label6.Location = New System.Drawing.Point(302, 497)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(14, 15)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(204, 497)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 15)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Proxies Working:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Green
        Me.Label4.Location = New System.Drawing.Point(302, 479)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(14, 15)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(204, 479)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 15)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Proxies Checked:"
        '
        'SparkToast1
        '
        Me.SparkToast1.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.SparkToast1.Location = New System.Drawing.Point(7, 524)
        Me.SparkToast1.Name = "SparkToast1"
        Me.SparkToast1.Size = New System.Drawing.Size(196, 18)
        Me.SparkToast1.Style = Proxium.SparkToast.PopupStyle.Information
        Me.SparkToast1.TabIndex = 12
        Me.SparkToast1.Text = "Application is Idle"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Green
        Me.Label3.Location = New System.Drawing.Point(302, 462)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(14, 15)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(204, 462)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 15)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Proxies Fetched:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(8, 465)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 15)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Thread Limit:"
        '
        'SparkNumericUpDown1
        '
        Me.SparkNumericUpDown1.BackColor = System.Drawing.Color.Sienna
        Me.SparkNumericUpDown1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.SparkNumericUpDown1.BorderRadius = 0
        Me.SparkNumericUpDown1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SparkNumericUpDown1.ForeColor = System.Drawing.Color.White
        Me.SparkNumericUpDown1.HighlightColor = System.Drawing.Color.Sienna
        Me.SparkNumericUpDown1.Location = New System.Drawing.Point(95, 459)
        Me.SparkNumericUpDown1.LowerRectangleColor = System.Drawing.Color.Sienna
        Me.SparkNumericUpDown1.Name = "SparkNumericUpDown1"
        Me.SparkNumericUpDown1.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.SparkNumericUpDown1.Size = New System.Drawing.Size(89, 27)
        Me.SparkNumericUpDown1.TabIndex = 7
        Me.SparkNumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.SparkNumericUpDown1.UpperRectangleColor = System.Drawing.Color.Sienna
        Me.SparkNumericUpDown1.Value = New Decimal(New Integer() {15, 0, 0, 0})
        '
        'SparkTabControl1
        '
        Me.SparkTabControl1.Controls.Add(Me.TabPage1)
        Me.SparkTabControl1.Controls.Add(Me.TabPage2)
        Me.SparkTabControl1.Controls.Add(Me.TabPage3)
        Me.SparkTabControl1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SparkTabControl1.ItemSize = New System.Drawing.Size(129, 35)
        Me.SparkTabControl1.Location = New System.Drawing.Point(3, 146)
        Me.SparkTabControl1.Name = "SparkTabControl1"
        Me.SparkTabControl1.SelectedIndex = 0
        Me.SparkTabControl1.SelectedTabColor = System.Drawing.Color.Sienna
        Me.SparkTabControl1.Size = New System.Drawing.Size(391, 306)
        Me.SparkTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.SparkTabControl1.TabIndex = 1
        Me.SparkTabControl1.TabItemColor = System.Drawing.Color.Sienna
        Me.SparkTabControl1.TabPageColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.ListView1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 39)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(383, 263)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Proxium Fetcher"
        '
        'ListView1
        '
        Me.ListView1.AutoArrange = False
        Me.ListView1.BackColor = System.Drawing.SystemColors.Window
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.ListView1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.ListView1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(6, 6)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.RightToLeftLayout = True
        Me.ListView1.Size = New System.Drawing.Size(371, 250)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "IP Address"
        Me.ColumnHeader1.Width = 157
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Port"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 119
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.ListView2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 39)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(383, 263)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Proxium Checker"
        '
        'ListView2
        '
        Me.ListView2.AutoArrange = False
        Me.ListView2.BackColor = System.Drawing.SystemColors.Window
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.ListView2.ContextMenuStrip = Me.ContextMenuStrip3
        Me.ListView2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ListView2.FullRowSelect = True
        Me.ListView2.GridLines = True
        Me.ListView2.Location = New System.Drawing.Point(6, 6)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.RightToLeftLayout = True
        Me.ListView2.Size = New System.Drawing.Size(371, 250)
        Me.ListView2.TabIndex = 1
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "IP Address"
        Me.ColumnHeader4.Width = 138
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Port"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 86
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Status"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader6.Width = 93
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = ""
        Me.ColumnHeader7.Width = 41
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.TabPage3.Controls.Add(Me.ListView3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 39)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(383, 263)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Proxium Results"
        '
        'ListView3
        '
        Me.ListView3.AutoArrange = False
        Me.ListView3.BackColor = System.Drawing.SystemColors.Window
        Me.ListView3.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10})
        Me.ListView3.ContextMenuStrip = Me.ContextMenuStrip3
        Me.ListView3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ListView3.FullRowSelect = True
        Me.ListView3.GridLines = True
        Me.ListView3.Location = New System.Drawing.Point(6, 6)
        Me.ListView3.Name = "ListView3"
        Me.ListView3.RightToLeftLayout = True
        Me.ListView3.Size = New System.Drawing.Size(371, 250)
        Me.ListView3.TabIndex = 2
        Me.ListView3.UseCompatibleStateImageBehavior = False
        Me.ListView3.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "IP Address"
        Me.ColumnHeader3.Width = 110
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Port"
        Me.ColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader8.Width = 73
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Status"
        Me.ColumnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader9.Width = 75
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = ""
        Me.ColumnHeader10.Width = 41
        '
        'SparkControlBox1
        '
        Me.SparkControlBox1.BackColor = System.Drawing.Color.Sienna
        Me.SparkControlBox1.CloseColor = System.Drawing.Color.Sienna
        Me.SparkControlBox1.IsClosable = True
        Me.SparkControlBox1.IsMaximizable = False
        Me.SparkControlBox1.IsMinimizable = True
        Me.SparkControlBox1.Location = New System.Drawing.Point(316, 16)
        Me.SparkControlBox1.MaximizeColor = System.Drawing.Color.Sienna
        Me.SparkControlBox1.MinimizeColor = System.Drawing.Color.Sienna
        Me.SparkControlBox1.Name = "SparkControlBox1"
        Me.SparkControlBox1.Size = New System.Drawing.Size(72, 24)
        Me.SparkControlBox1.TabIndex = 0
        Me.SparkControlBox1.Text = "SparkControlBox1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(397, 553)
        Me.Controls.Add(Me.SparkForm1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Proxium"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.ContextMenuStrip3.ResumeLayout(False)
        Me.SparkForm1.ResumeLayout(False)
        Me.SparkForm1.PerformLayout()
        CType(Me.SparkNumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SparkNumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SparkTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SparkForm1 As Proxium.SparkForm
    Friend WithEvents SparkTabControl1 As Proxium.SparkTabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents SparkControlBox1 As Proxium.SparkControlBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AddHostToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveHostToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearHostsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ItemSelectionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveAllItemsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProxySelectionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportAllItemsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MoveToCheckerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListView2 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ContextMenuStrip3 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ListOperationsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveSelectedItemsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveAllItemsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProxyOperationsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportAllItemsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CheckerOperationsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StartCheckingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SparkNumericUpDown1 As Proxium.SparkNumericUpDown
    Friend WithEvents SparkToast1 As Proxium.SparkToast
    Friend WithEvents StartFetchingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImportFromFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ListView3 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents SparkNumericUpDown2 As Proxium.SparkNumericUpDown

End Class
