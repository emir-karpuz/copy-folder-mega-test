<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCopyFile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCopyFile))
        Me.txtNewFiles = New System.Windows.Forms.TextBox()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtOldFiles = New System.Windows.Forms.TextBox()
        Me.lblNewFiles = New System.Windows.Forms.Label()
        Me.lblEklenen = New System.Windows.Forms.Label()
        Me.lblCikarilan = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtNewFiles
        '
        Me.txtNewFiles.BackColor = System.Drawing.Color.Honeydew
        Me.txtNewFiles.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtNewFiles.Location = New System.Drawing.Point(14, 63)
        Me.txtNewFiles.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNewFiles.Multiline = True
        Me.txtNewFiles.Name = "txtNewFiles"
        Me.txtNewFiles.ReadOnly = True
        Me.txtNewFiles.Size = New System.Drawing.Size(400, 644)
        Me.txtNewFiles.TabIndex = 2
        Me.txtNewFiles.TabStop = False
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.BackColor = System.Drawing.Color.Green
        Me.lblResult.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblResult.ForeColor = System.Drawing.Color.White
        Me.lblResult.Location = New System.Drawing.Point(12, 13)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(57, 16)
        Me.lblResult.TabIndex = 4
        Me.lblResult.Text = "Sonuç : "
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Red
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(733, 13)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(87, 42)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "ÇIKIŞ"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'txtOldFiles
        '
        Me.txtOldFiles.BackColor = System.Drawing.Color.MistyRose
        Me.txtOldFiles.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtOldFiles.Location = New System.Drawing.Point(420, 63)
        Me.txtOldFiles.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtOldFiles.Multiline = True
        Me.txtOldFiles.Name = "txtOldFiles"
        Me.txtOldFiles.ReadOnly = True
        Me.txtOldFiles.Size = New System.Drawing.Size(400, 644)
        Me.txtOldFiles.TabIndex = 3
        Me.txtOldFiles.TabStop = False
        '
        'lblNewFiles
        '
        Me.lblNewFiles.AutoSize = True
        Me.lblNewFiles.BackColor = System.Drawing.Color.Navy
        Me.lblNewFiles.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblNewFiles.ForeColor = System.Drawing.Color.White
        Me.lblNewFiles.Location = New System.Drawing.Point(417, 13)
        Me.lblNewFiles.Name = "lblNewFiles"
        Me.lblNewFiles.Size = New System.Drawing.Size(194, 16)
        Me.lblNewFiles.TabIndex = 5
        Me.lblNewFiles.Text = "Toplam EXEnew Dosya Sayısı : "
        '
        'lblEklenen
        '
        Me.lblEklenen.AutoSize = True
        Me.lblEklenen.BackColor = System.Drawing.Color.Honeydew
        Me.lblEklenen.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblEklenen.ForeColor = System.Drawing.Color.Black
        Me.lblEklenen.Location = New System.Drawing.Point(163, 43)
        Me.lblEklenen.Name = "lblEklenen"
        Me.lblEklenen.Size = New System.Drawing.Size(69, 16)
        Me.lblEklenen.TabIndex = 6
        Me.lblEklenen.Text = "Eklenenler"
        '
        'lblCikarilan
        '
        Me.lblCikarilan.AutoSize = True
        Me.lblCikarilan.BackColor = System.Drawing.Color.MistyRose
        Me.lblCikarilan.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblCikarilan.ForeColor = System.Drawing.Color.Black
        Me.lblCikarilan.Location = New System.Drawing.Point(578, 43)
        Me.lblCikarilan.Name = "lblCikarilan"
        Me.lblCikarilan.Size = New System.Drawing.Size(72, 16)
        Me.lblCikarilan.TabIndex = 7
        Me.lblCikarilan.Text = "Çıkarılanlar"
        '
        'frmCopyFile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(836, 720)
        Me.Controls.Add(Me.lblCikarilan)
        Me.Controls.Add(Me.lblEklenen)
        Me.Controls.Add(Me.lblNewFiles)
        Me.Controls.Add(Me.txtOldFiles)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.txtNewFiles)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmCopyFile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MEGA-Copy File Test"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNewFiles As System.Windows.Forms.TextBox
    Friend WithEvents lblResult As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents txtOldFiles As TextBox
    Friend WithEvents lblNewFiles As Label
    Friend WithEvents lblEklenen As Label
    Friend WithEvents lblCikarilan As Label
End Class
