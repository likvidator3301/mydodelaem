using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueContoller : MonoBehaviour
{
    private bool dialogueIsShowed;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (!dialogueIsShowed)
            {
                MainStore.Dialogue.ShowDialogue();
            }
            else
            {
                MainStore.Dialogue.HideDialogue();
            }

            dialogueIsShowed = !dialogueIsShowed;
        }
    }
}
