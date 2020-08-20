using System;
using System.Collections.Generic;
using System.Text;

namespace HamBusCommonStd
{
  public class BusStatusModel
  {

    public string Name { get; set; }
    public ActiveBusesModel ActiveBus { get; set; }
    public BusConfigurationDB BusDbConfig { get; set; }
    public RigState State { get; set; } = new RigState();
  }
}
