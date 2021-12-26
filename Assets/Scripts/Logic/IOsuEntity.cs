using System;

namespace Assets.Scripts.Logic
{
    public interface IOsuEntity
    {
          public  int Index { get; }
          public  float TimeStamp { get; }
          public  float TimeRange { get; }
 
          public event Action OnTimeOut;
          /// Return us  value beteen -1 to 1 
          /// representing perefect time 
          /// -1 means to early 
          public event Action<float> OnClick;

          public void Update(float Time);
          public void Click(float Time);
    }
}