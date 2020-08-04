using System;
using System.Collections.Generic;
using HamBusCommonStd.Model;

namespace HamBusCommonStd
{
  public class UiInfoPacketModel : HamBusBase
  {
    public List<ActiveBusesModel> ActiveBuses { get; set; } = new List<ActiveBusesModel>();
    public List<BusConfigurationDB> BusesInDb { get; set; } = new List<BusConfigurationDB>();
  }
}
