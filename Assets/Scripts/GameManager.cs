using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject[] players;
<<<<<<< Updated upstream
=======
    public GameObject[] stages;
    [SerializeField]//to jest tablica przechowująca sceny (levele) w grze. w inspektorze musisz tam przypisać sceny, które chcesz aby się ładowały
    private string[] levels;
>>>>>>> Stashed changes

    public void CheckWinState()
    {
        int aliveCount = 0;

        foreach (GameObject player in players)
        {
            if (player.activeSelf) {
                aliveCount++;
            }
        }

        if (aliveCount <= 1) {
<<<<<<< Updated upstream
            Invoke(nameof(NewRound), 3f);
=======
            Invoke(nameof(RandomizeStage), 3f);
>>>>>>> Stashed changes
        }
    }

    private void NewRound()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

<<<<<<< Updated upstream
}
=======

    private void RandomizeStage()
    {
        int randomIndex = Random.Range(0, levels.Length);

        // Activate new scene based on the random index
        ActivateScene(levels[randomIndex]);
    }

    private void ActivateScene(string sceneName)
    {
        SceneManager.LoadSceneAsync(sceneName);
    }
}
>>>>>>> Stashed changes
