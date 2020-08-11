
namespace HamBusCommonStd
{
  public class RigConf : BusConfigBase
  {
    public RigConf() { }
    public string name { get; set; }
    public string commPortName { get; set; }
    public int baudRate { get; set; } = 4800;
    public string parity { get; set; } = "none";
    public int? dataBits { get; set; }
    public string stopBits { get; set; } = "one";
    // TODO do string handshake codes
    //public Handshake handshake { get; set; }
    public int? readTimeout { get; set; }
    public int? writeTimeout { get; set; } = null;
  }
}
