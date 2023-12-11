using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPlayerHealth
{
    void SetHealth(int health);
    int GetHealth();
}

public class BasicPlayerHealth : MonoBehaviour, IPlayerHealth
{
    private int health;

    public void SetHealth(int health)
    {
        this.health = health;
    }

    public int GetHealth()
    {
        return health;
    }
}
