using System.Collections;

namespace Com.InfallibleCode.TurnBasedGame
{
    public class WonState : State
    {
        public WonState(BattleSystem system) : base(system)
        {
        }

        public override IEnumerator Start()
        {
            _system.HUD.SetDialogText("You won the battle!");
            yield break;
        }
    }
}