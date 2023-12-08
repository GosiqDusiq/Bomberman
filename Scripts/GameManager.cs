using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject[] players;

    public void CheckWinState()
    {
        int aliveCount = 0;

        foreach (GameObject player in players)
        {
<<<<<<< Updated upstream
            if (player.activeSelf) {
=======
            if (player.activeSelf){
>>>>>>> Stashed changes
                aliveCount++;
            }
        }

<<<<<<< Updated upstream
        if (aliveCount <= 1) {
            Invoke(nameof(NewRound), 3f);
        }
=======
        if (aliveCount <=1) {
            Invoke(nameof(NewRound), 3f);
        }  
>>>>>>> Stashed changes
    }

    private void NewRound()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
<<<<<<< Updated upstream

}
=======
}
>>>>>>> Stashed changes
