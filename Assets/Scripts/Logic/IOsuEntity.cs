using System;

namespace Assets.Scripts.Logic
{
    public interface IOsuEntity
    {
          public  bool IsActive { get; }

          public  int Index { get; }
          public  float PerfectTime { get; }

 
          public event Action OnTimeOut;
        /// <summary>
        /// Returns value between 1 and -1
        /// 0 is you perfectly match time
        /// 1 is how many seconds letter we press
        /// -1 is how many seconds before we pressed 
        /// </summary>
          public event Action<float> OnHit;

          public void Update();
          public void Click();
    }
}