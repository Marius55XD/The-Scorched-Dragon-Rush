using UnityEngine;

public class VictoryMenu : MonoBehaviour
{
    [Header("Victory")]
    [SerializeField] private GameObject victoryScreen;
    [SerializeField] private AudioClip victorySound;

    public void ShowVictoryScreen()
    {
        if (victoryScreen != null)
        {
            victoryScreen.SetActive(true);
            SoundManager.instance.PlaySound(victorySound);
        }
    }
}
