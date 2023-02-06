using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using UnityEngine;

public class AnsweredCallScript : MonoBehaviour
{
    [SerializeField] private GameObject _dialogueText;
    public void StartAnsweredAnimation()
    {
        LeanTween.moveLocalY(this.gameObject, 550f, 0.4f).setOnComplete(OnComplete);
    }

    private void OnDisable()
    {
        LeanTween.moveLocalY(this.gameObject, 280f, 0f);
    }

    public void OnComplete()
    {
        _dialogueText.SetActive(true);
    }
}
