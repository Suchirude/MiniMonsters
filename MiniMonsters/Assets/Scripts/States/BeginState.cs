using System.Collections;
using UnityEngine;

namespace Com.InfallibleCode.TurnBasedGame
{
    public class BeginState : State
    {
        public BeginState(BattleSystem system) : base(system)
        {
        }

        public override IEnumerator Start()
        {
            _system.HUD.SetDialogText($"A wild {_system.EnemyUnit.Name} approaches...");
            
            yield return new WaitForSeconds(2f);
            
            _system.SetState(new PlayerTurnState(_system));
        }
    }
}