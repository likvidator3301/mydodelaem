using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelTaskContoller : MonoBehaviour
{
    [SerializeField] private bool targetIsSaved;
    [SerializeField] private bool enemysKilled;

    public Dictionary<string, bool> Keys = new Dictionary<string, bool>()
    {
        { "Red", false},
        { "Blue", false},
        { "Yellow", false},

    };
    [SerializeField] private int countOfNeedKillEnemys;
    [SerializeField] private GameObject portal;

    public void SavedTarget()
    {
        targetIsSaved = true;
    }

    public void OnEnemysKilled()
    {
        countOfNeedKillEnemys--;
        if (countOfNeedKillEnemys <= 0)
            enemysKilled = true;
    }

    public void Update()
    {
        if (!targetIsSaved || !enemysKilled)
            return;
        portal.SetActive(true);
    }
}
