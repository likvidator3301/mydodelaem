using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroController : MonoBehaviour
{
    public string[] sentenceses;
    public Animator Animator;
    void Start()
    {
        MainStore.Dialogue.SetSentenceses(sentenceses.ToList());
        StartCoroutine(Contol());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L) && Input.GetKeyDown(KeyCode.P))
            SceneManager.LoadScene("SampleScene");
    }

    private IEnumerator Contol()
    {
        var dialogue = MainStore.Dialogue;
        dialogue.ShowDialogue();
        //звук автомобиля
        dialogue.ShowNext();
        yield return new WaitForSeconds(dialogue.NeedTime + 1);
        Animator.SetBool("ToIntro", true);
        yield return new WaitForSeconds(2);
        dialogue.ShowNext();
        yield return new WaitForSeconds(dialogue.NeedTime + 1);
        dialogue.ShowNext();
        yield return new WaitForSeconds(dialogue.NeedTime + 1);
        Animator.SetBool("ToBar", true);
        yield return new WaitForSeconds(2);
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
        Animator.SetBool("ToBlack", true);
        yield return new WaitForSeconds(2);
        dialogue.ShowNext();
        yield return new WaitForSeconds(dialogue.NeedTime + 1);
        dialogue.ShowNext();
        yield return new WaitForSeconds(dialogue.NeedTime + 1);
        dialogue.ShowNext();
        yield return new WaitForSeconds(dialogue.NeedTime + 1);
        Animator.SetBool("FromBlack", true);
        yield return new WaitForSeconds(2);
        dialogue.ShowNext();
        yield return new WaitForSeconds(dialogue.NeedTime + 1);
        dialogue.ShowNext();
        yield return new WaitForSeconds(dialogue.NeedTime + 1);
        dialogue.ShowNext();
        yield return new WaitForSeconds(dialogue.NeedTime + 1);
        dialogue.ShowNext();
        yield return new WaitForSeconds(dialogue.NeedTime + 1);
        dialogue.ShowNext();
        yield return new WaitForSeconds(dialogue.NeedTime + 2);
        dialogue.ShowNext();
        yield return new WaitForSeconds(dialogue.NeedTime + 1);
        dialogue.ShowNext();
        yield return new WaitForSeconds(dialogue.NeedTime + 1);
        Animator.SetBool("To1", true);
        yield return new WaitForSeconds(2);
        Animator.SetBool("To2", true);
        yield return new WaitForSeconds(2);
        Animator.SetBool("To3", true);
        yield return new WaitForSeconds(2);
        Animator.SetBool("To4", true);
        yield return new WaitForSeconds(2);
        Animator.SetBool("To5", true);
        GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(5);
        
        SceneManager.LoadScene("SampleScene");
    }
}
