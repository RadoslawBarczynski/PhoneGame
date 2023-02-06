using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TypeRunScript : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textField;
    [SerializeField] private TypingScript gameManager;
    void Start()
    {
        gameManager.RunTyping("Lorem ipsum dolor sit amet, consectetur adipiscing elit... oh sorry", textField);
    }

    public void selectDialogue()
    {
        if(gameManager.i == 1)
        {
            textField.text = "";
            gameManager.RunTyping("This is just a prototype of the gameplay. The main idea of the game is to find a code to type in the browser, which is somewhere on this device. ", textField);
        }
        else if(gameManager.i == 2)
        {
            textField.text = "";
            gameManager.RunTyping("At the beginning you have to crack the password to the phone. Good luck!", textField);
        }
        else if (gameManager.i == 3)
        {
            textField.text = "";
            gameManager.RunTyping("Oh you keep waiting, well a good hint might be that the owner of the phone had a birthday two days ago. ", textField);
        }
    }

    IEnumerator delay()
    {
        yield return new WaitForSeconds(10f);
    }


}
