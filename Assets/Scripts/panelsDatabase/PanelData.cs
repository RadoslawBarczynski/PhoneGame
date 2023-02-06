using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PanelData", menuName = "ScriptableObjects/PanelData")]
public class PanelData : ScriptableObject
{
    public Sprite image;
    public string text1;
    public string text2;
    public string text3;
}
