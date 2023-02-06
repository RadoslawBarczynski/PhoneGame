using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject _alertBox;
    [SerializeField] private GameObject _backgroundPanel, _incomingCallPanel, _answeredCallPanel, _numberField;
    [SerializeField] public GameObject pasteButton, codeText, copiedAlert, EndingPanel;
    [SerializeField] public bool isCodeInCache = false;
    //Options App Variables
    public bool airplaneMode = true;
    public bool sound = true;
    public bool wifi = false;
    public bool bluetooth = false;

    [SerializeField] public AlertWidnowScript alertWidnowScript;

    private void Start()
    {
        StartCoroutine(callScriptDelay());
    }

    IEnumerator callScriptDelay()
    {
        yield return new WaitForSeconds(10f);
        IncomingCall();
    }

    public void IncomingCall()
    {
        _backgroundPanel.SetActive(true);
        _numberField.SetActive(true);
        _incomingCallPanel.SetActive(true);
    }

    public void DeclineCall()
    {
        _numberField.SetActive(false);
        _incomingCallPanel.GetComponent<OpenAppLeanTween>().CloseApp();
        _answeredCallPanel.SetActive(false);
        _backgroundPanel.GetComponent<OpenAppLeanTween>().CloseApp();
    }

    public void AcceptCall()
    {
        _incomingCallPanel.GetComponent<OpenAppLeanTween>().CloseApp();
        _answeredCallPanel.SetActive(true);
        _numberField.GetComponent<AnsweredCallScript>().StartAnsweredAnimation();
    }


    public void SetOptionVariables(int value)
    {
        if(value == 1)
        {
            airplaneMode = !airplaneMode;
            if(airplaneMode == true)
            {
                wifi = false;
                bluetooth = false;
            }
            return;
        }
        else if(value == 2)
        {
            sound = !sound;
            return;
        }
        else if (value == 3)
        {
            wifi = !wifi;
            return;
        }
        else if (value == 4)
        {
            bluetooth = !bluetooth;
            return;
        }
    }

    public void CopyCode()
    {
        isCodeInCache = true;
        copiedAlert.SetActive(true);
        StartCoroutine(delay());
    }

    IEnumerator delay()
    {
        yield return new WaitForSeconds(1.5f);
        copiedAlert.GetComponent<OpenAppLeanTween>().CloseApp();
    }

    public void ShowPasteButton()
    {
        if(isCodeInCache == true)
        {
            pasteButton.SetActive(true);
        }
    }

    public void ShowInsertedCode()
    {
        codeText.SetActive(true);
        pasteButton.SetActive(false);
    }

    public void TryCode()
    {
        if(codeText.activeSelf == true)
        {
            EndingPanel.SetActive(true);
        }
        else
        {
            _alertBox.SetActive(true);
            alertWidnowScript.SetDataToAlert(2);
        }
    }
}
