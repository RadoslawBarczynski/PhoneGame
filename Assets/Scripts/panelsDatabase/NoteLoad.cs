using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NoteLoad : MonoBehaviour
{
    [SerializeField]
    private panelDynamicData _panelDynamicData;
    [SerializeField]
    private TextMeshProUGUI _textObject;

    private void OnEnable()
    {
        _textObject.text = _panelDynamicData.panelData.text1;
    }

    private void OnDisable()
    {
        _textObject.text = "";
    }
}
