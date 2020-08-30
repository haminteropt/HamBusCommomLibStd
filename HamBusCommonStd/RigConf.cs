
using System.ComponentModel.DataAnnotations;

namespace HamBusCommonStd
{
  public class RigConf : BusConfigBase
  {
    public RigConf() { }
    [Required]
    public BusType RigType { set; get; } = BusType.RigBus;
    [Required]
    public string Name { get; set; }
    [Required]
    public string CommPortName { get; set; }
    [Required]
    public int BaudRate { get; set; } = 9600;
    [Required]
    public string Parity { get; set; } = "";
    [Required]
    public int DataBits { get; set; } = 8;
    [Required]
    public string StopBits { get; set; } = "none";
    // TODO do string handshake codes
      [Required]
    public string Handshake { get; set; } = "none";
    public int? ReadTimeout { get; set; }
    public int? WriteTimeout { get; set; } = null;
  }
}
