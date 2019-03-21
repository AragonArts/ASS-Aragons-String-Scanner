<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
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
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
		Me.Finish = New System.Windows.Forms.Timer(Me.components)
		Me.folderBrowseDialog = New System.Windows.Forms.FolderBrowserDialog()
		Me.RevealContent = New System.Windows.Forms.Timer(Me.components)
		Me.ContentWrapper = New System.Windows.Forms.Panel()
		Me.ToggleSideMenu = New Aragon_s_String_Scanner.FlatToggle()
		Me.Form1 = New Aragon_s_String_Scanner.FormSkin()
		Me.MiddlePanel = New System.Windows.Forms.Panel()
		Me.fileContainer = New System.Windows.Forms.ListBox()
		Me.mainLog = New System.Windows.Forms.RichTextBox()
		Me.progress = New Aragon_s_String_Scanner.FlatProgressBar()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.FlatLabel3 = New Aragon_s_String_Scanner.FlatLabel()
		Me.TopPanel = New System.Windows.Forms.Panel()
		Me.directoryBox = New Aragon_s_String_Scanner.FlatTextBox()
		Me.directoryBrowser = New Aragon_s_String_Scanner.FlatButton()
		Me.Sidepanel = New System.Windows.Forms.Panel()
		Me.SideBottomPanel = New System.Windows.Forms.Panel()
		Me.saveBtn = New Aragon_s_String_Scanner.FlatButton()
		Me.scanBtn = New Aragon_s_String_Scanner.FlatButton()
		Me.FlatLabel2 = New Aragon_s_String_Scanner.FlatLabel()
		Me.blackList = New System.Windows.Forms.RichTextBox()
		Me.SideTopPanel = New System.Windows.Forms.Panel()
		Me.searchFilters = New System.Windows.Forms.RichTextBox()
		Me.FlatLabel1 = New Aragon_s_String_Scanner.FlatLabel()
		Me.FlatClose1 = New Aragon_s_String_Scanner.FlatClose()
		Me.HeaderPanel = New System.Windows.Forms.Panel()
		Me.Form1.SuspendLayout()
		Me.MiddlePanel.SuspendLayout()
		Me.Panel1.SuspendLayout()
		Me.TopPanel.SuspendLayout()
		Me.Sidepanel.SuspendLayout()
		Me.SideBottomPanel.SuspendLayout()
		Me.SideTopPanel.SuspendLayout()
		Me.SuspendLayout()
		'
		'Finish
		'
		Me.Finish.Interval = 1000
		'
		'folderBrowseDialog
		'
		Me.folderBrowseDialog.Description = "Locate the directory you want to scan"
		'
		'RevealContent
		'
		Me.RevealContent.Enabled = True
		Me.RevealContent.Interval = 2500
		'
		'ContentWrapper
		'
		Me.ContentWrapper.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
		Me.ContentWrapper.BackgroundImage = CType(resources.GetObject("ContentWrapper.BackgroundImage"), System.Drawing.Image)
		Me.ContentWrapper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.ContentWrapper.Dock = System.Windows.Forms.DockStyle.Fill
		Me.ContentWrapper.Location = New System.Drawing.Point(0, 0)
		Me.ContentWrapper.Name = "ContentWrapper"
		Me.ContentWrapper.Size = New System.Drawing.Size(837, 454)
		Me.ContentWrapper.TabIndex = 15
		'
		'ToggleSideMenu
		'
		Me.ToggleSideMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
		Me.ToggleSideMenu.Checked = False
		Me.ToggleSideMenu.Cursor = System.Windows.Forms.Cursors.Hand
		Me.ToggleSideMenu.Font = New System.Drawing.Font("Segoe UI", 10.0!)
		Me.ToggleSideMenu.Location = New System.Drawing.Point(718, 10)
		Me.ToggleSideMenu.Name = "ToggleSideMenu"
		Me.ToggleSideMenu.Options = Aragon_s_String_Scanner.FlatToggle._Options.Style1
		Me.ToggleSideMenu.Size = New System.Drawing.Size(76, 33)
		Me.ToggleSideMenu.TabIndex = 14
		Me.ToggleSideMenu.Text = "FlatToggle1"
		'
		'Form1
		'
		Me.Form1.BackColor = System.Drawing.Color.White
		Me.Form1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
		Me.Form1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
		Me.Form1.Controls.Add(Me.MiddlePanel)
		Me.Form1.Controls.Add(Me.TopPanel)
		Me.Form1.Controls.Add(Me.Sidepanel)
		Me.Form1.Controls.Add(Me.FlatClose1)
		Me.Form1.Controls.Add(Me.HeaderPanel)
		Me.Form1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Form1.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
		Me.Form1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
		Me.Form1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
		Me.Form1.HeaderMaximize = False
		Me.Form1.Location = New System.Drawing.Point(0, 0)
		Me.Form1.Name = "Form1"
		Me.Form1.Size = New System.Drawing.Size(837, 454)
		Me.Form1.TabIndex = 0
		Me.Form1.Text = "Aragon's String Scanner"
		'
		'MiddlePanel
		'
		Me.MiddlePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
		Me.MiddlePanel.Controls.Add(Me.fileContainer)
		Me.MiddlePanel.Controls.Add(Me.mainLog)
		Me.MiddlePanel.Controls.Add(Me.progress)
		Me.MiddlePanel.Controls.Add(Me.Panel1)
		Me.MiddlePanel.Dock = System.Windows.Forms.DockStyle.Fill
		Me.MiddlePanel.Location = New System.Drawing.Point(0, 86)
		Me.MiddlePanel.Name = "MiddlePanel"
		Me.MiddlePanel.Size = New System.Drawing.Size(656, 368)
		Me.MiddlePanel.TabIndex = 19
		'
		'fileContainer
		'
		Me.fileContainer.FormattingEnabled = True
		Me.fileContainer.ItemHeight = 21
		Me.fileContainer.Location = New System.Drawing.Point(386, 142)
		Me.fileContainer.Name = "fileContainer"
		Me.fileContainer.Size = New System.Drawing.Size(110, 25)
		Me.fileContainer.TabIndex = 5
		Me.fileContainer.Visible = False
		'
		'mainLog
		'
		Me.mainLog.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
		Me.mainLog.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.mainLog.Dock = System.Windows.Forms.DockStyle.Top
		Me.mainLog.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.mainLog.ForeColor = System.Drawing.Color.Silver
		Me.mainLog.Location = New System.Drawing.Point(0, 0)
		Me.mainLog.Name = "mainLog"
		Me.mainLog.Size = New System.Drawing.Size(656, 328)
		Me.mainLog.TabIndex = 15
		Me.mainLog.Text = ""
		'
		'progress
		'
		Me.progress.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
		Me.progress.DarkerProgress = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(92, Byte), Integer))
		Me.progress.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.progress.Location = New System.Drawing.Point(0, 294)
		Me.progress.Maximum = 100
		Me.progress.Name = "progress"
		Me.progress.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
		Me.progress.Size = New System.Drawing.Size(656, 42)
		Me.progress.TabIndex = 14
		Me.progress.Text = "FlatProgressBar1"
		Me.progress.Value = 0
		'
		'Panel1
		'
		Me.Panel1.Controls.Add(Me.FlatLabel3)
		Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.Panel1.Location = New System.Drawing.Point(0, 336)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(656, 32)
		Me.Panel1.TabIndex = 16
		'
		'FlatLabel3
		'
		Me.FlatLabel3.AutoSize = True
		Me.FlatLabel3.BackColor = System.Drawing.Color.Transparent
		Me.FlatLabel3.Font = New System.Drawing.Font("Segoe UI", 8.0!)
		Me.FlatLabel3.ForeColor = System.Drawing.Color.Silver
		Me.FlatLabel3.Location = New System.Drawing.Point(224, 10)
		Me.FlatLabel3.Name = "FlatLabel3"
		Me.FlatLabel3.Size = New System.Drawing.Size(287, 13)
		Me.FlatLabel3.TabIndex = 0
		Me.FlatLabel3.Text = "© Copyright 2019 AragonLoaders - All Rights Reserved"
		'
		'TopPanel
		'
		Me.TopPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
		Me.TopPanel.Controls.Add(Me.directoryBox)
		Me.TopPanel.Controls.Add(Me.directoryBrowser)
		Me.TopPanel.Dock = System.Windows.Forms.DockStyle.Top
		Me.TopPanel.Location = New System.Drawing.Point(0, 54)
		Me.TopPanel.Name = "TopPanel"
		Me.TopPanel.Size = New System.Drawing.Size(656, 32)
		Me.TopPanel.TabIndex = 18
		'
		'directoryBox
		'
		Me.directoryBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
		Me.directoryBox.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.directoryBox.Location = New System.Drawing.Point(0, 3)
		Me.directoryBox.MaxLength = 32767
		Me.directoryBox.Multiline = False
		Me.directoryBox.Name = "directoryBox"
		Me.directoryBox.ReadOnly = False
		Me.directoryBox.Size = New System.Drawing.Size(543, 29)
		Me.directoryBox.TabIndex = 5
		Me.directoryBox.Text = "Folder Directory"
		Me.directoryBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.directoryBox.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.directoryBox.UseSystemPasswordChar = False
		'
		'directoryBrowser
		'
		Me.directoryBrowser.BackColor = System.Drawing.Color.Transparent
		Me.directoryBrowser.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
		Me.directoryBrowser.Cursor = System.Windows.Forms.Cursors.Hand
		Me.directoryBrowser.Dock = System.Windows.Forms.DockStyle.Right
		Me.directoryBrowser.Font = New System.Drawing.Font("Segoe UI", 12.0!)
		Me.directoryBrowser.Location = New System.Drawing.Point(543, 0)
		Me.directoryBrowser.Name = "directoryBrowser"
		Me.directoryBrowser.Rounded = False
		Me.directoryBrowser.Size = New System.Drawing.Size(113, 32)
		Me.directoryBrowser.TabIndex = 5
		Me.directoryBrowser.Text = "Browse"
		Me.directoryBrowser.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
		'
		'Sidepanel
		'
		Me.Sidepanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
		Me.Sidepanel.Controls.Add(Me.SideBottomPanel)
		Me.Sidepanel.Controls.Add(Me.SideTopPanel)
		Me.Sidepanel.Dock = System.Windows.Forms.DockStyle.Right
		Me.Sidepanel.Location = New System.Drawing.Point(656, 54)
		Me.Sidepanel.Name = "Sidepanel"
		Me.Sidepanel.Size = New System.Drawing.Size(181, 400)
		Me.Sidepanel.TabIndex = 16
		Me.Sidepanel.Visible = False
		'
		'SideBottomPanel
		'
		Me.SideBottomPanel.Controls.Add(Me.saveBtn)
		Me.SideBottomPanel.Controls.Add(Me.scanBtn)
		Me.SideBottomPanel.Controls.Add(Me.FlatLabel2)
		Me.SideBottomPanel.Controls.Add(Me.blackList)
		Me.SideBottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.SideBottomPanel.Location = New System.Drawing.Point(0, 188)
		Me.SideBottomPanel.Name = "SideBottomPanel"
		Me.SideBottomPanel.Size = New System.Drawing.Size(181, 212)
		Me.SideBottomPanel.TabIndex = 19
		'
		'saveBtn
		'
		Me.saveBtn.BackColor = System.Drawing.Color.Transparent
		Me.saveBtn.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
		Me.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand
		Me.saveBtn.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.saveBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!)
		Me.saveBtn.Location = New System.Drawing.Point(0, 138)
		Me.saveBtn.Name = "saveBtn"
		Me.saveBtn.Rounded = False
		Me.saveBtn.Size = New System.Drawing.Size(181, 29)
		Me.saveBtn.TabIndex = 7
		Me.saveBtn.Text = "Save Log"
		Me.saveBtn.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
		'
		'scanBtn
		'
		Me.scanBtn.BackColor = System.Drawing.Color.Transparent
		Me.scanBtn.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
		Me.scanBtn.Cursor = System.Windows.Forms.Cursors.Hand
		Me.scanBtn.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.scanBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!)
		Me.scanBtn.Location = New System.Drawing.Point(0, 167)
		Me.scanBtn.Name = "scanBtn"
		Me.scanBtn.Rounded = False
		Me.scanBtn.Size = New System.Drawing.Size(181, 45)
		Me.scanBtn.TabIndex = 5
		Me.scanBtn.Text = "Begin Scan"
		Me.scanBtn.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
		'
		'FlatLabel2
		'
		Me.FlatLabel2.AutoSize = True
		Me.FlatLabel2.BackColor = System.Drawing.Color.Transparent
		Me.FlatLabel2.Dock = System.Windows.Forms.DockStyle.Top
		Me.FlatLabel2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FlatLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(35, Byte), Integer))
		Me.FlatLabel2.Location = New System.Drawing.Point(0, 0)
		Me.FlatLabel2.Name = "FlatLabel2"
		Me.FlatLabel2.Size = New System.Drawing.Size(134, 17)
		Me.FlatLabel2.TabIndex = 6
		Me.FlatLabel2.Text = "Excluded Directories"
		'
		'blackList
		'
		Me.blackList.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
		Me.blackList.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.blackList.Dock = System.Windows.Forms.DockStyle.Fill
		Me.blackList.ForeColor = System.Drawing.Color.Silver
		Me.blackList.Location = New System.Drawing.Point(0, 0)
		Me.blackList.Name = "blackList"
		Me.blackList.Size = New System.Drawing.Size(181, 212)
		Me.blackList.TabIndex = 1
		Me.blackList.Text = "wire-" & Global.Microsoft.VisualBasic.ChrW(10) & "3d2d_textscreens_" & Global.Microsoft.VisualBasic.ChrW(10) & "ulx" & Global.Microsoft.VisualBasic.ChrW(10) & "ulib" & Global.Microsoft.VisualBasic.ChrW(10) & "dlib"
		'
		'SideTopPanel
		'
		Me.SideTopPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
		Me.SideTopPanel.Controls.Add(Me.searchFilters)
		Me.SideTopPanel.Controls.Add(Me.FlatLabel1)
		Me.SideTopPanel.Dock = System.Windows.Forms.DockStyle.Top
		Me.SideTopPanel.Location = New System.Drawing.Point(0, 0)
		Me.SideTopPanel.Name = "SideTopPanel"
		Me.SideTopPanel.Size = New System.Drawing.Size(181, 199)
		Me.SideTopPanel.TabIndex = 18
		'
		'searchFilters
		'
		Me.searchFilters.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
		Me.searchFilters.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.searchFilters.Dock = System.Windows.Forms.DockStyle.Fill
		Me.searchFilters.ForeColor = System.Drawing.Color.Silver
		Me.searchFilters.Location = New System.Drawing.Point(0, 17)
		Me.searchFilters.Name = "searchFilters"
		Me.searchFilters.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal
		Me.searchFilters.Size = New System.Drawing.Size(181, 182)
		Me.searchFilters.TabIndex = 0
		Me.searchFilters.Text = "STEAM_" & Global.Microsoft.VisualBasic.ChrW(10) & "http.Post" & Global.Microsoft.VisualBasic.ChrW(10) & "http.Fetch" & Global.Microsoft.VisualBasic.ChrW(10) & "CompileString" & Global.Microsoft.VisualBasic.ChrW(10) & "RunString" & Global.Microsoft.VisualBasic.ChrW(10) & "RunConsoleCommand" & Global.Microsoft.VisualBasic.ChrW(10) & "file.Delete" &
	"" & Global.Microsoft.VisualBasic.ChrW(10) & "net.Receive" & Global.Microsoft.VisualBasic.ChrW(10) & "char(" & Global.Microsoft.VisualBasic.ChrW(10) & "byte(" & Global.Microsoft.VisualBasic.ChrW(10) & "bxor" & Global.Microsoft.VisualBasic.ChrW(10) & "bit." & Global.Microsoft.VisualBasic.ChrW(10) & "<rgx>0[xX][0-9a-fA-F]+" & Global.Microsoft.VisualBasic.ChrW(10) & "<rgx>\[0-9]+" & Global.Microsoft.VisualBasic.ChrW(10) & "<rgx>\[xX" &
	"][0-9a-fA-F]" & Global.Microsoft.VisualBasic.ChrW(10) & "['\"
		Me.searchFilters.WordWrap = False
		'
		'FlatLabel1
		'
		Me.FlatLabel1.AutoSize = True
		Me.FlatLabel1.BackColor = System.Drawing.Color.Transparent
		Me.FlatLabel1.Dock = System.Windows.Forms.DockStyle.Top
		Me.FlatLabel1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FlatLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
		Me.FlatLabel1.Location = New System.Drawing.Point(0, 0)
		Me.FlatLabel1.Name = "FlatLabel1"
		Me.FlatLabel1.Size = New System.Drawing.Size(90, 17)
		Me.FlatLabel1.TabIndex = 2
		Me.FlatLabel1.Text = "Search Filters"
		'
		'FlatClose1
		'
		Me.FlatClose1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.FlatClose1.BackColor = System.Drawing.Color.White
		Me.FlatClose1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
		Me.FlatClose1.Font = New System.Drawing.Font("Marlett", 10.0!)
		Me.FlatClose1.Location = New System.Drawing.Point(805, 17)
		Me.FlatClose1.Name = "FlatClose1"
		Me.FlatClose1.Size = New System.Drawing.Size(18, 18)
		Me.FlatClose1.TabIndex = 10
		Me.FlatClose1.Text = "FlatClose1"
		Me.FlatClose1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
		'
		'HeaderPanel
		'
		Me.HeaderPanel.BackColor = System.Drawing.Color.Transparent
		Me.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top
		Me.HeaderPanel.Enabled = False
		Me.HeaderPanel.Location = New System.Drawing.Point(0, 0)
		Me.HeaderPanel.Name = "HeaderPanel"
		Me.HeaderPanel.Size = New System.Drawing.Size(837, 54)
		Me.HeaderPanel.TabIndex = 17
		'
		'Main
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(837, 454)
		Me.Controls.Add(Me.ContentWrapper)
		Me.Controls.Add(Me.ToggleSideMenu)
		Me.Controls.Add(Me.Form1)
		Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MinimumSize = New System.Drawing.Size(582, 364)
		Me.Name = "Main"
		Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = " Aragon's Backdoor Finder"
		Me.TransparencyKey = System.Drawing.Color.Fuchsia
		Me.Form1.ResumeLayout(False)
		Me.MiddlePanel.ResumeLayout(False)
		Me.Panel1.ResumeLayout(False)
		Me.Panel1.PerformLayout()
		Me.TopPanel.ResumeLayout(False)
		Me.Sidepanel.ResumeLayout(False)
		Me.SideBottomPanel.ResumeLayout(False)
		Me.SideBottomPanel.PerformLayout()
		Me.SideTopPanel.ResumeLayout(False)
		Me.SideTopPanel.PerformLayout()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents Finish As Timer
	Friend WithEvents folderBrowseDialog As FolderBrowserDialog
	Friend WithEvents ToggleSideMenu As FlatToggle
	Friend WithEvents RevealContent As Timer
	Friend WithEvents HeaderPanel As Panel
	Friend WithEvents FlatClose1 As FlatClose
	Friend WithEvents Sidepanel As Panel
	Friend WithEvents SideBottomPanel As Panel
	Friend WithEvents saveBtn As FlatButton
	Friend WithEvents scanBtn As FlatButton
	Friend WithEvents FlatLabel2 As FlatLabel
	Friend WithEvents blackList As RichTextBox
	Friend WithEvents SideTopPanel As Panel
	Friend WithEvents searchFilters As RichTextBox
	Friend WithEvents FlatLabel1 As FlatLabel
	Friend WithEvents TopPanel As Panel
	Friend WithEvents directoryBox As FlatTextBox
	Friend WithEvents directoryBrowser As FlatButton
	Friend WithEvents Form1 As FormSkin
	Friend WithEvents MiddlePanel As Panel
	Friend WithEvents fileContainer As ListBox
	Friend WithEvents mainLog As RichTextBox
	Friend WithEvents progress As FlatProgressBar
	Friend WithEvents Panel1 As Panel
	Friend WithEvents FlatLabel3 As FlatLabel
	Friend WithEvents ContentWrapper As Panel
End Class
