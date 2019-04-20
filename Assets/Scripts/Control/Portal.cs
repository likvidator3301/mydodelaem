using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{
    public GameObject Soul;
    public string NextLevel;
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            Destroy(collider);
            MainStore.Player.GetComponent<PlayerInputController>().Locked = true;
            foreach (var enemy in GameObject.FindGameObjectsWithTag("Enemy"))
            {
                Destroy(enemy);
            }
            StartCoroutine(StartTeleportation());
        }
    }

    private IEnumerator StartTeleportation()
    {
        var countPerOne = 4;
        var list = new List<GameObject>();
        for (var i = 0; i < 20; i++)
        {
            for (var j = 0; j < countPerOne; j++)
            {
                var random = new System.Random();
                var offset = new Vector3(random.Next(-100, 100) / (float)random.Next(-10, 10), random.Next(-100, 110) / (float)random.Next(-10, 10), 0);
                var soul = Instantiate(Soul, transform.position + offset, transform.rotation);
                soul.transform.Rotate(0, 0, random.Next(-180, 180));
                list.Add(soul);
                MainStore.Camera.orthographicSize += 0.2f * Time.deltaTime;
                yield return new WaitForSeconds(0.02f);
            }
            countPerOne++;
        }

        foreach (var soul in list)
        {
            Destroy(soul);
            MainStore.Camera.orthographicSize += 0.2f * Time.deltaTime;
            yield return new WaitForSeconds(0.01f);
        }

        for (var i = 0; i < 300; i++)
        {
            MainStore.Camera.orthographicSize += 0.2f * Time.deltaTime;
            yield return new WaitForSeconds(0.01f);
        }

        SceneManager.LoadScene(NextLevel);
    }
}
