'Improrts
Imports System.IO
Imports System.Net

Public Class Main
    'Declaring all varibles needed
    Dim reader
    Dim newestVersion
	Dim detectedAmount = 0

	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		'Upon the program starting it will check for updates via my website
		Dim address As String = "https://aragonloaders.ml/abs/latest.txt"
		Dim client As WebClient = New WebClient()
		Dim reader As StreamReader = New StreamReader(client.OpenRead(address))

		'Some preety simple checking
		Dim newestVersion = reader.ReadToEnd()

		'Declaring each status
		Dim currentVersion = Me.ProductVersion
		Dim status = "N/A"
		If newestVersion > currentVersion Then
			status = "Update Available"
		ElseIf currentVersion = newestVersion Then
			status = "Up-To-Date"
		ElseIf currentVersion > newestVersion Then
			status = "DEV BUILD"
		Else
			status = "N/A"
		End If

		'Restoring last directory user put in for conviniece if needed to be re-scanned
		directoryBox.Text = My.Settings.lastText

		'Paste version and if an update is required
		mainLog.AppendText("Aragon's Backdoor Scanner v" + currentVersion + " / " + newestVersion + " " + status + vbNewLine)
		mainLog.AppendText("Created by Aragon http://steamcommunity.com/profiles/76561198097203962 // STEAM_1:0:68469117" + vbNewLine)

	End Sub

	Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
		'Upon closing the program the last directory will be saved for future use
		My.Settings.lastText = directoryBox.Text
		My.Settings.Save()
	End Sub

	Private Sub WebsiteButton_Click(sender As Object, e As EventArgs)
		Process.Start("www.aragonloaders.ml")
	End Sub

	Private Sub scanBtn_Click(sender As Object, e As EventArgs) Handles scanBtn.Click
		Try
			'Clear Previous Scans
			fileContainer.Items.Clear()
			mainLog.Clear()
			mainLog.AppendText("------------------->> Log: starting scan... ( " + System.DateTime.Now + " ) <<-------------------" + vbNewLine)

			'Get all files from directory with .lua in the end
			Dim FilesFromDir() As String = Directory.GetFiles(directoryBox.Text, "*.lua", SearchOption.AllDirectories)
			fileContainer.Items.AddRange(FilesFromDir) 'Add all files to a container for later use

			progress.Maximum = fileContainer.Items.Count 'Set the progress maximum value to the number of files being scanned

			For Each File In fileContainer.Items
				For Each BL In blackList.Lines 'Skip blacklisted directories probably could be improved
					Dim Str As String = Path.GetDirectoryName(File)
					If Str.Contains(BL) Then
						mainLog.AppendText("ABS -->> Skipped file ( " + File + " ) contains ( " + blackList + " )" + vbNewLine)
						Continue For
					End If
				Next

				Dim a As String
				a = My.Computer.FileSystem.ReadAllText(File) 'Read contents of every lua file detected
				For Each FileFilter In searchFilters.Lines
					If a.Contains(FileFilter) Then 'Checks if file contain any of the filters
						mainLog.AppendText("ABS -->> Found string ( " + FileFilter + " ) in file ( " + File + " )" + vbNewLine)
					End If
				Next
				'Increase progress upon scan
				progress.Increment(1)
			Next

			'After the scan is done finishing and printing the results of the scan
			Dim detectedAmount = mainLog.Lines.Count - 2
			mainLog.AppendText("------------------->> Log: finished scan... ( " + System.DateTime.Now + " ) <<-------------------" + vbNewLine)
			If detectedAmount = 0 Then
				mainLog.AppendText("[ABS] >> No results were found!" + vbNewLine)
			Else
				mainLog.AppendText("[ABS] >> Found total of " & detectedAmount & " results" + vbNewLine)
			End If
			mainLog.AppendText("Thank you for using my tool  - Aragon" + vbNewLine)
			mainLog.AppendText("http://steamcommunity.com/profiles/76561198097203962 // STEAM_1:0:68469117" + vbNewLine)
			Me.Text = "Aragon's Backdoor Scanner (Found " & detectedAmount & " results)"
			'Running final timer to finish the scan
			Finish.Start()
		Catch ex As Exception
			'Error catch incase the directory is invalid, will still run the finish
			Finish.Start()
			MsgBox(ex.Message, MsgBoxStyle.Critical)
		End Try

	End Sub

	Private Sub directoryBrowser_Click(sender As Object, e As EventArgs) Handles directoryBrowser.Click
		If folderBrowseDialog.ShowDialog() = DialogResult.OK Then
			directoryBox.Text = folderBrowseDialog.SelectedPath 'Setting the directory upon a successful and valid path selection
		End If
	End Sub

	Private Sub ToggleSideMenu_CheckedChanged(sender As Object) Handles ToggleSideMenu.CheckedChanged
		Sidepanel.Visible = ToggleSideMenu.Checked
	End Sub

	Private Sub Finish_Tick_1(sender As Object, e As EventArgs) Handles Finish.Tick
		'Stopping the timer to prevent loop (onetime tick)
		Finish.Stop()

		'Setting the progress to 0
		progress.Value = 0

		'Displaying an interactive box promting the user to save the log if there are more then 1 detected line
		If MsgBox("Scanning done found " & mainLog.Lines.Count - 3 & " results in total, would you like to save the list?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

			'Declaring file as a StreamWriter some preety simple and standard way of saving files
			Dim file As System.IO.StreamWriter
			Directory.CreateDirectory(Environment.CurrentDirectory() & "\scans")
			file = My.Computer.FileSystem.OpenTextFileWriter(Environment.CurrentDirectory() & "\scans\scan-results" & ".txt", False)
			file.WriteLine(mainLog.Text)
			file.Close()

			'Opening the directory at the end of the save
			Process.Start(Environment.CurrentDirectory() & "\scans\")
		End If
	End Sub

	Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
		Dim file As System.IO.StreamWriter
		Directory.CreateDirectory(Environment.CurrentDirectory() & "\scans")
		file = My.Computer.FileSystem.OpenTextFileWriter(Environment.CurrentDirectory() & "\scans\scan-results" & ".txt", False)
		file.WriteLine(mainLog.Text)
		file.Close()
		Process.Start(Environment.CurrentDirectory() & "\scans\")
	End Sub

	Private Sub FlatLabel3_Click(sender As Object, e As EventArgs) Handles FlatLabel3.Click
		Process.Start("https://aragonloaders.ml/abs")
	End Sub

	Private Sub RevealContent_Tick(sender As Object, e As EventArgs) Handles RevealContent.Tick
		RevealContent.Stop()
		ContentWrapper.Visible = False
	End Sub
End Class
