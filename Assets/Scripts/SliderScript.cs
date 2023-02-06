using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour
{
    [SerializeField]
    private Slider slider;
    [SerializeField]
    private Image image;

    void Start()
    {
        slider.value = 0.85f;
    }

    void Update()
    {
        image.color = new Color(image.color.r, image.color.g, image.color.b, slider.value);
    }
}
