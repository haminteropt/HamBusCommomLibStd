

namespace HamBusCommonStd
{
  public enum BusType { Unknown = 0, BusMaster, RigBus, VirtualRigBus, LogBus, RotoBus, ClusterBus, UI }
  public class BusMasterGroups
  {
    public readonly string UI = "ui";
    public readonly string Radio = "radio";
    public readonly string Logging = "logging";
    public readonly string DxCluster = "dxcluster";
    public readonly string Rotor = "rotor";
  }
  public class RigType 
  {

    public readonly string Kenwood = "kenwood";
    public readonly string Yaesu = "yaesu";
    public readonly string Icom = "icom";
  }
  public static  class StopBitTypes
  {
    public static readonly string StopBits1 = "1";
    public static readonly string StopBits15 = "1.5";
    public static readonly string StopBits2 = "2";
    public static readonly string None = "none";
  }
}