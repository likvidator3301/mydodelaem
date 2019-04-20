using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnDestroyPlayer : MonoBehaviour
{
    void OnDestroy()
    {
        StartCoroutine(GameOver());
    }

    public IEnumerator GameOver()
    {
        MainStore.GameOverLabel.SetActive(true);
        Time.timeScale = 0f;
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
