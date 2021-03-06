﻿using System.Collections.Generic;
using HamBusCommonStd.Model;

namespace HamBusCommonStd
{
  public class ActiveBusesModel : HamBusBase
  {


    public string Id { get; set; }

    public string ConnectionId { get; set; }
    public string Name { get; set; }
    public List<string> Groups { get; set; } = new List<string>();
    public bool IsActive { get; set; }
    public BusType Type { get; set; }
    public RigState State { get; set; }

  }
}