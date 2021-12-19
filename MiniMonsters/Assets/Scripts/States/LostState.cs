using System.Collections;

namespace Com.InfallibleCode.TurnBasedGame
{
    public class LostState : State
    {
        public LostState(BattleSystem system) : base(system)
        {
        }

        public override IEnumerator Start()
        {
            _system.HUD.SetDialogText("You were defeated.");
            yield break;
        }
    }
}