using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthHearts : MonoBehaviour
{
    public int CountToDestroy;

    void Update()
    {
        try
        {
            if (MainStore.Player.GetComponent<Health>().CurrentHealth < CountToDestroy)
                Destroy(gameObject);
        }
        catch (MissingReferenceException exception)
        {
            Destroy(gameObject);
        }
    }

    void OnDestroy()
    {
        if (CountToDestroy == 1)
        {
            MainStore.GameOverLabel.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
