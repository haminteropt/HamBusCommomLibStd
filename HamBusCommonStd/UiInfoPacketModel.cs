using System;
using System.Collections.Generic;
using System.Text;
using HamBusCommmonStd;
using HamBusCommonStd.Model;

namespace HamBusCommonStd
{
  public class UiInfoPacketModel : HamBusBase
  {
    public List<ActiveBusesModel> ActiveBuses { get; set; } = new List<ActiveBusesModel>();
    public List<BusConfigurationDB> BusesInDb { get; set; } = new List<BusConfigurationDB>();
  }
}
