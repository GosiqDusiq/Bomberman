using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class BasicPlayerHealth : MonoBehaviour, IPlayerHealth
{
    private int health;
    [Header("Health")]
    public int HealthAmount = 1;

    public void SetHealth(int health)
    {
        this.health = health;
    }

    public int GetHealth()
    {
        return health;
    }
}
public interface IPlayerHealth
{
    void SetHealth(int health);
    int GetHealth();
}