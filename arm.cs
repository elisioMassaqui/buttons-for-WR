using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class arm : MonoBehaviour
{
    public Transform baseY;
    public Transform armX;

    public float baseRate = 1;
    public float armRate = 1;

    public Slider sliderBase;
    public Slider sliderArm;

    public float baseSliderValue = 0.0f;
    public float armSliderValue = 0.0f;

    public float baseYRot = 0.0f;
    public float baseYMin = -45.0f;
    public float baseYMax = 45.0f;

    public float armXRot = 0.0f;
    public float armXMin = -45.0f;
    public float armXMax = 45.0f;

    // Start is called before the first frame update
    void Start()
    {
        sliderBase.minValue = -1;
        sliderArm.minValue = -1;

        sliderBase.maxValue = 1;
        sliderArm.maxValue = 1;
    }

    // Update is called once per frame
    void Update()
    {
        baseSliderValue = sliderBase.value;
        armSliderValue = sliderArm.value;

        baseYRot += baseSliderValue * baseRate * Time.deltaTime;
        baseYRot = Mathf.Clamp(baseYRot, baseYMin, baseYMax);
        
        baseY.localEulerAngles = new Vector3(baseY.localEulerAngles.x, baseYRot, baseY.localEulerAngles.z);

        armXRot += armSliderValue * armRate * Time.deltaTime;
        armXRot = Mathf.Clamp(armXRot, armXMin, armXMax);

        armX.localEulerAngles = new Vector3(armXRot, armX.localEulerAngles.y, armX.localEulerAngles.z);
    }

    public void resetSliders()
    {
        baseSliderValue = 0.0f;
        armSliderValue = 0.0f;
        sliderBase.value = 0.0f;
        sliderArm.value = 0.0f;
    }
}
