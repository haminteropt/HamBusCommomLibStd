using System;
using HamBusCommonStd.Model;

namespace HamBusCommonStd

{
  public class RigState : HamBusBase
  {


    private bool dirty_;

    public bool Dirty
    {
      get { return dirty_; }
      set
      {
        dirty_ = value;
      }
    }

    private string Name_;

    public string Name
    {
      get { return Name_; }
      set
      {
        if (!string.Equals(Name_, value))
        {
          Name_ = value;
          Dirty = true;
        }
      }
    }

    private long Freq_;

    public long Freq
    {
      get { return Freq_; }
      set
      {
        if (Freq_ != value)
        {
          Freq_ = value;
          Dirty = true;
        }
      }
    }

    private long _freqA;

    public long FreqA
    {
      get { return _freqA; }
      set
      {
        if (_freqA != value)
        {
          _freqA = value;
          Dirty = true;
        }
      }
    }
    private long _freqB;

    public long FreqB
    {
      get { return _freqB; }
      set
      {
        if (value != _freqB)
        {
          _freqB = value;
          Dirty = true;
        }
      }
    }

    private string mode_;

    public string Mode
    {
      get { return mode_; }
      set
      {
        if (!String.Equals(Mode, value))
        {
          Dirty = true;
          mode_ = value;
        }
      }
    }

    private int pitch_;

    public int Pitch
    {
      get { return pitch_; }
      set
      {
        if (value != pitch_)
        {
          Dirty = true;
          pitch_ = value;
        }
      }
    }

    private string rigType_;

    public string RigType
    {
      get { return rigType_; }
      set
      {
        if (!string.Equals(value, rigType_))
        {
          Dirty = true;
          rigType_ = value;
        }
      }
    }

    private bool rit_;

    public bool Rit
    {
      get { return rit_; }
      set
      {
        if (!string.Equals(rit_, value))
        {
          Dirty = true;
          rit_ = value;
        }
      }
    }
    private int ritOffset_;

    public int RitOffset
    {
      get { return ritOffset_; }
      set
      {
        if (ritOffset_ != value)
        {
          Dirty = true;
          ritOffset_ = value;
        }
      }
    }

    private string status_;

    public string Status
    {
      get { return status_; }
      set
      {
        if (!string.Equals(value, status_))
        {
          Dirty = true;
          status_ = value;
        }
      }
    }

    private string statusStr_;

    public string StatusStr
    {
      get { return statusStr_; }
      set
      {
        if (!string.Equals(value, statusStr_))
        {
          Dirty = true;
          statusStr_ = value;
        }
      }
    }

    private string split_;

    public string Split
    {
      get { return split_; }
      set
      {
        if (!string.Equals(split_, value))
        {
          Dirty = true;
          split_ = value;
        }
      }
    }

    private bool tx_;

    public bool Tx
    {
      get { return tx_; }
      set
      {
        if (value != tx_)
        {
          Dirty = true;
          tx_ = value;
        }
      }
    }

    private string vfo_;

    public string Vfo
    {
      get { return vfo_; }
      set
      {
        if (!string.Equals(value, vfo_))
        {
          Dirty = true;
          vfo_ = value;
        }
      }
    }
    private bool xit_;

    public bool Xit
    {
      get { return xit_; }
      set
      {
        if (!string.Equals(value, xit_))
        {
          Dirty = true;
          xit_ = value;
        }
      }
    }

    public bool IsDirty()
    {
      return Dirty;
    }
    public void ClearDirty()
    {
      Dirty = false;
    }


    //public Object Clone()
    //{
    //  //return (RigState)MemberwiseClone();
    //}
  }
}
