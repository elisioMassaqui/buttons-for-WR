using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class robotHandController : MonoBehaviour
{
    public float baseRate = 1;
    public float armRate = 1;

    public Slider sliderBase;
    public Slider sliderArm;

    public float baseYMin = -45.0f;
    public float baseYMax = 45.0f;

    public float armXMin = -45.0F;
    public float armXMax = 45.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
