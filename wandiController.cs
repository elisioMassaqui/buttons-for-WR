using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using Unity.VisualScripting;

public class wandiController : MonoBehaviour
{

    //Vida Da Nossa JuntaJ1
    public GameObject J1;
    public float velocityJ1;
    public Slider sliderVelocityJ1;
    public float limiteEsquerdoJ1;
    public float limiteDireitoJ1;
    public float grauDaRotacaoJ1;

    //Vida Da Nossa Junta2
    public GameObject J2;
    public float velocityJ2 = 0f;
    public Slider sliderVelocityJ2;
    public float limiteSuperiorJ2;
    public float limiteInferiorJ2;
    public float grauDaRotacoJ2;


    public Button botaoPositivoJ2;

    public bool boolPositivoJ2 = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        velocityJ2 = sliderVelocityJ2.value;

        if (Input.GetKey(KeyCode.Alpha2) && Input.GetKey(KeyCode.RightArrow))
        {
            moverJ2Positivo();
        }
        if (Input.GetKey(KeyCode.Alpha2) && Input.GetKey(KeyCode.LeftArrow))
        {
            moverJ2Negativo();
        }

        if (boolPositivoJ2 == true)
        {

            moverJ2Positivo();

            Debug.Log("btnpress");

        }
    }

    public void moverJ2Positivo()
    {
        grauDaRotacoJ2 = J2.transform.rotation.eulerAngles.z + velocityJ2 * Time.deltaTime;

        grauDaRotacoJ2 = Mathf.Clamp(grauDaRotacoJ2, limiteInferiorJ2, limiteSuperiorJ2);

        if (grauDaRotacoJ2 >= limiteInferiorJ2 && grauDaRotacoJ2 <= limiteSuperiorJ2)
        {
            J2.transform.rotation = Quaternion.Euler(0, 0, grauDaRotacoJ2);
        }
    }

    public void moverJ2Negativo()
    {
        grauDaRotacoJ2 = J2.transform.rotation.eulerAngles.z - velocityJ2 * Time.deltaTime;

        grauDaRotacoJ2 = Mathf.Clamp(grauDaRotacoJ2, limiteInferiorJ2, limiteSuperiorJ2);

        if (grauDaRotacoJ2 >= limiteInferiorJ2 && grauDaRotacoJ2 <= limiteSuperiorJ2)
        {
            J2.transform.rotation = Quaternion.Euler(0, 0, grauDaRotacoJ2);
        }
    }
}
