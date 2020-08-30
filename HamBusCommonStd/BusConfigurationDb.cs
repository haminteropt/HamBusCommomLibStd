using System;
using System.Collections.Generic;
using System.Text;
using HamBusCommonStd;
using HamBusCommonStd.Model;

namespace HamBusCommonStd
{
  public class BusConfigurationDB : HamBusBase
  {
    public long? Id { get; set; } = null;
    public string Name { get; set; } = "";
    public long Version { get; set; }
    public BusType BusType { get; set; } = BusType.RigBus;

    public string Configuration { get; set; } = "{}";

  }
}
