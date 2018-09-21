<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPackFerret
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPackFerret))
        Me.tlpAll = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpAbout = New System.Windows.Forms.TableLayoutPanel()
        Me.lbVerControl = New System.Windows.Forms.Label()
        Me.tlpMain = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpButtons = New System.Windows.Forms.TableLayoutPanel()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmdRun = New System.Windows.Forms.Button()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.cmdEdit = New System.Windows.Forms.Button()
        Me.cmdParams = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.tlpPacks = New System.Windows.Forms.TableLayoutPanel()
        Me.lbPacks = New System.Windows.Forms.ListBox()
        Me.tlpAll.SuspendLayout()
        Me.tlpAbout.SuspendLayout()
        Me.tlpMain.SuspendLayout()
        Me.tlpButtons.SuspendLayout()
        Me.tlpPacks.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpAll
        '
        Me.tlpAll.ColumnCount = 1
        Me.tlpAll.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpAll.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpAll.Controls.Add(Me.tlpAbout, 0, 1)
        Me.tlpAll.Controls.Add(Me.tlpMain, 0, 0)
        Me.tlpAll.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpAll.Location = New System.Drawing.Point(0, 0)
        Me.tlpAll.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpAll.Name = "tlpAll"
        Me.tlpAll.RowCount = 2
        Me.tlpAll.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpAll.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpAll.Size = New System.Drawing.Size(360, 450)
        Me.tlpAll.TabIndex = 0
        '
        'tlpAbout
        '
        Me.tlpAbout.ColumnCount = 3
        Me.tlpAbout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpAbout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpAbout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpAbout.Controls.Add(Me.lbVerControl, 2, 0)
        Me.tlpAbout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpAbout.Location = New System.Drawing.Point(0, 430)
        Me.tlpAbout.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpAbout.Name = "tlpAbout"
        Me.tlpAbout.RowCount = 1
        Me.tlpAbout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpAbout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpAbout.Size = New System.Drawing.Size(360, 20)
        Me.tlpAbout.TabIndex = 0
        '
        'lbVerControl
        '
        Me.lbVerControl.AutoSize = True
        Me.lbVerControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbVerControl.Location = New System.Drawing.Point(243, 0)
        Me.lbVerControl.Name = "lbVerControl"
        Me.lbVerControl.Size = New System.Drawing.Size(114, 20)
        Me.lbVerControl.TabIndex = 0
        Me.lbVerControl.Text = "V 0.0.1"
        Me.lbVerControl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tlpMain
        '
        Me.tlpMain.ColumnCount = 2
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.tlpMain.Controls.Add(Me.tlpButtons, 1, 0)
        Me.tlpMain.Controls.Add(Me.tlpPacks, 0, 0)
        Me.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMain.Location = New System.Drawing.Point(0, 0)
        Me.tlpMain.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpMain.Name = "tlpMain"
        Me.tlpMain.RowCount = 1
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpMain.Size = New System.Drawing.Size(360, 430)
        Me.tlpMain.TabIndex = 1
        '
        'tlpButtons
        '
        Me.tlpButtons.ColumnCount = 1
        Me.tlpButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpButtons.Controls.Add(Me.cmdDelete, 0, 3)
        Me.tlpButtons.Controls.Add(Me.cmdRun, 0, 0)
        Me.tlpButtons.Controls.Add(Me.cmdAdd, 0, 1)
        Me.tlpButtons.Controls.Add(Me.cmdEdit, 0, 2)
        Me.tlpButtons.Controls.Add(Me.cmdParams, 0, 5)
        Me.tlpButtons.Controls.Add(Me.cmdExit, 0, 6)
        Me.tlpButtons.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpButtons.Location = New System.Drawing.Point(260, 0)
        Me.tlpButtons.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpButtons.Name = "tlpButtons"
        Me.tlpButtons.RowCount = 8
        Me.tlpButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.tlpButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.tlpButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.tlpButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.tlpButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.tlpButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.tlpButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.tlpButtons.Size = New System.Drawing.Size(100, 430)
        Me.tlpButtons.TabIndex = 0
        '
        'cmdDelete
        '
        Me.cmdDelete.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdDelete.Location = New System.Drawing.Point(0, 96)
        Me.cmdDelete.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(100, 32)
        Me.cmdDelete.TabIndex = 5
        Me.cmdDelete.Text = "Delete"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'cmdRun
        '
        Me.cmdRun.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdRun.Location = New System.Drawing.Point(0, 0)
        Me.cmdRun.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdRun.Name = "cmdRun"
        Me.cmdRun.Size = New System.Drawing.Size(100, 32)
        Me.cmdRun.TabIndex = 0
        Me.cmdRun.Text = "Run"
        Me.cmdRun.UseVisualStyleBackColor = True
        '
        'cmdAdd
        '
        Me.cmdAdd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdAdd.Location = New System.Drawing.Point(0, 32)
        Me.cmdAdd.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(100, 32)
        Me.cmdAdd.TabIndex = 1
        Me.cmdAdd.Text = "Add"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'cmdEdit
        '
        Me.cmdEdit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdEdit.Location = New System.Drawing.Point(0, 64)
        Me.cmdEdit.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(100, 32)
        Me.cmdEdit.TabIndex = 2
        Me.cmdEdit.Text = "Edit"
        Me.cmdEdit.UseVisualStyleBackColor = True
        '
        'cmdParams
        '
        Me.cmdParams.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdParams.Location = New System.Drawing.Point(0, 358)
        Me.cmdParams.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdParams.Name = "cmdParams"
        Me.cmdParams.Size = New System.Drawing.Size(100, 32)
        Me.cmdParams.TabIndex = 3
        Me.cmdParams.Text = "Parameters"
        Me.cmdParams.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdExit.Location = New System.Drawing.Point(0, 390)
        Me.cmdExit.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(100, 32)
        Me.cmdExit.TabIndex = 4
        Me.cmdExit.Text = "Exit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'tlpPacks
        '
        Me.tlpPacks.ColumnCount = 1
        Me.tlpPacks.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpPacks.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpPacks.Controls.Add(Me.lbPacks, 0, 0)
        Me.tlpPacks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpPacks.Location = New System.Drawing.Point(0, 0)
        Me.tlpPacks.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpPacks.Name = "tlpPacks"
        Me.tlpPacks.RowCount = 1
        Me.tlpPacks.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpPacks.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpPacks.Size = New System.Drawing.Size(260, 430)
        Me.tlpPacks.TabIndex = 1
        '
        'lbPacks
        '
        Me.lbPacks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbPacks.FormattingEnabled = True
        Me.lbPacks.Location = New System.Drawing.Point(0, 0)
        Me.lbPacks.Margin = New System.Windows.Forms.Padding(0)
        Me.lbPacks.Name = "lbPacks"
        Me.lbPacks.Size = New System.Drawing.Size(260, 430)
        Me.lbPacks.TabIndex = 0
        '
        'frmPackFerret
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(360, 450)
        Me.Controls.Add(Me.tlpAll)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPackFerret"
        Me.Text = "Pack Ferret"
        Me.tlpAll.ResumeLayout(False)
        Me.tlpAbout.ResumeLayout(False)
        Me.tlpAbout.PerformLayout()
        Me.tlpMain.ResumeLayout(False)
        Me.tlpButtons.ResumeLayout(False)
        Me.tlpPacks.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpAll As TableLayoutPanel
    Friend WithEvents tlpAbout As TableLayoutPanel
    Friend WithEvents tlpMain As TableLayoutPanel
    Friend WithEvents tlpButtons As TableLayoutPanel
    Friend WithEvents cmdRun As Button
    Friend WithEvents cmdAdd As Button
    Friend WithEvents cmdEdit As Button
    Friend WithEvents cmdParams As Button
    Friend WithEvents cmdExit As Button
    Friend WithEvents lbVerControl As Label
    Friend WithEvents cmdDelete As Button
    Friend WithEvents tlpPacks As TableLayoutPanel
    Friend WithEvents lbPacks As ListBox
End Class
