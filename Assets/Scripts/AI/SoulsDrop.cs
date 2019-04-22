using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoulsDrop : MonoBehaviour
{
    public GameObject Soul;
    void OnDestroy()
    {
        var random = new System.Random();
        for (var i = 0; i < random.Next(1, 5); i++)
        {
            var offset = new Vector3(random.Next(-3, 4), random.Next(-3, 4), 0);
            Instantiate(Soul, transform.position + offset, transform.rotation);
        }
        MainStore.Player.GetComponent<LevelTaskContoller>().OnEnemysKilled();
    }
}
