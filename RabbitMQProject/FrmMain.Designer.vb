<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtConnectionString = New System.Windows.Forms.TextBox()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.pnlQueSpecs = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnBindQueue = New System.Windows.Forms.Button()
        Me.txtRoutingKey = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnDeclareExchange = New System.Windows.Forms.Button()
        Me.comboType = New System.Windows.Forms.ComboBox()
        Me.txtExchangeName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pnlDeclareQueue = New System.Windows.Forms.Panel()
        Me.btnQueueDeclare = New System.Windows.Forms.Button()
        Me.txtQueueName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlExchange = New System.Windows.Forms.Panel()
        Me.btnPublish = New System.Windows.Forms.Button()
        Me.chkUseCounter = New System.Windows.Forms.CheckBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtMsg = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtRoutingKey2 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtExchangeName2 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtLog = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblConnectionState = New System.Windows.Forms.Label()
        Me.pnlQueSpecs.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.pnlDeclareQueue.SuspendLayout()
        Me.pnlExchange.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Connection String: "
        '
        'txtConnectionString
        '
        Me.txtConnectionString.Location = New System.Drawing.Point(164, 30)
        Me.txtConnectionString.Multiline = True
        Me.txtConnectionString.Name = "txtConnectionString"
        Me.txtConnectionString.Size = New System.Drawing.Size(389, 37)
        Me.txtConnectionString.TabIndex = 1
        Me.txtConnectionString.Text = "amqp://guest:guest@localhost:5672"
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(569, 30)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(114, 38)
        Me.btnConnect.TabIndex = 2
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'pnlQueSpecs
        '
        Me.pnlQueSpecs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlQueSpecs.Controls.Add(Me.Label7)
        Me.pnlQueSpecs.Controls.Add(Me.Panel1)
        Me.pnlQueSpecs.Controls.Add(Me.Label6)
        Me.pnlQueSpecs.Controls.Add(Me.Label5)
        Me.pnlQueSpecs.Controls.Add(Me.Panel2)
        Me.pnlQueSpecs.Controls.Add(Me.pnlDeclareQueue)
        Me.pnlQueSpecs.Location = New System.Drawing.Point(17, 108)
        Me.pnlQueSpecs.Name = "pnlQueSpecs"
        Me.pnlQueSpecs.Size = New System.Drawing.Size(948, 358)
        Me.pnlQueSpecs.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(264, 195)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(172, 20)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Bind Queue & Exchange"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnBindQueue)
        Me.Panel1.Controls.Add(Me.txtRoutingKey)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Location = New System.Drawing.Point(268, 208)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(417, 147)
        Me.Panel1.TabIndex = 7
        '
        'btnBindQueue
        '
        Me.btnBindQueue.Location = New System.Drawing.Point(69, 90)
        Me.btnBindQueue.Name = "btnBindQueue"
        Me.btnBindQueue.Size = New System.Drawing.Size(321, 43)
        Me.btnBindQueue.TabIndex = 3
        Me.btnBindQueue.Text = "Bind Queue"
        Me.btnBindQueue.UseVisualStyleBackColor = True
        '
        'txtRoutingKey
        '
        Me.txtRoutingKey.Location = New System.Drawing.Point(113, 26)
        Me.txtRoutingKey.Multiline = True
        Me.txtRoutingKey.Name = "txtRoutingKey"
        Me.txtRoutingKey.Size = New System.Drawing.Size(277, 36)
        Me.txtRoutingKey.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 42)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 20)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Routing Key"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(29, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 20)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Declare Queue"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(490, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(139, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Declare Exchange"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnDeclareExchange)
        Me.Panel2.Controls.Add(Me.comboType)
        Me.Panel2.Controls.Add(Me.txtExchangeName)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(494, 29)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(417, 147)
        Me.Panel2.TabIndex = 1
        '
        'btnDeclareExchange
        '
        Me.btnDeclareExchange.Location = New System.Drawing.Point(69, 90)
        Me.btnDeclareExchange.Name = "btnDeclareExchange"
        Me.btnDeclareExchange.Size = New System.Drawing.Size(321, 43)
        Me.btnDeclareExchange.TabIndex = 3
        Me.btnDeclareExchange.Text = "Declare"
        Me.btnDeclareExchange.UseVisualStyleBackColor = True
        '
        'comboType
        '
        Me.comboType.FormattingEnabled = True
        Me.comboType.Items.AddRange(New Object() {"direct", "fanout", "headers", "topic"})
        Me.comboType.Location = New System.Drawing.Point(69, 56)
        Me.comboType.Name = "comboType"
        Me.comboType.Size = New System.Drawing.Size(321, 28)
        Me.comboType.TabIndex = 5
        '
        'txtExchangeName
        '
        Me.txtExchangeName.Location = New System.Drawing.Point(69, 10)
        Me.txtExchangeName.Multiline = True
        Me.txtExchangeName.Name = "txtExchangeName"
        Me.txtExchangeName.Size = New System.Drawing.Size(321, 36)
        Me.txtExchangeName.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Type"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Name"
        '
        'pnlDeclareQueue
        '
        Me.pnlDeclareQueue.AccessibleDescription = ""
        Me.pnlDeclareQueue.AccessibleName = ""
        Me.pnlDeclareQueue.Controls.Add(Me.btnQueueDeclare)
        Me.pnlDeclareQueue.Controls.Add(Me.txtQueueName)
        Me.pnlDeclareQueue.Controls.Add(Me.Label2)
        Me.pnlDeclareQueue.Location = New System.Drawing.Point(33, 29)
        Me.pnlDeclareQueue.Name = "pnlDeclareQueue"
        Me.pnlDeclareQueue.Size = New System.Drawing.Size(417, 147)
        Me.pnlDeclareQueue.TabIndex = 0
        Me.pnlDeclareQueue.Tag = "Declare Queue"
        '
        'btnQueueDeclare
        '
        Me.btnQueueDeclare.Location = New System.Drawing.Point(290, 4)
        Me.btnQueueDeclare.Name = "btnQueueDeclare"
        Me.btnQueueDeclare.Size = New System.Drawing.Size(101, 39)
        Me.btnQueueDeclare.TabIndex = 2
        Me.btnQueueDeclare.Text = "Declare"
        Me.btnQueueDeclare.UseVisualStyleBackColor = True
        '
        'txtQueueName
        '
        Me.txtQueueName.Location = New System.Drawing.Point(113, 49)
        Me.txtQueueName.Multiline = True
        Me.txtQueueName.Name = "txtQueueName"
        Me.txtQueueName.Size = New System.Drawing.Size(277, 36)
        Me.txtQueueName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Queue Name"
        '
        'pnlExchange
        '
        Me.pnlExchange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlExchange.Controls.Add(Me.btnPublish)
        Me.pnlExchange.Controls.Add(Me.chkUseCounter)
        Me.pnlExchange.Controls.Add(Me.NumericUpDown1)
        Me.pnlExchange.Controls.Add(Me.Label12)
        Me.pnlExchange.Controls.Add(Me.txtMsg)
        Me.pnlExchange.Controls.Add(Me.Label11)
        Me.pnlExchange.Controls.Add(Me.txtRoutingKey2)
        Me.pnlExchange.Controls.Add(Me.Label10)
        Me.pnlExchange.Controls.Add(Me.txtExchangeName2)
        Me.pnlExchange.Controls.Add(Me.Label8)
        Me.pnlExchange.Location = New System.Drawing.Point(17, 470)
        Me.pnlExchange.Name = "pnlExchange"
        Me.pnlExchange.Size = New System.Drawing.Size(948, 352)
        Me.pnlExchange.TabIndex = 9
        '
        'btnPublish
        '
        Me.btnPublish.Location = New System.Drawing.Point(609, 281)
        Me.btnPublish.Name = "btnPublish"
        Me.btnPublish.Size = New System.Drawing.Size(155, 59)
        Me.btnPublish.TabIndex = 4
        Me.btnPublish.Text = "Publish"
        Me.btnPublish.UseVisualStyleBackColor = True
        '
        'chkUseCounter
        '
        Me.chkUseCounter.AutoSize = True
        Me.chkUseCounter.Location = New System.Drawing.Point(448, 316)
        Me.chkUseCounter.Name = "chkUseCounter"
        Me.chkUseCounter.Size = New System.Drawing.Size(125, 24)
        Me.chkUseCounter.TabIndex = 13
        Me.chkUseCounter.Text = "Use Counter"
        Me.chkUseCounter.UseVisualStyleBackColor = True
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(254, 315)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(160, 26)
        Me.NumericUpDown1.TabIndex = 12
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(250, 278)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(62, 20)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Repeat"
        '
        'txtMsg
        '
        Me.txtMsg.Location = New System.Drawing.Point(254, 143)
        Me.txtMsg.Multiline = True
        Me.txtMsg.Name = "txtMsg"
        Me.txtMsg.Size = New System.Drawing.Size(510, 132)
        Me.txtMsg.TabIndex = 10
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(250, 120)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(74, 20)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Message"
        '
        'txtRoutingKey2
        '
        Me.txtRoutingKey2.Location = New System.Drawing.Point(420, 57)
        Me.txtRoutingKey2.Multiline = True
        Me.txtRoutingKey2.Name = "txtRoutingKey2"
        Me.txtRoutingKey2.Size = New System.Drawing.Size(344, 36)
        Me.txtRoutingKey2.TabIndex = 8
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(319, 73)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(95, 20)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Routing Key"
        '
        'txtExchangeName2
        '
        Me.txtExchangeName2.Location = New System.Drawing.Point(420, 6)
        Me.txtExchangeName2.Multiline = True
        Me.txtExchangeName2.Name = "txtExchangeName2"
        Me.txtExchangeName2.Size = New System.Drawing.Size(344, 36)
        Me.txtExchangeName2.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(250, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(164, 20)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Exchange Name/Type"
        '
        'txtLog
        '
        Me.txtLog.BackColor = System.Drawing.SystemColors.InfoText
        Me.txtLog.ForeColor = System.Drawing.Color.Lime
        Me.txtLog.Location = New System.Drawing.Point(17, 818)
        Me.txtLog.Multiline = True
        Me.txtLog.Name = "txtLog"
        Me.txtLog.Size = New System.Drawing.Size(948, 261)
        Me.txtLog.TabIndex = 14
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(13, 1082)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(137, 20)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "Connection State:"
        '
        'lblConnectionState
        '
        Me.lblConnectionState.AutoSize = True
        Me.lblConnectionState.Location = New System.Drawing.Point(156, 1082)
        Me.lblConnectionState.Name = "lblConnectionState"
        Me.lblConnectionState.Size = New System.Drawing.Size(0, 20)
        Me.lblConnectionState.TabIndex = 15
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 1126)
        Me.Controls.Add(Me.lblConnectionState)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtLog)
        Me.Controls.Add(Me.pnlExchange)
        Me.Controls.Add(Me.pnlQueSpecs)
        Me.Controls.Add(Me.btnConnect)
        Me.Controls.Add(Me.txtConnectionString)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmMain"
        Me.Text = "Form1"
        Me.pnlQueSpecs.ResumeLayout(False)
        Me.pnlQueSpecs.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.pnlDeclareQueue.ResumeLayout(False)
        Me.pnlDeclareQueue.PerformLayout()
        Me.pnlExchange.ResumeLayout(False)
        Me.pnlExchange.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtConnectionString As TextBox
    Friend WithEvents btnConnect As Button
    Friend WithEvents pnlQueSpecs As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents pnlDeclareQueue As Panel
    Friend WithEvents btnQueueDeclare As Button
    Friend WithEvents txtQueueName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnBindQueue As Button
    Friend WithEvents txtRoutingKey As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnDeclareExchange As Button
    Friend WithEvents comboType As ComboBox
    Friend WithEvents txtExchangeName As TextBox
    Friend WithEvents pnlExchange As Panel
    Friend WithEvents txtExchangeName2 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtRoutingKey2 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btnPublish As Button
    Friend WithEvents chkUseCounter As CheckBox
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label12 As Label
    Friend WithEvents txtMsg As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtLog As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents lblConnectionState As Label
End Class
