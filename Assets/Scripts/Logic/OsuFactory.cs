using System;

namespace Assets.Scripts.Logic
{
    public class OsuFactory
    {
         public  AbstractOsuSequence CreateSequence()
          {
              throw new NotImplementedException();
          }

         /// <summary>
         ///  some
         /// </summary>
         /// <param name="perfectTime"> is Time.time when you get most result example 23.35</param>
         /// <param name="index"></param>
         /// <param name="preTimeout">Timeout before perfect time when the entity becomes active</param>
         /// <param name="postTimeout"></param>
         /// <returns></returns>
         public IOsuEntity CreateEntity(int index, float perfectTime, float preTimeout = 1.0f, float postTimeout = 1.0f)
        {
            var result = new OsuEntity(index, perfectTime, preTimeout, postTimeout);
            return result;
        }
    }
}