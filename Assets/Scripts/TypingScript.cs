using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TypingScript : MonoBehaviour
{
    [SerializeField]private float _typeSpeed = 50f;
    public int i = 0;
    public void RunTyping(string text, TextMeshProUGUI textObject)
    {
        StartCoroutine(TypeText(text, textObject));
    }

    private IEnumerator TypeText(string text, TextMeshProUGUI textObject)
    {
        yield return new WaitForSeconds(2f);

        i++;
        float t = 0;
        int charIndex = 0;

        while(charIndex < text.Length)
        {
            t += Time.deltaTime * _typeSpeed; //increment over time 
            charIndex = Mathf.FloorToInt(t); //round the number
            charIndex = Mathf.Clamp(charIndex, 0, text.Length);

            textObject.text = text.Substring(0, charIndex);

            yield return null;
        }

        textObject.text = text;
    }
}
