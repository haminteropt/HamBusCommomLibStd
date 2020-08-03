using System;
using System.Collections.Generic;
using System.Text;
using HamBusCommmonStd;
using HamBusCommonStd.Model;

namespace HamBusCommonStd
{
  public class BusConfigurationDB : HamBusBase
  {
    public long? Id { get; set; }
    public string Name { get; set; } = "";
    public long Version { get; set; }
    public BusType BusType { get; set; } = BusType.Unknown;

    public string Configuration { get; set; } = "{}";

  }
}
