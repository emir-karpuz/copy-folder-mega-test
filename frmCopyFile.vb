﻿Imports System.IO

Public Class frmCopyFile

#Region "Class Fields"

    ''' <summary>
    ''' Dosyaların gridde gösterilmesi için kullanılacak datatable
    ''' </summary>
    Dim filesDT As New DataTable

    ''' <summary>
    ''' Rastgele sayı
    ''' </summary>
    Dim randomNumber As Integer = 0

    ''' <summary>
    ''' Dosya uzantısını tutar
    ''' </summary>
    Dim fileExtension As String = String.Empty

    ''' <summary>
    ''' EXEnew klasöründeki toplam dosya sayısını tutar
    ''' </summary>
    Dim EXEnewFileCount As Integer = 0

    ''' <summary>
    ''' Kopyalanacak mERPot.exe yolu
    ''' </summary>
    Dim copyToPath As String = String.Empty

    ''' <summary>
    ''' EXEnew klasörünün yolu
    ''' </summary>
    Dim copyFromPath As String = String.Empty

#End Region

#Region "Class Methods"

    ''' <summary>
    ''' Dosya adını alır ve uzantısından ayırıp döndürür
    ''' </summary>
    ''' <param name="fileName"></param>
    ''' <returns></returns>
    Private Function getFileName(fileName As String) As String
        Dim fileNamePieces As String() = Nothing

        fileExtension = Path.GetExtension(fileName) '.dll
        fileExtension = Strings.Right(fileExtension, fileExtension.Length - 1)  'dll

        If fileName.Contains("\EXE") Then
            fileNamePieces = Split(fileName, "\")
            fileName = Strings.Left(fileNamePieces(2), fileNamePieces(2).Length - 4)  'deneme.txt -> deneme, fileNamePieces(2)'da tutuluyor
        Else
            fileName = Strings.Left(fileName, fileName.Length - Path.GetExtension(fileName).Length) 'Haali\avi.x64.dll -> Haali\avi.x64
        End If

        Return fileName
    End Function

    ''' <summary>
    ''' EXEnew'deki dosya yoluna ait klasörün adı döndürür
    ''' </summary>
    ''' <param name="folderPath"></param>
    ''' <returns></returns>
    Private Function getFolderName(folderPath As String) As String
        folderPath = Strings.Right(folderPath, folderPath.Length - InStr(folderPath, "\EXEnew\") - 7)
        Return folderPath
    End Function

    ''' <summary>
    ''' Bugünü "yyaagg" formatında getirir
    ''' </summary>
    ''' <returns></returns>
    Private Function getFileDay() As String
        Dim day As String = DateTime.Today.ToString("yyMMdd")
        Return day
    End Function

    ''' <summary>
    ''' Programa ait dosyaları ve klasörleri EXEnew'dekilerle değişir ve eskilerini EXEold'a atar
    ''' </summary>
    Private Sub updateProgram()
        Try
            Dim EXEnewFiles() As String = Directory.GetFiles($"{copyFromPath}\EXEnew\", "*.*", SearchOption.AllDirectories)
            Dim exeOldPath As String = copyToPath & "\EXEold\"
            Dim exeNewPath As String = copyFromPath & "\EXEnew\"
            Dim copyList As New ArrayList
            Dim EXEnewFileIndex As Integer = 0
            Dim EXEoldFileIndex As Integer = 0
            Dim random As New Random
            randomNumber = random.Next(1000, 9999)

            For Each EXEnewFile As String In EXEnewFiles            'KOPYALANACAK DOSYALARIN LİSTESİ OLUŞTURULUR
                If Not EXEnewFile.Contains("desktop.ini") Then
                    copyList.Add(getFolderName(EXEnewFile))
                    EXEnewFileCount += 1
                End If
            Next

            For Each item In copyList
                Dim filesDR As DataRow = filesDT.NewRow
                If File.Exists($"{copyToPath}\{item}") Then
                    My.Computer.FileSystem.MoveFile($"{copyToPath}\{item}", $"{exeOldPath}\{getFileName(item)}_{getFileDay()}_{randomNumber}.{fileExtension}")
                    EXEoldFileIndex += 1
                    filesDR("EskiDosya") = $"{getFileName(item)}_{getFileDay()}_{randomNumber}.{fileExtension}"
                End If

                My.Computer.FileSystem.CopyFile($"{exeNewPath}\{item}", $"{copyToPath}\{item}")
                EXEnewFileIndex += 1
                filesDR("YeniDosya") = $"{item}"
                filesDT.Rows.Add(filesDR)
                bgWorker.ReportProgress((EXEnewFileIndex / copyList.Count) * 100)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Hata")
        End Try
    End Sub

#End Region

#Region "Form Events"

    Private Sub frmCopyFile_Load(sender As Object, e As EventArgs) Handles Me.Load
        filesDT.Columns.Add("EskiDosya") : filesDT.Columns.Add("YeniDosya")
        dgvFiles.DataSource = filesDT
        dgvFiles.Columns(0).HeaderText = "EXEold'a giden dosyalar" : dgvFiles.Columns(1).HeaderText = "EXEnew'den alınan dosyalar"
        If File.Exists($"{Application.UserAppDataPath}\mERPotTo.txt") Then copyToPath = File.ReadAllText($"{Application.UserAppDataPath}\mERPotTo.txt")
        If File.Exists($"{Application.UserAppDataPath}\mERPotFrom.txt") Then copyFromPath = File.ReadAllText($"{Application.UserAppDataPath}\mERPotFrom.txt")
        lblCopyToPath.Text = copyToPath : lblCopyFromPath.Text = copyFromPath
    End Sub

    Private Sub bgWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgWorker.DoWork
        updateProgram()
    End Sub

    Private Sub bgWorker_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles bgWorker.ProgressChanged
        prgbarSpinner.Value = e.ProgressPercentage
        dgvFiles.Refresh()
    End Sub

    Private Sub bgWorker_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgWorker.RunWorkerCompleted
        If EXEnewFileCount = 0 Then
            lblCount.Text = "Hata oluştu."
            btnCopyToPath.Enabled = True
            btnCopyFromPath.Enabled = True
            btnStart.Enabled = True
        Else
            lblCount.Text = $"İşlem tamanlandı. {EXEnewFileCount} dosya kopyalandı."
            prgbarSpinner.Style = MetroFramework.MetroColorStyle.Green : prgbarSpinner.Refresh()
        End If
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If copyToPath = String.Empty Then MessageBox.Show("Lütfen kopyalanacak yolu seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information) : Return
        If copyFromPath = String.Empty Then MessageBox.Show("Lütfen kopyalayacak yolu seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information) : Return
        btnStart.Enabled = False
        btnCopyToPath.Enabled = False
        lblCount.Text = "Kopyalanıyor"
        bgWorker.RunWorkerAsync()
    End Sub

    Private Sub btnCopyToPath_Click(sender As Object, e As EventArgs) Handles btnCopyToPath.Click
        Dim dialogResult As DialogResult = fbdSearch.ShowDialog
        If dialogResult = DialogResult.OK Then copyToPath = fbdSearch.SelectedPath
        lblCopyToPath.Text = copyToPath
        If File.Exists($"{Application.UserAppDataPath}\mERPotTo.txt") Then File.Delete($"{Application.UserAppDataPath}\mERPotTo.txt")
        File.WriteAllText($"{Application.UserAppDataPath}\mERPotTo.txt", copyToPath)
    End Sub

    Private Sub btnCopyFromPath_Click(sender As Object, e As EventArgs) Handles btnCopyFromPath.Click
        Dim dialogResult As DialogResult = fbdSearch.ShowDialog
        If dialogResult = DialogResult.OK Then
            If fbdSearch.SelectedPath.Contains("\EXEnew") Then MessageBox.Show("Lütfen EXEnew klasörünü barındıran klasörü seçiniz.") : Return
            copyFromPath = fbdSearch.SelectedPath
        End If
        lblCopyFromPath.Text = copyFromPath
        If File.Exists($"{Application.UserAppDataPath}\mERPotFrom.txt") Then File.Delete($"{Application.UserAppDataPath}\mERPotFrom.txt")
        File.WriteAllText($"{Application.UserAppDataPath}\mERPotFrom.txt", copyFromPath)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        If bgWorker.IsBusy Then
            Dim dialogResult As DialogResult = MessageBox.Show("İşlemi yarıda kesmek istediğinize emin misiniz?", "Uyarı",
                                                               MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If dialogResult = DialogResult.Yes Then bgWorker.CancelAsync()
        End If
        Close()
    End Sub

#End Region

#Region "Unused Code Blocks"

#Region "Copy Every Folder and File in Directory"

    'For Each dirPath As String In Directory.GetDirectories(debugPath & "\EXEnew", "*", SearchOption.AllDirectories)
    '            Directory.CreateDirectory(dirPath.Replace(debugPath & "\EXEnew", debugPath & "\EXEold"))
    '        Next

    'For Each newPath As String In Directory.GetFiles(debugPath & "\EXEnew", "*.*", SearchOption.AllDirectories)
    '            newPath = dosyaAdiBul(newPath) & "." & fileExtension
    '            If IO.File.Exists(newPath) Then
    '                updateProgram(newPath, randomNumber)
    '                File.Copy(newPath, newPath.Replace(debugPath & "\EXEnew", debugPath & "\EXEold"), True)
    '            End If
    'Next

#End Region

#Region "MegaUpdate v1.2 Copy"

    'Directory.CreateDirectory(folder.Replace(debugPath & "\EXEnew", debugPath & "\EXEold"))
    'Directory.CreateDirectory(folder.Replace(debugPath & "\EXEnew", debugPath))

    'Try
    '        For Each file As String In files    'HER BİR DOSYA İÇİN
    '            file = getFileName(file) & "." & fileExtension  'ABC.TXT FORMATINA GETİR
    '            If IO.File.Exists(file) Then    'EĞER VARSA
    '                updateProgram(file, randomNumber, getFolderName(folder))
    '            Else
    '                My.Computer.FileSystem.CopyFile(".\EXEnew\" & file, debugPath & "\" & file, overwrite:=True)
    '                'EXEnewFileIndex = txtNewFiles.GetLineFromCharIndex(txtNewFiles.Text.Length) + 1
    '                'txtNewFiles.Text += EXEnewFileIndex & ". Yeni Dosya Eklendi: " & file & vbCrLf
    '            End If
    '            EXEnewFileCount += 1
    '        Next

    '    'lblResult.Text &= "İşlem Başarılı"
    '    'lblNewFiles.Text &= EXEnewFileCount
    'Catch ex As Exception
    '    MessageBox.Show(ex.Message, "Error")
    'End Try

#End Region

#Region "UpdateProgram Sub"

    '''' <summary>
    '''' Programa ait dosyaları EXEnew'dekilerle değişir ve eskilerini EXEold'a atar
    '''' </summary>
    '''' <param name="programName"></param>
    '''' <param name="randomNumber"></param>
    'Sub updateProgram(programName, randomNumber)
    '    Try
    '        Dim EXEoldFileName, debugFileName As String
    '        'Dim EXEoldFileIndex As Integer = 1

    '        EXEoldFileName = getFileName(programName) & "_" & getFileDay() & "_" & randomNumber.ToString & "." & fileExtension

    '        My.Computer.FileSystem.RenameFile(programName, EXEoldFileName)

    '        My.Computer.FileSystem.MoveFile(debugPath & "\" & EXEoldFileName, ".\EXEold\" & "\" & EXEoldFileName)

    '        debugFileName = debugPath & "\" & programName

    '        My.Computer.FileSystem.CopyFile(".\EXEnew\" & programName, debugFileName, overwrite:=True)

    '        'EXEoldFileIndex = txtOldFiles.GetLineFromCharIndex(txtOldFiles.Text.Length) + 1

    '        'txtOldFiles.Text += EXEoldFileIndex & ". Eski Dosya Çıkarıldı: " & EXEoldFileName & vbCrLf

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Error")
    '    End Try
    'End Sub

#End Region

#Region "Copy Every Folder in Directory by Array Search"

    'For Each EXEnewFolder As String In EXEnewFolders
    '    Dim debugFolder As String = debugPath & "\" & getFolderName(EXEnewFolder)
    '    If Not Directory.Exists(debugFolder) Then
    '        Directory.CreateDirectory(debugFolder) 'EXENEW'DEKİ KLASÖRLERİN TAMAMI DEBUG KLASÖRÜNDE OLUŞTURULUR
    '    End If
    '    Dim exeOldFolder As String = exeOldPath & "\" & getFolderName(EXEnewFolder)
    '    Directory.CreateDirectory(exeOldFolder)   'EXENEW'DEKİ KLASÖRLERİN TAMAMI EXEOLD'DA OLUŞTURULUR
    'Next

#End Region

#Region "Old GetFileName"

    '''' <summary>
    '''' Dosya adını alır ve uzantısından ayırıp döndürür
    '''' </summary>
    '''' <param name="fileName"></param>
    '''' <returns></returns>
    'Private Function getFileName(fileName As String) As String
    '    Dim fileNamePieces As String() = Nothing

    '    fileExtension = Path.GetExtension(fileName)
    '    fileExtension = Strings.Right(fileExtension, fileExtension.Length - 1)

    '    If fileName.Contains("\EXE") Then
    '        fileNamePieces = Split(fileName, "\")
    '        fileName = Strings.Left(fileNamePieces(2), fileNamePieces(2).Length - 4)  'deneme.txt -> deneme, fileNamePieces(2)'da tutuluyor
    '    Else
    '        fileName = Strings.Left(fileName, InStr(fileName, ".") - 1)
    '    End If

    '    Return fileName
    'End Function

#End Region

#End Region

End Class
