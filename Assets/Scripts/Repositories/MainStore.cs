using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainStore : MonoBehaviour
{
    public static GameObject Player { get; set; }
    public static Camera Camera { get; set; }
    public static DialogueManager Dialogue { get; set; }
    public static GameObject[] CheckPointsForAI { get; set; }
    public static GameObject GameOverLabel;
    public static MainStore Store;

    public GameObject[] CheckPoints;
    public GameObject GameOverlbl;
    void Awake()
    {
        Store = this;
        Camera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        Player = GameObject.FindGameObjectWithTag("Player");
        Dialogue = GetComponent<DialogueManager>();
        CheckPointsForAI = CheckPoints;
        GameOverLabel = GameOverlbl;
    }

    public void Stop()
    {
        StartCoroutine(GameOver());
    }

    private IEnumerator GameOver()
    {
        //Time.timeScale = 0;
        GameOverlbl.SetActive(true);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
