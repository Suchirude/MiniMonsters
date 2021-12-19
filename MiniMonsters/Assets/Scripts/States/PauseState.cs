using System.Collections;

namespace Com.InfallibleCode.TurnBasedGame
{
    public class PauseState : State
    {
        private readonly State _resumeState;

        public PauseState(BattleSystem system, State resumeState) : base(system)
        {
            _resumeState = resumeState;
        }

        public override IEnumerator Start()
        {
            _system.HUD.ShowPauseMenu();
            yield break;
        }

        public override IEnumerator Resume()
        {
            _system.HUD.HidePauseMenu();
            _system.SetState(_resumeState);
            yield break;
        }
    }
}