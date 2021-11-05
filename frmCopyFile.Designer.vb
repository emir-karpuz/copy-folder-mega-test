<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCopyFile
    Inherits MetroFramework.Forms.MetroForm

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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCopyFile))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.dgvFiles = New MetroFramework.Controls.MetroGrid()
        Me.lblCopyFromPath = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.btnCopyFromPath = New System.Windows.Forms.Button()
        Me.lblCount = New MetroFramework.Controls.MetroLabel()
        Me.lblCopyToPath = New MetroFramework.Controls.MetroLabel()
        Me.btnCopyToPath = New System.Windows.Forms.Button()
        Me.lblFolder = New MetroFramework.Controls.MetroLabel()
        Me.lblStatus = New MetroFramework.Controls.MetroLabel()
        Me.prgbarSpinner = New MetroFramework.Controls.MetroProgressSpinner()
        Me.fbdSearch = New System.Windows.Forms.FolderBrowserDialog()
        Me.bgWorker = New System.ComponentModel.BackgroundWorker()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dgvFiles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(20, 60)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.dgvFiles)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblCopyFromPath)
        Me.SplitContainer1.Panel2.Controls.Add(Me.MetroLabel2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnCopyFromPath)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblCount)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblCopyToPath)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnCopyToPath)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblFolder)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblStatus)
        Me.SplitContainer1.Size = New System.Drawing.Size(796, 619)
        Me.SplitContainer1.SplitterDistance = 502
        Me.SplitContainer1.TabIndex = 0
        '
        'dgvFiles
        '
        Me.dgvFiles.AllowUserToAddRows = False
        Me.dgvFiles.AllowUserToDeleteRows = False
        Me.dgvFiles.AllowUserToResizeRows = False
        Me.dgvFiles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvFiles.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvFiles.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvFiles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvFiles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvFiles.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvFiles.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvFiles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvFiles.EnableHeadersVisualStyles = False
        Me.dgvFiles.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgvFiles.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvFiles.Location = New System.Drawing.Point(0, 0)
        Me.dgvFiles.Name = "dgvFiles"
        Me.dgvFiles.ReadOnly = True
        Me.dgvFiles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvFiles.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvFiles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFiles.Size = New System.Drawing.Size(796, 502)
        Me.dgvFiles.Style = MetroFramework.MetroColorStyle.Teal
        Me.dgvFiles.TabIndex = 0
        Me.dgvFiles.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'lblCopyFromPath
        '
        Me.lblCopyFromPath.AutoSize = True
        Me.lblCopyFromPath.Location = New System.Drawing.Point(146, 12)
        Me.lblCopyFromPath.Name = "lblCopyFromPath"
        Me.lblCopyFromPath.Size = New System.Drawing.Size(26, 19)
        Me.lblCopyFromPath.Style = MetroFramework.MetroColorStyle.Red
        Me.lblCopyFromPath.TabIndex = 7
        Me.lblCopyFromPath.Text = "C:\"
        Me.lblCopyFromPath.Theme = MetroFramework.MetroThemeStyle.Light
        Me.lblCopyFromPath.UseStyleColors = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(15, 12)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(125, 19)
        Me.MetroLabel2.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroLabel2.TabIndex = 6
        Me.MetroLabel2.Text = "EXEnew Dosya Yolu:"
        Me.MetroLabel2.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroLabel2.UseStyleColors = True
        '
        'btnCopyFromPath
        '
        Me.btnCopyFromPath.BackgroundImage = Global.MegaUpdate.My.Resources.Resources._029_ellipsis
        Me.btnCopyFromPath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCopyFromPath.FlatAppearance.BorderSize = 0
        Me.btnCopyFromPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCopyFromPath.Location = New System.Drawing.Point(769, 7)
        Me.btnCopyFromPath.Name = "btnCopyFromPath"
        Me.btnCopyFromPath.Size = New System.Drawing.Size(24, 24)
        Me.btnCopyFromPath.TabIndex = 5
        Me.btnCopyFromPath.UseVisualStyleBackColor = True
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.lblCount.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.lblCount.Location = New System.Drawing.Point(146, 78)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(81, 19)
        Me.lblCount.Style = MetroFramework.MetroColorStyle.Red
        Me.lblCount.TabIndex = 4
        Me.lblCount.Text = "Başlatılmadı"
        Me.lblCount.Theme = MetroFramework.MetroThemeStyle.Light
        Me.lblCount.UseStyleColors = True
        '
        'lblCopyToPath
        '
        Me.lblCopyToPath.AutoSize = True
        Me.lblCopyToPath.Location = New System.Drawing.Point(146, 45)
        Me.lblCopyToPath.Name = "lblCopyToPath"
        Me.lblCopyToPath.Size = New System.Drawing.Size(26, 19)
        Me.lblCopyToPath.Style = MetroFramework.MetroColorStyle.Red
        Me.lblCopyToPath.TabIndex = 3
        Me.lblCopyToPath.Text = "C:\"
        Me.lblCopyToPath.Theme = MetroFramework.MetroThemeStyle.Light
        Me.lblCopyToPath.UseStyleColors = True
        '
        'btnCopyToPath
        '
        Me.btnCopyToPath.BackgroundImage = Global.MegaUpdate.My.Resources.Resources._029_ellipsis
        Me.btnCopyToPath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCopyToPath.FlatAppearance.BorderSize = 0
        Me.btnCopyToPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCopyToPath.Location = New System.Drawing.Point(769, 37)
        Me.btnCopyToPath.Name = "btnCopyToPath"
        Me.btnCopyToPath.Size = New System.Drawing.Size(24, 24)
        Me.btnCopyToPath.TabIndex = 2
        Me.btnCopyToPath.UseVisualStyleBackColor = True
        '
        'lblFolder
        '
        Me.lblFolder.AutoSize = True
        Me.lblFolder.Location = New System.Drawing.Point(15, 45)
        Me.lblFolder.Name = "lblFolder"
        Me.lblFolder.Size = New System.Drawing.Size(126, 19)
        Me.lblFolder.Style = MetroFramework.MetroColorStyle.Teal
        Me.lblFolder.TabIndex = 1
        Me.lblFolder.Text = "mERPot Dosya Yolu:"
        Me.lblFolder.Theme = MetroFramework.MetroThemeStyle.Light
        Me.lblFolder.UseStyleColors = True
        '
        'lblStatus
        '
        Me.lblStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.lblStatus.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.lblStatus.Location = New System.Drawing.Point(15, 78)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(125, 19)
        Me.lblStatus.Style = MetroFramework.MetroColorStyle.Teal
        Me.lblStatus.TabIndex = 0
        Me.lblStatus.Text = "Durum:"
        Me.lblStatus.Theme = MetroFramework.MetroThemeStyle.Light
        Me.lblStatus.UseStyleColors = True
        '
        'prgbarSpinner
        '
        Me.prgbarSpinner.Location = New System.Drawing.Point(693, 18)
        Me.prgbarSpinner.Maximum = 100
        Me.prgbarSpinner.Name = "prgbarSpinner"
        Me.prgbarSpinner.Size = New System.Drawing.Size(36, 36)
        Me.prgbarSpinner.Spinning = False
        Me.prgbarSpinner.Style = MetroFramework.MetroColorStyle.Red
        Me.prgbarSpinner.TabIndex = 2
        Me.prgbarSpinner.Theme = MetroFramework.MetroThemeStyle.Light
        Me.prgbarSpinner.UseSelectable = True
        '
        'bgWorker
        '
        Me.bgWorker.WorkerReportsProgress = True
        Me.bgWorker.WorkerSupportsCancellation = True
        '
        'btnStart
        '
        Me.btnStart.BackgroundImage = Global.MegaUpdate.My.Resources.Resources._008_check
        Me.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnStart.FlatAppearance.BorderSize = 0
        Me.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStart.Location = New System.Drawing.Point(735, 18)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(36, 36)
        Me.btnStart.TabIndex = 3
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.BackgroundImage = Global.MegaUpdate.My.Resources.Resources._076_remove
        Me.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Location = New System.Drawing.Point(777, 18)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(36, 36)
        Me.btnExit.TabIndex = 1
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmCopyFile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(836, 699)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.prgbarSpinner)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmCopyFile"
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "mERPot Kopyalama Programı"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dgvFiles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents btnExit As Button
    Friend WithEvents lblStatus As MetroFramework.Controls.MetroLabel
    Friend WithEvents prgbarSpinner As MetroFramework.Controls.MetroProgressSpinner
    Friend WithEvents fbdSearch As FolderBrowserDialog
    Friend WithEvents lblFolder As MetroFramework.Controls.MetroLabel
    Friend WithEvents bgWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents dgvFiles As MetroFramework.Controls.MetroGrid
    Friend WithEvents btnCopyToPath As Button
    Friend WithEvents lblCount As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblCopyToPath As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnStart As Button
    Friend WithEvents btnCopyFromPath As Button
    Friend WithEvents lblCopyFromPath As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
End Class
