using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public GameObject Dialogue;
    public Text DialogueText;

    public void ShowDialogue()
    {
        Dialogue.SetActive(true);
    }

    public void HideDialogue()
    {
        Dialogue.SetActive(false);
    }

    public void SetTextDialogue(string newText)
    {
        DialogueText.text = newText;
    }
}
