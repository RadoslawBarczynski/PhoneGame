using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AlertWidnowScript : MonoBehaviour
{
    [SerializeField] List<Alert> AllAlertsDatabase;

    public TextMeshProUGUI alertDecs;


    public void SetDataToAlert(int value)
    {
        alertDecs.text = AllAlertsDatabase[value].alertDescription;
    }
}
