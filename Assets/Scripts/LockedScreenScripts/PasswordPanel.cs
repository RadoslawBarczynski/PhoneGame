using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PasswordPanel : MonoBehaviour
{
    [SerializeField]
    private PasswordLogic passwordLogic;
    [SerializeField]
    private GameObject callButton;
    [SerializeField]
    private string Password;
    public string tempPassword;
    private bool isLocked = true;


    private void Start()
    {
        tempPassword = "";
    }

    private void Update()
    {
        if(tempPassword.Length == 4 && tempPassword != Password)
        {
            Debug.Log("Incorrect");
            tempPassword = "";
            passwordLogic.ResetIndicators();
        }
    }


    //LeanTweenAnimations for password panel

    public Transform box;
    public GameObject homeScreen;
    public GameObject tempCointainer;
    public GameObject LockedScreen;
    public GameObject clockTxt;
    private void OnEnable()
    {
        box.localPosition = new Vector2(0, -Screen.height*1.5f);
        box.LeanMoveLocalY(-40f, 0.300f).setEaseInExpo();
    }

    public void ClosePasswordPanel()
    {
        box.LeanMoveLocalY(-Screen.height, 0.3f).setEaseInExpo().setOnComplete(OnComplete);
    }

    public void ClosePasswordPanel2()
    {
        if (tempPassword == Password)
        {
            Debug.Log("Correct");
            callButton.SetActive(false);
            tempCointainer.SetActive(false);
            isLocked = false;
            box.LeanMoveLocalY(-Screen.height, 0.3f).setEaseInExpo().setOnComplete(OnComplete2);
        }
        else
        {
            Debug.Log("Incorrect");
            tempPassword = "";
            passwordLogic.ResetIndicators();
        }
    }

    void OnComplete()
    {
        gameObject.SetActive(false);
    }

    void OnComplete2()
    {
        isLocked = false;
        homeScreen.SetActive(true);
        clockTxt.SetActive(true);
        LockedScreen.SetActive(false);
        //gameObject.SetActive(false);
    }
}
