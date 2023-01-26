using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAssingement : MonoBehaviour
{
    [SerializeField]
    private GameObject AlertBox;
    public GameObject AppPanel;
    private GameManager gameManager;

    private void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    public void SetOnPanel()
    {
        if(gameManager.wifi == true)
        {
            AppPanel.SetActive(true);
        }
        else
        {
            AlertBox.GetComponent<AlertWidnowScript>().SetDataToAlert(1);
            AlertBox.SetActive(true);
        }
    }
}
