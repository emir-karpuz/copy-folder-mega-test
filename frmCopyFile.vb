Imports System.IO

Public Class frmCopyFile

#Region "Class Fields"

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
    ''' Debug klasörünün yolunu tutar
    ''' </summary>
    ReadOnly debugPath As String = Application.StartupPath

    ''' <summary>
    ''' EXEnew klasörünün yolunu tutar
    ''' </summary>
    ReadOnly exeNewPath As String = debugPath & "\EXEnew\"

    ''' <summary>
    ''' EXEold klasörünün yolunu tutar
    ''' </summary>
    ReadOnly exeOldPath As String = debugPath & "\EXEold\"

    ''' <summary>
    ''' EXEnew Klasörlerinin adlarını alır
    ''' </summary>
    ReadOnly EXEnewFolders() As String = Directory.GetDirectories(exeNewPath, "*.*", SearchOption.AllDirectories)

    ''' <summary>
    ''' EXEnew Dosyalarının adlarını alır
    ''' </summary>
    ReadOnly EXEnewFiles() As String = Directory.GetFiles(".\EXEnew\", "*.*", SearchOption.AllDirectories)

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

        Dim copyList As New ArrayList
        Dim EXEnewFileIndex As Integer = 0
        Dim EXEoldFileIndex As Integer = 0

        Dim random As New Random
        randomNumber = random.Next(1000, 9999)

        Try
            For Each EXEnewFile As String In EXEnewFiles            'KOPYALANACAK DOSYALARIN LİSTESİ OLUŞTURULUR
                If Not EXEnewFile.Contains("desktop.ini") Then
                    copyList.Add(getFolderName(EXEnewFile))
                    EXEnewFileCount += 1
                End If
            Next

            For Each item In copyList
                If File.Exists(debugPath & "\" & item) Then
                    My.Computer.FileSystem.CopyFile(debugPath & "\" & item,
                                                    exeOldPath & "\" & getFileName(item) & "_" & getFileDay() & "_" & randomNumber.ToString & "." & fileExtension)
                    EXEoldFileIndex += 1
                    txtOldFiles.Text += EXEoldFileIndex & ". Eski Dosya Çıkarıldı: " & getFileName(item) & "_" & getFileDay() &
                                                                                              "_" & randomNumber.ToString & "." & fileExtension & vbCrLf
                Else
                    My.Computer.FileSystem.CopyFile(exeNewPath & "\" & item, debugPath & "\" & item)
                    EXEnewFileIndex += 1
                    txtNewFiles.Text += EXEnewFileIndex & ". Yeni Dosya Eklendi: " & item & vbCrLf
                End If
            Next

            lblResult.Text &= "İşlem Başarılı"
            lblNewFiles.Text &= EXEnewFileCount

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try

    End Sub

#End Region

#Region "Form Events"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        updateProgram()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
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
