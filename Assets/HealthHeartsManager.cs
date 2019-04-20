using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class HealthHeartsManager : MonoBehaviour
{
    public GameObject Heart;
    public GameObject Canvas;

    private Health playersHealth;
    private int countOfTheHeart;
    private Stack<GameObject> hearts = new Stack<GameObject>();

    void Start()
    {
        playersHealth = MainStore.Player.GetComponent<Health>();
        for (var i = 1; i < playersHealth.CurrentHealth; i++)
        {
            var heart = Instantiate(Heart, Canvas.transform);
            heart.GetComponent<RectTransform>().localPosition = new Vector3(100 * i - 200, 0, -2);
            countOfTheHeart++;
            hearts.Push(heart);
        }
    }

    void Update()
    {
        if (countOfTheHeart < playersHealth.CurrentHealth)
        {
            var heart = Instantiate(Heart, Canvas.transform);
            heart.GetComponent<RectTransform>().localPosition = new Vector3(100 * playersHealth.CurrentHealth - 200, 0, -2);
            countOfTheHeart++;
            hearts.Push(heart);
        }
        else if (countOfTheHeart > playersHealth.CurrentHealth)
        {
            var heart = hearts.Pop();
            Destroy(heart);
            countOfTheHeart--;
        }
    }
}
