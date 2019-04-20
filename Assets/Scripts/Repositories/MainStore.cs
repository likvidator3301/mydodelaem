using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainStore : MonoBehaviour
{
    public static GameObject Player { get; set; }
    public static Camera Camera { get; set; }
    public static DialogueManager Dialogue { get; set; }
    public static GameObject[] CheckPointsForAI { get; set; }
    public static GameObject GameOverLabel;

    public GameObject[] CheckPoints;
    public GameObject GameOver;
    void Awake()
    {
        Camera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        Player = GameObject.FindGameObjectWithTag("Player");
        Dialogue = GetComponent<DialogueManager>();
        CheckPointsForAI = CheckPoints;
        GameOverLabel = GameOver;
    }
}
