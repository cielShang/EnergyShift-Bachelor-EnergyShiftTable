using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DayLightController : MonoBehaviour
{
    public Slider slider;
    public GameObject directionalLight;

    private void Start()
    {
        slider = GetComponent<Slider>();
    }

    public void LightPositionController()
    {
        Animator DayNightCycle = directionalLight.GetComponent<Animator>();

        DayNightCycle.SetFloat("PositionValue", slider.value);
    }
}
