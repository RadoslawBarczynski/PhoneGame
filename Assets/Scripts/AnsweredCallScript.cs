using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnsweredCallScript : MonoBehaviour
{
    public void StartAnsweredAnimation()
    {
        LeanTween.moveLocalY(this.gameObject, 550f, 0.4f);
    }

    private void OnDisable()
    {
        LeanTween.moveLocalY(this.gameObject, 280f, 0f);
    }
}
