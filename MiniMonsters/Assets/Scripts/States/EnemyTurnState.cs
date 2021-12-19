using System.Collections;
using UnityEngine;

namespace Com.InfallibleCode.TurnBasedGame
{
    public class EnemyTurnState : State
    {
        public EnemyTurnState(BattleSystem system) : base(system)
        {
        }

        public override IEnumerator Start()
        {
            _system.HUD.SetDialogText($"{_system.EnemyUnit.Name} attacks!");
        
            var isDead = _system.PlayerUnit.TakeDamage(_system.EnemyUnit.Damage);

            yield return new WaitForSeconds(1f);
            

            if (isDead)
            {
                _system.SetState(new LostState(_system));
            }
            else
            {
                _system.SetState(new PlayerTurnState(_system));
            }
        }

        public override IEnumerator Pause()
        {
            _system.SetState(new PauseState(_system, this));
            yield break;
        }
    }
}