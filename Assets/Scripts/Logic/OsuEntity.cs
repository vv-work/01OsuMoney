using System;

namespace Assets.Scripts.Logic
{
    public class OsuEntity:IOsuEntity
    {
        
          public  float PerfectTime { get; }

          private float _preTimeout;

          public OsuEntity(int index, float perfectTime, float preTimeout, float postTimeout)
          {
              PerfectTime = perfectTime;
              _preTimeout = preTimeout;
              _postTimeout = postTimeout;
              Index = index;
          }

          private float _postTimeout;
          private bool _isClicked = false ;


          public int Index { get; }

          public bool IsActive
          {
              get
              {
                  var perfectTime = GetTimeout();
                  var timeout = perfectTime;
                  if (timeout >= 0 && timeout <= _postTimeout)
                      return true;
                  else if (timeout < 0 && timeout * -1f <= _preTimeout)
                      return true;
                  return false;
              }
          }

          private float GetTimeout()
          {
              var perfectTime = Osu.GetTime - PerfectTime;
              return perfectTime;
          }

          public event Action OnTimeOut;
          public event Action<float> OnHit;

          public void Update()
          {
              if (!_isClicked && !IsActive)
                OnTimeOut?.Invoke();   
          }

          public void Click()
          {
              if (IsActive)
              {
                  if (!_isClicked)
                  {
                      _isClicked = true;
                      OnHit(GetTimeout()); 

                  } 
                  throw new Exception("Trying to click clicked button");

              }

              throw new Exception("Trying to click not active button");

          }
    }
}