using System;

namespace Assets.Scripts.Logic
{
    internal interface IOsuSequence
    {
        IOsuEntity[] OsuEntities { get; }
        event Action<IOsuEntity> OnSpawnEntity;
        event Action<IOsuEntity> OnEntityPass;
        event Action<IOsuEntity> OnEntityFailed;
        event Action OnSequenceEnd;
        void ClickButton(IOsuEntity entity);

        /// Updting all the Entities it's assign to
        void Update(float Time);
    }

    public abstract class AbstractOsuSequence : IOsuSequence
    {
        private float _timeOut = 2.00f;
        private float _sequenceLength = 2.00f;
        private float _spawnRange = 2.00f;
        private float _buttonBitmout = 0.5f;

        public abstract IOsuEntity[] OsuEntities { get; }
        public abstract event Action<IOsuEntity> OnSpawnEntity;
        public abstract event Action<IOsuEntity> OnEntityPass;
        public abstract event Action<IOsuEntity> OnEntityFailed;
        public abstract event Action OnSequenceEnd;
        public abstract void ClickButton(IOsuEntity entity);

        /// Updting all the Entities it's assign to
        public abstract void Update(float Time);
    }
}