
using IBM.XMS;

try
{
    var factoryFactory = XMSFactoryFactory.GetInstance(XMSC.CT_WMQ);
    var connectionFactory = factoryFactory.CreateConnectionFactory();

    // Set the connection properties
    connectionFactory.SetStringProperty(XMSC.WMQ_HOST_NAME, "192.168.1.15");  // Use IP directly
    connectionFactory.SetIntProperty(XMSC.WMQ_PORT, 1414);  // Use the appropriate port
    connectionFactory.SetStringProperty(XMSC.WMQ_CHANNEL, "LOCAL.CHANNEL");
    connectionFactory.SetIntProperty(XMSC.WMQ_CONNECTION_MODE, XMSC.WMQ_CM_CLIENT);
    connectionFactory.SetStringProperty(XMSC.WMQ_QUEUE_MANAGER, "QM1");
    Console.WriteLine(".........set up MQ parameters");
    IConnection connection = connectionFactory.CreateConnection();
    Console.WriteLine("................Connected successfully!");

    // Additional code...
}
catch (XMSException ex)
{
    Console.WriteLine($"XMSException: {ex.Message}");
    if (ex.LinkedException != null)
    {
        Console.WriteLine($"Linked Exception: {ex.LinkedException.Message}");
    }
}
catch (Exception ex)
{
    Console.WriteLine($"General Exception: {ex.Message}");
}
