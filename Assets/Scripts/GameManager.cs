using Assets.Scripts.Logic;
using UnityEngine;

namespace Assets.Scripts
{
    public class GameManager : MonoBehaviour
    {
        private LogicManager _logicManager;

        public void Start()
        {
            _logicManager = new LogicManager();

        }

    }

}