Imports System.IO

Public Class frmCopyFile
    Dim randomNumber As Integer = 0
    Dim fileExtension As String = String.Empty
    Dim EXEnewFileCount As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim folders() As String = Directory.GetDirectories(Application.StartupPath & "\EXEnew\") 'EXEnew Klasörlerinin adlarını alır
        Dim files() As String = Directory.GetFiles(".\EXEnew\")  'EXEnew Dosyalarının adlarını alır

        Dim random As New Random
        randomNumber = random.Next(1000, 9999)

        Dim EXEnewFileIndex As Integer = 1


        For Each folder As String In folders
            Directory.CreateDirectory(folder.Replace(Application.StartupPath & "\EXEnew", Application.StartupPath & "\EXEold"))
            Directory.CreateDirectory(folder.Replace(Application.StartupPath & "\EXEnew", Application.StartupPath))
        Next

        Try
            For Each folder As String In folders    'HER BİR KLASÖR İÇİN
                For Each file As String In files    'HER BİR DOSYA İÇİN
                    file = getFileName(file) & "." & fileExtension  'ABC.TXT FORMATINA GETİR
                    If IO.File.Exists(file) Then    'EĞER VARSA
                        updateProgram(file, randomNumber, getFolderName(folder))
                    Else
                        My.Computer.FileSystem.CopyFile(".\EXEnew\" & file, Application.StartupPath & "\" & file, overwrite:=True)
                        'EXEnewFileIndex = txtNewFiles.GetLineFromCharIndex(txtNewFiles.Text.Length) + 1
                        'txtNewFiles.Text += EXEnewFileIndex & ". Yeni Dosya Eklendi: " & file & vbCrLf
                    End If
                    EXEnewFileCount += 1
                Next
            Next

            'lblResult.Text &= "İşlem Başarılı"
            'lblNewFiles.Text &= EXEnewFileCount
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try

    End Sub

    Sub updateProgram(programName, randomNumber, folderName)
        Try
            Dim EXEoldFileName, currentFileName As String
            'Dim EXEoldFileIndex As Integer = 1

            EXEoldFileName = getFileName(programName) & "_" & getFileDay() & "_" & randomNumber.ToString & "." & fileExtension

            My.Computer.FileSystem.RenameFile(programName, EXEoldFileName)

            My.Computer.FileSystem.MoveFile(Application.StartupPath & "\" & EXEoldFileName, ".\EXEold\" & folderName & "\" & EXEoldFileName)

            currentFileName = Application.StartupPath & "\" & programName

            My.Computer.FileSystem.CopyFile(".\EXEnew\" & programName, currentFileName, overwrite:=True)

            'EXEoldFileIndex = txtOldFiles.GetLineFromCharIndex(txtOldFiles.Text.Length) + 1

            'txtOldFiles.Text += EXEoldFileIndex & ". Eski Dosya Çıkarıldı: " & EXEoldFileName & vbCrLf

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
    End Sub

    Function getFileName(fileName As String) As String
        Dim fileNamePieces As String() = Nothing

        fileExtension = Strings.Right(fileName, 3)

        If fileName.Contains("\EXE") Then
            fileNamePieces = Split(fileName, "\")
            fileName = Strings.Left(fileNamePieces(2), fileNamePieces(2).Length - 4)  'deneme.txt -> deneme, fileNamePieces(2)'da tutuluyor
        Else
            fileName = Strings.Left(fileName, InStr(fileName, ".") - 1)
        End If

        Return fileName
    End Function

    Function getFolderName(folderPath As String) As String
        folderPath = Strings.Right(folderPath, folderPath.Length - InStr(folderPath, "\EXEnew\") - 7)
        Return folderPath
    End Function

    Function getFileDay() As String
        Dim day As String = DateTime.Today.ToString("yyMMdd")
        Return day
    End Function

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    'For Each dirPath As String In Directory.GetDirectories(Application.StartupPath & "\EXEnew", "*", SearchOption.AllDirectories)
    '            Directory.CreateDirectory(dirPath.Replace(Application.StartupPath & "\EXEnew", Application.StartupPath & "\EXEold"))
    '        Next

    'For Each newPath As String In Directory.GetFiles(Application.StartupPath & "\EXEnew", "*.*", SearchOption.AllDirectories)
    '            newPath = dosyaAdiBul(newPath) & "." & fileExtension
    '            If IO.File.Exists(newPath) Then
    '                updateProgram(newPath, randomNumber)
    '                File.Copy(newPath, newPath.Replace(Application.StartupPath & "\EXEnew", Application.StartupPath & "\EXEold"), True)
    '            End If
    'Next

End Class
