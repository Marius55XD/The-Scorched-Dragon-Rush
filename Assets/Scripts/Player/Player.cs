using UnityEngine;

public class Player : MonoBehaviour
{
    public VictoryMenu victoryMenu;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("VictoryTrigger"))
        {
            VictoryMenu victoryMenu = FindObjectOfType<VictoryMenu>();
            if (victoryMenu != null)
            {
                victoryMenu.ShowVictoryScreen();
            }
            else
            {
                Debug.LogWarning("VictoryMenu not found");
            }
        }
    }
}
