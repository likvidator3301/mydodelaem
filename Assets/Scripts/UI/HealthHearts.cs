using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthHearts : MonoBehaviour
{
    public int CountToDestroy;

    void Update()
    {
        if (MainStore.Player.GetComponent<Health>().CurrentHealth < CountToDestroy)
            Destroy(gameObject);
    }
}
