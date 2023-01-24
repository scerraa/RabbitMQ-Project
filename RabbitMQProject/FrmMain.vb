Imports System.IO
Imports Newtonsoft.Json
Imports System.Text
Imports RabbitMQ.Client

Partial Public Class FrmMain

    Private Shared connection As IConnection
    Private isConnectionOpen As Boolean
    Private _channel As IModel

    <Obsolete>
    Private ReadOnly Property channel As IModel
        Get
            Return If(_channel, (Assign(_channel, CreateOrGetChannel())))
        End Get
    End Property

    <Obsolete("Please refactor calling code to use normal Visual Basic assignment")>
    Shared Function Assign(Of T)(ByRef target As T, value As T) As T
        target = value
        Return value
    End Function


    'Public Sub New()
    '    Init()
    'End Sub
    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        If Not isConnectionOpen Or connection Is Nothing Then
            connection = GetConnection()
            isConnectionOpen = Not isConnectionOpen
        Else
            connection.Close()
        End If
        isConnectionOpen = connection.IsOpen
        ConnectionStringChanged()
    End Sub
    Private Function GetConnection() As IConnection
        Dim factory As ConnectionFactory = New ConnectionFactory()
        factory.HostName = "localhost"
        Return factory.CreateConnection()
    End Function

    Public Function CreateOrGetChannel() As IModel
        Return connection.CreateModel()
    End Function

    Private Sub WriteDataToExchange(ByVal exchangeName As String, routingKey As String, data As Object)
        Dim dataArr = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(data))
        channel.BasicPublish(exchangeName, routingKey, Nothing, dataArr)
    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlQueSpecs.Enabled = isConnectionOpen
        pnlExchange.Enabled = isConnectionOpen
    End Sub

    Private Sub btnDeclareExchange_Click(sender As Object, e As EventArgs) Handles btnDeclareExchange.Click
        channel.ExchangeDeclare(txtExchangeName.Text, comboType.Text)
        AddLog($"Exchange created with Name: {txtExchangeName.Text}, Type: {comboType.Text}")

    End Sub

    Private Sub btnQueueDeclare_Click(sender As Object, e As EventArgs) Handles btnQueueDeclare.Click
        channel.QueueDeclare(txtQueueName.Text,, False, False)

        AddLog($"Queue created with Name: {txtQueueName.Text}")
    End Sub

    Private Sub btnBindQueue_Click(sender As Object, e As EventArgs) Handles btnBindQueue.Click
        channel.QueueBind(txtQueueName.Text, txtExchangeName.Text, txtRoutingKey.Text)
        AddLog($"{txtQueueName.Text} is binded to {txtExchangeName.Text} with routing key named {txtRoutingKey.Text}")
    End Sub

    Private Sub btnPublish_Click(sender As Object, e As EventArgs) Handles btnPublish.Click

        Dim message = txtMsg.Text
        If chkUseCounter.Checked Then
            For i As Integer = 1 To NumericUpDown1.Value
                message = $"[{i}] - {txtMsg.Text}"
                WriteDataToExchange(txtExchangeName2.Text, txtRoutingKey2.Text, message)
            Next
            AddLog($"Message published to {txtExchangeName2.Text} with routing key named {txtRoutingKey2.Text} {NumericUpDown1.Value} times")
        Else
            WriteDataToExchange(txtExchangeName2.Text, txtRoutingKey2.Text, message)
            AddLog($"Message published to {txtExchangeName2.Text} with routing key named {txtRoutingKey2.Text}")

        End If


    End Sub

    Private Sub AddLog(ByVal log As String)
        log = $"[{DateTime.Now:dd.M.yyyy HH:mm:ss}] - {log}"
        txtLog.AppendText($"{log}" & vbCrLf)

        txtLog.SelectionStart = txtLog.Text.Length
        txtLog.ScrollToCaret()
    End Sub

    Private Sub Init()
        'comboType.SelectedIndex = 0

    End Sub

    Private Sub UpdateConnectionStatus()
        Dim state As String
        If isConnectionOpen Then
            state = "Connected"
        Else
            state = "Not Connected"
        End If
        lblConnectionState.Text = state
        AddLog($"Connection state is {state}")
    End Sub

    Private Sub ConnectionStringChanged()
        If isConnectionOpen Then
            btnConnect.Text = "Disconnect"
        Else
            btnConnect.Text = "Connect"
        End If
        UpdateConnectionStatus()

        pnlQueSpecs.Enabled = isConnectionOpen
        pnlExchange.Enabled = isConnectionOpen

    End Sub

    Private Sub pnlExchange_Paint(sender As Object, e As PaintEventArgs) Handles pnlExchange.Paint

    End Sub
End Class
