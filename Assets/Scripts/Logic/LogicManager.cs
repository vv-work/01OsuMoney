using UnityEditor.Build;
using UnityEngine;

namespace Assets.Scripts.Logic
{
    public class LogicManager: ILogicManager 
    {
        public bool IsInit { get; }
        public LogicManager()
        {
            throw new System.NotImplementedException();
        } 
        public void Init()
        {
            throw new System.NotImplementedException();
        }
    }

    public interface ILogicManager{
        bool IsInit { get; }
        void Init(); 
    }
}