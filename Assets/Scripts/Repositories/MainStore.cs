using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainStore : MonoBehaviour
{
    public static GameObject Player { get; set; }
    public static Camera Camera { get; set; }

    void Start()
    {
        Camera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        Player = GameObject.FindGameObjectWithTag("Player");
    }
}
