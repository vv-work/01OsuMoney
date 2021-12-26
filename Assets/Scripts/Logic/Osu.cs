using System;

namespace Assets.Scripts.Logic
{
    public static class Osu
    {

        public static void SetTimeFunc(Func<float> currentTimeFunc)
        {
            GetCurrentTime = currentTimeFunc; 
        }

        private static Func<float> GetCurrentTime;
        /// <summary>
        /// Return current time
        /// </summary>
         public static float GetTime=>GetCurrentTime.Invoke();
    }
}