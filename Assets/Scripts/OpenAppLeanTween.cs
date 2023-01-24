using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks.Sources;
using UnityEngine;

public class OpenAppLeanTween : MonoBehaviour
{
    private void OnEnable()
    {
        LeanTween.scale(this.gameObject, new Vector3(1, 1, 1), 0.2f);
    }

    public void CloseApp()
    {
        LeanTween.scale(this.gameObject, new Vector3(0, 0, 0), 0.2f).setOnComplete(OnComplete);
    }

    void OnComplete()
    {
        this.gameObject.SetActive(false);
    }
}
