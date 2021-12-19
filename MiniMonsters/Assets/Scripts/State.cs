using System.Collections;

namespace Com.InfallibleCode.TurnBasedGame
{
    public abstract class State
    {
        protected readonly BattleSystem _system;

        public State(BattleSystem system)
        {
            _system = system;
        }
        
        public virtual IEnumerator Start()
        {
            yield break;
        }
        
        public virtual IEnumerator Attack()
        {
            yield break;
        }

        public virtual IEnumerator Heal()
        {
            yield break;
        }

        public virtual IEnumerator Pause()
        {
            yield break;
        }

        public virtual IEnumerator Resume()
        {
            yield break;
        }
    }
}