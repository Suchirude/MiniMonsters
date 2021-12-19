using UnityEngine;
using UnityEngine.UI;

namespace Com.InfallibleCode.TurnBasedGame
{
    public class HUD : MonoBehaviour
    {
        [SerializeField] private UnitHUD playerHUD;
        [SerializeField] private UnitHUD enemyHUD;
        [SerializeField] private Text dialogText;
        [SerializeField] private GameObject PauseScreen;

        public void Initialize(Unit playerUnit, Unit enemyUnit)
        {
            playerHUD.Initialize(playerUnit);
            enemyHUD.Initialize(enemyUnit);
        }

        public void SetDialogText(string text)
        {
            dialogText.text = text;
        }

        public void ShowPauseMenu()
        {
            PauseScreen.SetActive(true);
        }
        
        public void HidePauseMenu()
        {
            PauseScreen.SetActive(false);
        }
    }
}
