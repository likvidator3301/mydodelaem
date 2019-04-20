using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1TaskContoller : MonoBehaviour
{
    private bool wifeIsSaved;
    private bool enemysKilled;
    [SerializeField] private int countOfNeedKillEnemys;
    [SerializeField] private GameObject portal;

    public void SavedWife()
    {
        wifeIsSaved = true;
    }

    public void OnEnemysKilled()
    {
        countOfNeedKillEnemys--;
        if (countOfNeedKillEnemys <= 0)
            enemysKilled = true;
    }

    public void Update()
    {
        if (!wifeIsSaved || !enemysKilled)
            return;
        portal.SetActive(true);
    }
}
