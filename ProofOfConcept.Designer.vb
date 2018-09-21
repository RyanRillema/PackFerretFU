<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProofOfConcept
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
        Me.tlpMain = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpControls = New System.Windows.Forms.TableLayoutPanel()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.cmdLaunch = New System.Windows.Forms.Button()
        Me.tlpData = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpInfo = New System.Windows.Forms.TableLayoutPanel()
        Me.tbIP = New System.Windows.Forms.TextBox()
        Me.lbIP = New System.Windows.Forms.Label()
        Me.lbLogin = New System.Windows.Forms.Label()
        Me.tbLogin = New System.Windows.Forms.TextBox()
        Me.lbPass = New System.Windows.Forms.Label()
        Me.tbPass = New System.Windows.Forms.TextBox()
        Me.tbService = New System.Windows.Forms.TextBox()
        Me.lbService = New System.Windows.Forms.Label()
        Me.lbOutput = New System.Windows.Forms.ListBox()
        Me.tlpMain.SuspendLayout()
        Me.tlpControls.SuspendLayout()
        Me.tlpData.SuspendLayout()
        Me.tlpInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpMain
        '
        Me.tlpMain.ColumnCount = 1
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMain.Controls.Add(Me.tlpControls, 0, 1)
        Me.tlpMain.Controls.Add(Me.tlpData, 0, 0)
        Me.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMain.Location = New System.Drawing.Point(0, 0)
        Me.tlpMain.Name = "tlpMain"
        Me.tlpMain.RowCount = 2
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpMain.Size = New System.Drawing.Size(466, 371)
        Me.tlpMain.TabIndex = 0
        '
        'tlpControls
        '
        Me.tlpControls.ColumnCount = 6
        Me.tlpControls.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tlpControls.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tlpControls.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tlpControls.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tlpControls.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tlpControls.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tlpControls.Controls.Add(Me.cmdExit, 5, 0)
        Me.tlpControls.Controls.Add(Me.cmdLaunch, 0, 0)
        Me.tlpControls.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpControls.Location = New System.Drawing.Point(0, 341)
        Me.tlpControls.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpControls.Name = "tlpControls"
        Me.tlpControls.RowCount = 1
        Me.tlpControls.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpControls.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpControls.Size = New System.Drawing.Size(466, 30)
        Me.tlpControls.TabIndex = 0
        '
        'cmdExit
        '
        Me.cmdExit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdExit.Location = New System.Drawing.Point(385, 0)
        Me.cmdExit.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(81, 30)
        Me.cmdExit.TabIndex = 0
        Me.cmdExit.Text = "Exit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'cmdLaunch
        '
        Me.cmdLaunch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdLaunch.Location = New System.Drawing.Point(0, 0)
        Me.cmdLaunch.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdLaunch.Name = "cmdLaunch"
        Me.cmdLaunch.Size = New System.Drawing.Size(77, 30)
        Me.cmdLaunch.TabIndex = 1
        Me.cmdLaunch.Text = "Run"
        Me.cmdLaunch.UseVisualStyleBackColor = True
        '
        'tlpData
        '
        Me.tlpData.ColumnCount = 2
        Me.tlpData.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpData.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpData.Controls.Add(Me.tlpInfo, 0, 0)
        Me.tlpData.Controls.Add(Me.lbOutput, 1, 0)
        Me.tlpData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpData.Location = New System.Drawing.Point(0, 0)
        Me.tlpData.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpData.Name = "tlpData"
        Me.tlpData.RowCount = 2
        Me.tlpData.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpData.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpData.Size = New System.Drawing.Size(466, 341)
        Me.tlpData.TabIndex = 1
        '
        'tlpInfo
        '
        Me.tlpInfo.ColumnCount = 2
        Me.tlpInfo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpInfo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpInfo.Controls.Add(Me.tbIP, 1, 0)
        Me.tlpInfo.Controls.Add(Me.lbIP, 0, 0)
        Me.tlpInfo.Controls.Add(Me.lbLogin, 0, 1)
        Me.tlpInfo.Controls.Add(Me.tbLogin, 1, 1)
        Me.tlpInfo.Controls.Add(Me.lbPass, 0, 2)
        Me.tlpInfo.Controls.Add(Me.tbPass, 1, 2)
        Me.tlpInfo.Controls.Add(Me.tbService, 1, 3)
        Me.tlpInfo.Controls.Add(Me.lbService, 0, 3)
        Me.tlpInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpInfo.Location = New System.Drawing.Point(0, 0)
        Me.tlpInfo.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpInfo.Name = "tlpInfo"
        Me.tlpInfo.RowCount = 5
        Me.tlpInfo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.00049!))
        Me.tlpInfo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0005!))
        Me.tlpInfo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0005!))
        Me.tlpInfo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.9985!))
        Me.tlpInfo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpInfo.Size = New System.Drawing.Size(233, 170)
        Me.tlpInfo.TabIndex = 0
        '
        'tbIP
        '
        Me.tbIP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbIP.Location = New System.Drawing.Point(116, 0)
        Me.tbIP.Margin = New System.Windows.Forms.Padding(0)
        Me.tbIP.Name = "tbIP"
        Me.tbIP.Size = New System.Drawing.Size(117, 20)
        Me.tbIP.TabIndex = 0
        Me.tbIP.Text = "gbhsk8-qa-vm0016"
        '
        'lbIP
        '
        Me.lbIP.AutoSize = True
        Me.lbIP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbIP.Location = New System.Drawing.Point(0, 0)
        Me.lbIP.Margin = New System.Windows.Forms.Padding(0)
        Me.lbIP.Name = "lbIP"
        Me.lbIP.Size = New System.Drawing.Size(116, 34)
        Me.lbIP.TabIndex = 1
        Me.lbIP.Text = "IP"
        '
        'lbLogin
        '
        Me.lbLogin.AutoSize = True
        Me.lbLogin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbLogin.Location = New System.Drawing.Point(3, 34)
        Me.lbLogin.Name = "lbLogin"
        Me.lbLogin.Size = New System.Drawing.Size(110, 34)
        Me.lbLogin.TabIndex = 2
        Me.lbLogin.Text = "Log in"
        '
        'tbLogin
        '
        Me.tbLogin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbLogin.Location = New System.Drawing.Point(116, 34)
        Me.tbLogin.Margin = New System.Windows.Forms.Padding(0)
        Me.tbLogin.Name = "tbLogin"
        Me.tbLogin.Size = New System.Drawing.Size(117, 20)
        Me.tbLogin.TabIndex = 3
        Me.tbLogin.Text = "kcc"
        '
        'lbPass
        '
        Me.lbPass.AutoSize = True
        Me.lbPass.Location = New System.Drawing.Point(3, 68)
        Me.lbPass.Name = "lbPass"
        Me.lbPass.Size = New System.Drawing.Size(53, 13)
        Me.lbPass.TabIndex = 4
        Me.lbPass.Text = "Password"
        '
        'tbPass
        '
        Me.tbPass.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbPass.Location = New System.Drawing.Point(116, 68)
        Me.tbPass.Margin = New System.Windows.Forms.Padding(0)
        Me.tbPass.Name = "tbPass"
        Me.tbPass.Size = New System.Drawing.Size(117, 20)
        Me.tbPass.TabIndex = 5
        '
        'tbService
        '
        Me.tbService.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbService.Location = New System.Drawing.Point(119, 105)
        Me.tbService.Name = "tbService"
        Me.tbService.Size = New System.Drawing.Size(111, 20)
        Me.tbService.TabIndex = 6
        Me.tbService.Text = "K8_B_11_BIN"
        '
        'lbService
        '
        Me.lbService.AutoSize = True
        Me.lbService.Location = New System.Drawing.Point(3, 102)
        Me.lbService.Name = "lbService"
        Me.lbService.Size = New System.Drawing.Size(43, 13)
        Me.lbService.TabIndex = 7
        Me.lbService.Text = "Service"
        '
        'lbOutput
        '
        Me.lbOutput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbOutput.FormattingEnabled = True
        Me.lbOutput.Location = New System.Drawing.Point(233, 0)
        Me.lbOutput.Margin = New System.Windows.Forms.Padding(0)
        Me.lbOutput.Name = "lbOutput"
        Me.lbOutput.Size = New System.Drawing.Size(233, 170)
        Me.lbOutput.TabIndex = 1
        '
        'ProofOfConcept
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(466, 371)
        Me.Controls.Add(Me.tlpMain)
        Me.Name = "ProofOfConcept"
        Me.Text = "Form1"
        Me.tlpMain.ResumeLayout(False)
        Me.tlpControls.ResumeLayout(False)
        Me.tlpData.ResumeLayout(False)
        Me.tlpInfo.ResumeLayout(False)
        Me.tlpInfo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpMain As TableLayoutPanel
    Friend WithEvents tlpControls As TableLayoutPanel
    Friend WithEvents cmdExit As Button
    Friend WithEvents cmdLaunch As Button
    Friend WithEvents tlpData As TableLayoutPanel
    Friend WithEvents tlpInfo As TableLayoutPanel
    Friend WithEvents tbIP As TextBox
    Friend WithEvents lbIP As Label
    Friend WithEvents lbLogin As Label
    Friend WithEvents tbLogin As TextBox
    Friend WithEvents lbPass As Label
    Friend WithEvents tbPass As TextBox
    Friend WithEvents tbService As TextBox
    Friend WithEvents lbService As Label
    Friend WithEvents lbOutput As ListBox
End Class
