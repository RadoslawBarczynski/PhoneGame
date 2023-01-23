using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppOpenScript : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> Apps;

    [SerializeField]
    private List<GameObject> PanelsToReturn;


    public void ReturnButton()
    {
        foreach(GameObject app in Apps)
        {
            app.SetActive(false);
        }
    }

    public void GoBackButton()
    {
        foreach(GameObject panel in PanelsToReturn)
        {
            panel.SetActive(false);
        }
    }



   
}
