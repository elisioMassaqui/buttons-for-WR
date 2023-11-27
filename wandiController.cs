using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class wandiController : MonoBehaviour
{
    public GameObject J2;
    public float velocityJ2 = 0f;
    public Slider sliderVelocityJ2;
    public float limiteSuperiorJ2;
    public float limiteInferiorJ2;
    public float novaRotacao;
    public float grauDaRotacoJ2;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        velocityJ2 = sliderVelocityJ2.value;

        if (Input.GetKey(KeyCode.Alpha1))
        {
            moverJ2Positivo();
        }
    }

    public void moverJ2Positivo()
    {
        novaRotacao = J2.transform.rotation.eulerAngles.z + velocityJ2 * Time.deltaTime;

        novaRotacao = Mathf.Clamp(novaRotacao, limiteInferiorJ2, limiteSuperiorJ2);

        if (novaRotacao >= limiteInferiorJ2 && novaRotacao <= limiteSuperiorJ2)
        {
            J2.transform.rotation = Quaternion.Euler(0, 0, novaRotacao);
        }
    }
}
