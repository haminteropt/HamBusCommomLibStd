
namespace HamBusCommonStd
{
  public class RigConf : BusConfigBase
  {
    public RigConf() { }
    public string name { get; set; }
    public string commPortName { get; set; }
    public int baudRate { get; set; } = 9600;
    public string parity { get; set; } = "none";
    public int dataBits { get; set; } = 8;
    public string stopBits { get; set; } = "one";
    // TODO do string handshake codes
    public string handshake { get; set; } = "none";
    public int? readTimeout { get; set; }
    public int? writeTimeout { get; set; } = null;
  }
}
