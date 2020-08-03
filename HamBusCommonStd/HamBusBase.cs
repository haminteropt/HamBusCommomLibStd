

namespace HamBusCommonStd.Model
{
  public class HamBusBase
  {
    static public long SerialNum_ { get; set; } = 1;

    public long SerialNum
    {
      get { return SerialNum_; }
    }
    public long SerialNumDym { get; set; }

    public virtual void IncSerial()
    {
      SerialNum_++;
      SerialNumDym = SerialNum_;
    }
  }
}
