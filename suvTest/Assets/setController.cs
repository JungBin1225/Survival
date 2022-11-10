using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class setController : MonoBehaviour
{
    public Slider slider;
    private float value;
    PlayerController player;

    private void OnEnable()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        slider.value = value;
    }

    public void SetLevel(float sliderValue)
    {
        player.rotSpeed = 60f * slider.value;
        value = slider.value;

    }

}
