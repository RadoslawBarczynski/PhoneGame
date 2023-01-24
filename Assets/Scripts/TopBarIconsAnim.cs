using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TopBarIconsAnim : MonoBehaviour
{
    [SerializeField] private Image range, wifi;
    [SerializeField] private List<Sprite> rangeSprites, wifiSprites, buttonSprites;
    [SerializeField] private Image wifiButtonImage, bluetoothButtonImage;
    private GameManager gameManager;

    private void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    private void Update()
    {
        if (gameManager.airplaneMode == true)
        {
            wifi.sprite = wifiSprites[0];
            wifiButtonImage.sprite = buttonSprites[0];
            bluetoothButtonImage.sprite = buttonSprites[0];
        }
    }

    public void ChangeRangeSprite()
    {
        if (range.sprite == rangeSprites[0] && gameManager.airplaneMode == false)
        {
            range.sprite = rangeSprites[1];
            return;
        }
        range.sprite = rangeSprites[0];
    }

    public void ChangeWifiSprite()
    {
        if (wifi.sprite == wifiSprites[0] && gameManager.airplaneMode == false && gameManager.wifi == true)
        {
            wifi.sprite = wifiSprites[1];
            return;
        }
        else
        {
            wifi.sprite = wifiSprites[0];
        }
    }
}
