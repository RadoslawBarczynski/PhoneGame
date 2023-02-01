using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomButtonsLogic : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> _apps;

    [SerializeField]
    private List<GameObject> _panelsToReturn;
    private OpenAppLeanTween _openedAppObject;

    private void Update()
    {
        foreach (GameObject app in _apps)
        {
            if(app.activeSelf  == true)
            {
                _openedAppObject = app.GetComponent<OpenAppLeanTween>();
            }
        }
    }


    public void ReturnButton()
    {
        _openedAppObject.CloseApp();
    }

    public void GoBackButton()
    {
        foreach(GameObject panel in _panelsToReturn)
        {
            panel.SetActive(false);
        }
    }
  
}
