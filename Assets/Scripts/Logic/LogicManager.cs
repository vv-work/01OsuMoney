using UnityEditor.Build;
using UnityEngine;

namespace Assets.Scripts.Logic
{
    public class LogicManager: ILogicManager 
    {
        public bool IsInit { get; private set; }

        public LogicManager()
        {
            IsInit = true;
        } 

        public void Destroy()
        {
        }
    }

    public interface ILogicManager{
        bool IsInit { get; }
        void Destroy();
    }
}