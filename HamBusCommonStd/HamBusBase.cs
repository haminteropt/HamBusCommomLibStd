

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

    //public override string ToString()
    //{
    //  var options = new JsonSerializerOptions
    //  {
    //    //PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
    //    WriteIndented = true
    //  };

    //  string output = JsonSerializer.Serialize(this, options);
    //  Console.WriteLine($"ToString output: {output}");
    //  return output;
    //}
    public virtual void IncSerial()
    {
      SerialNum_++;
      SerialNumDym = SerialNum_;
    }
  }
}
