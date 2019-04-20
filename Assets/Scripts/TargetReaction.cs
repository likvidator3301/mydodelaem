using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class TargetReaction : MonoBehaviour
{
    public string[] Sentences;

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            MainStore.Dialogue.ShowDialogue();
            collider.gameObject.GetComponent<PlayerInputController>().Locked = true;
            foreach (var enemy in GameObject.FindGameObjectsWithTag("Enemy"))
            {
                enemy.GetComponent<AIMoveController>().Locked = true;
            }

            StartCoroutine(Talk());
        }

    }

    private IEnumerator Talk()
    {
        MainStore.Dialogue.SetSentenceses(Sentences.ToList());
        foreach (var sentence in Sentences)
        {
            MainStore.Dialogue.ShowNext();
            yield return new WaitForSeconds(MainStore.Dialogue.NeedTime + 1);
        }
        MainStore.Player.GetComponent<PlayerInputController>().Locked = false;
        foreach (var enemy in GameObject.FindGameObjectsWithTag("Enemy"))
        {
            enemy.GetComponent<AIMoveController>().Locked = false;
        }

        gameObject.GetComponent<CircleCollider2D>().radius /= 2;
        var follower = gameObject.AddComponent<FollowTarget>();
        follower.Target = MainStore.Player.transform;
        follower.Offset = transform.position - MainStore.Player.transform.position;
        MainStore.Dialogue.HideDialogue();
        MainStore.Player.GetComponent<Level1TaskContoller>().SavedWife();
        Destroy(gameObject);
    }
}
