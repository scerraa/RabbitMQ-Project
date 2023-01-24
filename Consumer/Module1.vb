Imports System.IO
Imports System.Text
Imports Newtonsoft.Json
Imports RabbitMQ.Client
Imports RabbitMQ.Client.Events

Module Module1
    Private connectionString As String = "amqp://guest:guest@localhost:5672"
    Private queueName As String
    Private connection As IConnection
    Private _channel As IModel

    <Obsolete>
    Private ReadOnly Property channel As IModel
        Get
            Return If(_channel, (Assign(_channel, CreateOrGetChannel())))
        End Get
    End Property

    <Obsolete("Please refactor calling code to use normal Visual Basic assignment")>
    Function Assign(Of T)(ByRef target As T, value As T) As T
        target = value
        Return value
    End Function

    <Obsolete>
    Public Sub Main(args As String())
        If args.Length > 0 Then
            queueName = args(0)
        Else
            queueName = "myOtherQueue"
        End If
        connection = GetConnection()

        Dim myEvent As EventingBasicConsumer = New EventingBasicConsumer(channel)

        AddHandler myEvent.Received, Sub(consumer2 As IBasicConsumer, ea As BasicDeliverEventArgs)
                                         Dim bodyStr As String = Encoding.UTF8.GetString(ea.Body.ToArray())
                                         Console.WriteLine($"Recieved Data:{bodyStr}")
                                     End Sub

        'myEvent.Received +=
        '    Function(ch, e)
        '        Dim byteArr = e.Body.ToArray()
        '        Dim byteStr = Encoding.UTF8.GetString(byteArr)



        '    End Function



        channel.BasicConsume(queueName, True, myEvent)
        Console.WriteLine($"{queueName} listening" & vbCrLf)
        Console.ReadLine()





    End Sub

    Private Function GetConnection() As IConnection
        Dim factory As ConnectionFactory = New ConnectionFactory() With {
    .Uri = New Uri(connectionString, UriKind.RelativeOrAbsolute)
}
        Return factory.CreateConnection()
    End Function

    Public Function CreateOrGetChannel() As IModel
        Return connection.CreateModel()
    End Function

End Module
