using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
{
    public string Color;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (MainStore.Player.GetComponent<LevelTaskContoller>().Keys[Color])
                Destroy(gameObject);
        }
    }
}
