using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] players;
    public GameObject[] stages;

    private void Start()
    {
        // Start the initial round
        NewRound();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)) // This is for testing
        {
            NewRound();
        }
    }

    public void CheckWinState()
    {
        int aliveCount = 0;

        foreach (GameObject player in players)
        {
            if (player.activeSelf)
            {
                aliveCount++;
            }
        }

        if (aliveCount <= 1)
        {
          Invoke(nameof(NewRound), 3f);
        }
    }

    private void NewRound()
    {
        // Turn off the previously active stage (if one was active)
        DeactivateStage();

        // Randomly choose a new stage
        RandomizeStage();
    }

    private void RandomizeStage()
    {
        int randomIndex = Random.Range(0, stages.Length);

        // Activate new stage based on the random index
        stages[randomIndex].SetActive(true);
    }

    private void DeactivateStage()
    {
        foreach (GameObject stage in stages)
        {
            if (stage.activeSelf)
            {
                stage.SetActive(false);
                break;
            }
        }
    }
}
