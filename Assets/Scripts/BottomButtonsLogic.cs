using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomButtonsLogic : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> Apps;

    [SerializeField]
    private List<GameObject> PanelsToReturn;
    private OpenAppLeanTween openedAppObject;

    private void Update()
    {
        foreach (GameObject app in Apps)
        {
            if(app.activeSelf  == true)
            {
                openedAppObject = app.GetComponent<OpenAppLeanTween>();
            }
        }
    }


    public void ReturnButton()
    {
        openedAppObject.CloseApp();
    }

    public void GoBackButton()
    {
        foreach(GameObject panel in PanelsToReturn)
        {
            panel.SetActive(false);
        }
    }
  
}
