using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float CurrentHealth = 100f;

    public float MaxHealth = 100f;

    public void Change(float delta)
    {
        CurrentHealth = Mathf.Clamp(CurrentHealth + delta, 0, MaxHealth);
    }
}
