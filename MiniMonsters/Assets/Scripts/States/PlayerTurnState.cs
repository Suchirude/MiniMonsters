using System.Collections;
using UnityEditor;
using UnityEngine;

namespace Com.InfallibleCode.TurnBasedGame
{
    public class PlayerTurnState : State
    {
        public PlayerTurnState(BattleSystem system) : base(system)
        {
        }

        public override IEnumerator Start()
        {
            BattleSystem.HasAttacked = false;
            _system.HUD.SetDialogText("Choose an action.");
            yield break;
        }

        public override IEnumerator Attack()
        {


            BattleSystem.HasAttacked = true;
            var isDead = _system.EnemyUnit.TakeDamage(_system.PlayerUnit.Damage);
           

            yield return new WaitForSeconds(1f);

            if (isDead)
            {
                _system.SetState(new WonState(_system));
            }
            else
            {
                _system.SetState(new EnemyTurnState(_system));
            }
        }

        public override IEnumerator Heal()
        {

            _system.HUD.SetDialogText($"{_system.PlayerUnit.Name} feels renewed strength!");
            
            _system.PlayerUnit.Heal(5);
        
            yield return new WaitForSeconds(1f);
        
            _system.SetState(new EnemyTurnState(_system));
        }

        public override IEnumerator Pause()
        {
            _system.SetState(new PauseState(_system, this));
            yield break;
        }
    }
}