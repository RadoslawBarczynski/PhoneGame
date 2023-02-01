using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TopBarIconsAnim : MonoBehaviour
{
    [SerializeField] private Image _range, _wifi;
    [SerializeField] private List<Sprite> _rangeSprites, _wifiSprites, _buttonSprites;
    [SerializeField] private Image _wifiButtonImage, _bluetoothButtonImage;
    private GameManager _gameManager;

    private void Start()
    {
        _gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    private void Update()
    {
        if (_gameManager.airplaneMode == true)
        {
            _wifi.sprite = _wifiSprites[0];
            _wifiButtonImage.sprite = _buttonSprites[0];
            _bluetoothButtonImage.sprite = _buttonSprites[0];
        }
    }

    public void ChangeRangeSprite()
    {
        if (_range.sprite == _rangeSprites[0] && _gameManager.airplaneMode == false)
        {
            _range.sprite = _rangeSprites[1];
            return;
        }
        _range.sprite = _rangeSprites[0];
    }

    public void ChangeWifiSprite()
    {
        if (_wifi.sprite == _wifiSprites[0] && _gameManager.airplaneMode == false && _gameManager.wifi == true)
        {
            _wifi.sprite = _wifiSprites[1];
            return;
        }
        else
        {
            _wifi.sprite = _wifiSprites[0];
        }
    }
}
