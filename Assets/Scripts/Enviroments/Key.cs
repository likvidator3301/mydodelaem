using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public string Color;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            MainStore.Player.GetComponent<LevelTaskContoller>().Keys[Color] = true;
            Destroy(gameObject);
        }
    }
}
