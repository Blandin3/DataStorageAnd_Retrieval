using System;
using UnityEngine;

public class HealthMananger : MonoBehaviour
{
    public float health = 13f;

    public event Action OnDeath;

    void Update()
    {
        TakeDamage();
    }

    void TakeDamage()
    {
        health -= Time.deltaTime;

        if (health <= 0)
        {
            OnDeath?.Invoke();
            enabled = false;
        }
    }
}