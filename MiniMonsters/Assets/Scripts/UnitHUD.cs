using UnityEngine;
using UnityEngine.UI;

namespace Com.InfallibleCode.TurnBasedGame
{
    public class UnitHUD : MonoBehaviour
    {
        [SerializeField] private Text unitName;
        [SerializeField] private Text level;
        [SerializeField] private Image fillImage;


        private int _maxHealth;
        private Unit _unit;

        public void Initialize(Unit unit)
        {
            _unit = unit;
            
            unitName.text = _unit.Name;
            level.text = _unit.Level.ToString();
        }

        public void Update()
        {
            SetHealth();
        }
        
        public void SetHealth()
        {
            if (_unit.Health == 0)
            {
                fillImage.fillAmount = 0;
            }
            else
            {
                fillImage.fillAmount = (float) _unit.Health / _unit.MaxHealth;
            }
        }
    }
}