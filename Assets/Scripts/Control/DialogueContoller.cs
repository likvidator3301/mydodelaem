using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class DialogueContoller : MonoBehaviour
{
    
    private bool dialogueIsShowed;

    void Start()
    {
        
    }

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
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            MainStore.Dialogue.ShowNext();
        }
    }
}
