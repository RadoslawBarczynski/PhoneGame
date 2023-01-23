using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PasswordLogic : MonoBehaviour
{
    [SerializeField]
    private PasswordPanel passwordPanel;

    public List<GameObject> passwordIndicators;
    public int i;

    public Sprite imageBefore;
    public Sprite imageAfter;
    public void Number(int number)
    {
        passwordPanel.tempPassword += number.ToString();
        SetIndicator();
    }

    public void SetIndicator()
    {
        passwordIndicators[i].GetComponent<Image>().sprite = imageAfter;
        i++;
    }

    public void ResetIndicators()
    {
        i = 0;
        foreach(GameObject indicator in passwordIndicators)
        {
            indicator.GetComponent<Image>().sprite = imageBefore;
        }
    }

}
