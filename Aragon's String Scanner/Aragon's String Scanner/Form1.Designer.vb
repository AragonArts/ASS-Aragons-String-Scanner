<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits MetroFramework.Forms.MetroForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.mainLog = New System.Windows.Forms.RichTextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.searchFilters = New System.Windows.Forms.RichTextBox()
        Me.fileContainer = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.blackList = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.scanBtn = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.progress = New System.Windows.Forms.ProgressBar()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.directoryBox = New System.Windows.Forms.TextBox()
        Me.directoryBrowser = New System.Windows.Forms.Button()
        Me.folderBrowseDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.Finish = New System.Windows.Forms.Timer(Me.components)
        Me.saveLog = New System.Windows.Forms.PictureBox()
        Me.openWebsite = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.saveLog, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.openWebsite, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mainLog
        '
        Me.mainLog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainLog.Location = New System.Drawing.Point(20, 89)
        Me.mainLog.Name = "mainLog"
        Me.mainLog.Size = New System.Drawing.Size(626, 322)
        Me.mainLog.TabIndex = 0
        Me.mainLog.Text = ""
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.searchFilters)
        Me.Panel1.Controls.Add(Me.fileContainer)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.blackList)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.scanBtn)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(646, 60)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(156, 374)
        Me.Panel1.TabIndex = 1
        '
        'searchFilters
        '
        Me.searchFilters.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.searchFilters.Location = New System.Drawing.Point(0, 16)
        Me.searchFilters.Name = "searchFilters"
        Me.searchFilters.Size = New System.Drawing.Size(156, 225)
        Me.searchFilters.TabIndex = 0
        Me.searchFilters.Text = "STEAM_" & Global.Microsoft.VisualBasic.ChrW(10) & "http.Post" & Global.Microsoft.VisualBasic.ChrW(10) & "http.Fetch" & Global.Microsoft.VisualBasic.ChrW(10) & "CompileString" & Global.Microsoft.VisualBasic.ChrW(10) & "RunString" & Global.Microsoft.VisualBasic.ChrW(10) & "RunConsoleCommand" & Global.Microsoft.VisualBasic.ChrW(10) & "file.Delete" &
    "" & Global.Microsoft.VisualBasic.ChrW(10) & "net.Receive" & Global.Microsoft.VisualBasic.ChrW(10) & "char(" & Global.Microsoft.VisualBasic.ChrW(10) & "byte(" & Global.Microsoft.VisualBasic.ChrW(10) & "bxor" & Global.Microsoft.VisualBasic.ChrW(10) & "bit." & Global.Microsoft.VisualBasic.ChrW(10) & "<rgx>0[xX][0-9a-fA-F]+" & Global.Microsoft.VisualBasic.ChrW(10) & "<rgx>\[0-9]+" & Global.Microsoft.VisualBasic.ChrW(10) & "<rgx>\[xX" &
    "][0-9a-fA-F]" & Global.Microsoft.VisualBasic.ChrW(10) & "['\"
        '
        'fileContainer
        '
        Me.fileContainer.FormattingEnabled = True
        Me.fileContainer.Location = New System.Drawing.Point(111, 104)
        Me.fileContainer.Name = "fileContainer"
        Me.fileContainer.Size = New System.Drawing.Size(28, 69)
        Me.fileContainer.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label2.Location = New System.Drawing.Point(0, 244)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Blacklist"
        '
        'blackList
        '
        Me.blackList.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.blackList.Location = New System.Drawing.Point(0, 257)
        Me.blackList.Name = "blackList"
        Me.blackList.Size = New System.Drawing.Size(156, 76)
        Me.blackList.TabIndex = 1
        Me.blackList.Text = "wire-" & Global.Microsoft.VisualBasic.ChrW(10) & "3d2d_textscreens_" & Global.Microsoft.VisualBasic.ChrW(10) & "ulx" & Global.Microsoft.VisualBasic.ChrW(10) & "ulib" & Global.Microsoft.VisualBasic.ChrW(10) & "dlib"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Search Filter"
        '
        'scanBtn
        '
        Me.scanBtn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.scanBtn.Image = Global.Aragon_s_String_Scanner.My.Resources.Resources.clock_play
        Me.scanBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.scanBtn.Location = New System.Drawing.Point(0, 333)
        Me.scanBtn.Name = "scanBtn"
        Me.scanBtn.Size = New System.Drawing.Size(156, 41)
        Me.scanBtn.TabIndex = 4
        Me.scanBtn.Text = "Begin Scan"
        Me.scanBtn.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.progress)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(20, 411)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(626, 23)
        Me.Panel2.TabIndex = 2
        '
        'progress
        '
        Me.progress.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.progress.Location = New System.Drawing.Point(0, 0)
        Me.progress.Name = "progress"
        Me.progress.Size = New System.Drawing.Size(626, 23)
        Me.progress.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.directoryBox)
        Me.Panel3.Controls.Add(Me.directoryBrowser)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(20, 60)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(626, 29)
        Me.Panel3.TabIndex = 3
        '
        'directoryBox
        '
        Me.directoryBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.directoryBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.directoryBox.Location = New System.Drawing.Point(4, 4)
        Me.directoryBox.Name = "directoryBox"
        Me.directoryBox.Size = New System.Drawing.Size(497, 21)
        Me.directoryBox.TabIndex = 1
        Me.directoryBox.Text = "Folder Directory"
        Me.directoryBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'directoryBrowser
        '
        Me.directoryBrowser.Dock = System.Windows.Forms.DockStyle.Right
        Me.directoryBrowser.Image = Global.Aragon_s_String_Scanner.My.Resources.Resources.page_white_magnify
        Me.directoryBrowser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.directoryBrowser.Location = New System.Drawing.Point(505, 0)
        Me.directoryBrowser.Name = "directoryBrowser"
        Me.directoryBrowser.Size = New System.Drawing.Size(121, 29)
        Me.directoryBrowser.TabIndex = 0
        Me.directoryBrowser.Text = "Browse Directory"
        Me.directoryBrowser.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.directoryBrowser.UseVisualStyleBackColor = True
        '
        'folderBrowseDialog
        '
        Me.folderBrowseDialog.Description = "Locate the directory you want to scan"
        '
        'Finish
        '
        Me.Finish.Interval = 1000
        '
        'saveLog
        '
        Me.saveLog.Dock = System.Windows.Forms.DockStyle.Right
        Me.saveLog.Image = Global.Aragon_s_String_Scanner.My.Resources.Resources.arrow_down
        Me.saveLog.Location = New System.Drawing.Point(802, 60)
        Me.saveLog.Name = "saveLog"
        Me.saveLog.Size = New System.Drawing.Size(15, 374)
        Me.saveLog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.saveLog.TabIndex = 5
        Me.saveLog.TabStop = False
        '
        'openWebsite
        '
        Me.openWebsite.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.openWebsite.Image = Global.Aragon_s_String_Scanner.My.Resources.Resources.world
        Me.openWebsite.Location = New System.Drawing.Point(799, 39)
        Me.openWebsite.Name = "openWebsite"
        Me.openWebsite.Size = New System.Drawing.Size(15, 15)
        Me.openWebsite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.openWebsite.TabIndex = 4
        Me.openWebsite.TabStop = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(837, 454)
        Me.Controls.Add(Me.mainLog)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.saveLog)
        Me.Controls.Add(Me.openWebsite)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(582, 364)
        Me.Name = "Main"
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Text = " Aragon's Backdoor Finder"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.saveLog, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.openWebsite, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents mainLog As RichTextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents directoryBrowser As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents progress As ProgressBar
    Friend WithEvents Panel3 As Panel
    Friend WithEvents directoryBox As TextBox
    Friend WithEvents folderBrowseDialog As FolderBrowserDialog
    Friend WithEvents scanBtn As Button
    Friend WithEvents blackList As RichTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents searchFilters As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents fileContainer As ListBox
    Friend WithEvents Finish As Timer
    Friend WithEvents openWebsite As PictureBox
    Friend WithEvents saveLog As PictureBox
End Class
