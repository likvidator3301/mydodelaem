using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public GameObject Dialogue;
    public Text DialogueText;
    public float NeedTime { get; private set; }
    private List<string> sentenceses;
    private int iter;
    private string currentSentence;

    public void ShowDialogue()
    {
        Dialogue.SetActive(true);
    }

    public void HideDialogue()
    {
        Dialogue.SetActive(false);
    }

    public void ShowNext()
    {
        SetTextDialogue(sentenceses[iter++]);
    }

    public void SetTextDialogue(string newText)
    {
        currentSentence = newText;
        NeedTime = 0.05f * newText.Length;
        DialogueText.text = "";
        StartCoroutine(Print());
    }

    public void SetSentenceses(List<string> sentenceses)
    {
        this.sentenceses = sentenceses;
    }

    private IEnumerator Print()
    {
        foreach (var character in currentSentence)
        {
            DialogueText.text += character.ToString();
            yield return new WaitForSeconds(0.05f);
        }

        NeedTime = 0;
    }
}
