using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Level3Controller : MonoBehaviour
{
    public string[] Sentences;

    void Start()
    {
        StartCoroutine(Do());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator Do()
    {
        var dialogue = MainStore.Dialogue;
        dialogue.SetSentenceses(Sentences.ToList());
        dialogue.ShowDialogue();
        dialogue.ShowNext();
        yield return new WaitForSeconds(dialogue.NeedTime + 1);
        dialogue.ShowNext();
        yield return new WaitForSeconds(dialogue.NeedTime + 1);
        dialogue.ShowNext();
        yield return new WaitForSeconds(dialogue.NeedTime + 1);
        dialogue.ShowNext();
        yield return new WaitForSeconds(dialogue.NeedTime + 1);
        dialogue.ShowNext();
        yield return new WaitForSeconds(dialogue.NeedTime + 1);
        dialogue.ShowNext();
        yield return new WaitForSeconds(dialogue.NeedTime + 1);
        dialogue.ShowNext();
        yield return new WaitForSeconds(dialogue.NeedTime + 1);
        dialogue.ShowNext();
        yield return new WaitForSeconds(dialogue.NeedTime + 1);
        dialogue.ShowNext();
        yield return new WaitForSeconds(dialogue.NeedTime + 1);

    }
}
