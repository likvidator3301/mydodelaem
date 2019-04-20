using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoulsAcumulator : MonoBehaviour
{
    public float CurrentSouls;
    public float NeedToNewLifeSouls;

    public void AddSouls(float count)
    {
        CurrentSouls += count;
        if (CurrentSouls >= NeedToNewLifeSouls)
        {
            GetComponent<Health>().Change(1);
            CurrentSouls -= NeedToNewLifeSouls;
        }
    }
}
