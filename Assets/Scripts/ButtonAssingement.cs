using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAssingement : MonoBehaviour
{
    [SerializeField]
    private GameObject _alertBox;
    public GameObject appPanel;
    private GameManager _gameManager;

    private void Start()
    {
        _gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    public void SetOnPanel()
    {
        if(_gameManager.wifi == true)
        {
            appPanel.SetActive(true);
        }
        else
        {
            _alertBox.GetComponent<AlertWidnowScript>().SetDataToAlert(1);
            _alertBox.SetActive(true);
        }
    }
}
