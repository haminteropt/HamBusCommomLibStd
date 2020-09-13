using System;
using System.Collections.Generic;
using System.Text;

namespace HamBusCommonStd
{
  public static class KenwoodTypes
  {
    public enum ModeValues
    {
      /// <summary> Defines the LSB
      /// </summary>
      LSB = 1,
      /// <summary> Defines the USB
      /// </summary>
      USB = 2,
      /// <summary> Defines the CW
      /// </summary>
      CW = 3,
      /// <summary> Defines the FM
      /// </summary>
      FM = 4,
      /// <summary> Defines the AM
      /// </summary>
      AM = 5,
      /// <summary> Defines the FSK
      /// </summary>
      FSK = 6,
      /// <summary>// Defines the CWR
      /// </summary>
      CWR = 7,
      /// <summary> Defines the Tune
      /// </summary>
      Tune = 8,
      /// <summary> Defines the FSR
      /// </summary>
      FSKR = 9,
      /// <summary> Defines the ERROR
      /// </summary>
      ERROR = 10
    }
  }
}
