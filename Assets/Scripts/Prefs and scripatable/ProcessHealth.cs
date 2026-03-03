using UnityEngine;

public class ProcessHealth : MonoBehaviour
{
    public HealthMananger healthManager;

    void OnEnable()
    {
        healthManager.OnDeath += HandleDeath;
    }

    void OnDisable()
    {
        healthManager.OnDeath -= HandleDeath;
    }

    void HandleDeath()
    {
        Debug.Log("You died!");
    }
}