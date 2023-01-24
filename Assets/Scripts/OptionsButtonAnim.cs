using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsButtonAnim : MonoBehaviour
{
    [SerializeField] private Image button;
    [SerializeField] private List<Sprite> buttonSprites;

    public void ChangeButtonSprite()
    {
        if(button.sprite == buttonSprites[0])
        {
            button.sprite = buttonSprites[1];
            return;
        }
        button.sprite = buttonSprites[0];
    }
}
