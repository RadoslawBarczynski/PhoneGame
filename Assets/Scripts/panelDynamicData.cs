using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class panelDynamicData : MonoBehaviour
{
    [SerializeField]
    private List<PanelData> _dataToChoose;
    [SerializeField]
    public PanelData panelData;
    

    public void selectPanel(int value)
    {
        if(value == 0)
        {
            panelData = _dataToChoose[0];
        }
        else if(value == 1)
        {
            panelData = _dataToChoose[1];
        }
        else if (value == 2)
        {
            panelData = _dataToChoose[2];
        }
        else if (value == 3)
        {
            panelData = _dataToChoose[3];
        }
        else if (value == 4)
        {
            panelData = _dataToChoose[4];
        }
    }
}
