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
    public float velocityJ1 = 0f;
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
        velocityJ1 = sliderVelocityJ2.value;

        if (Input.GetKey(KeyCode.Alpha2) && Input.GetKey(KeyCode.RightArrow))
        {
            moverJ2PositivoJ2();
        }
        if (Input.GetKey(KeyCode.Alpha2) && Input.GetKey(KeyCode.LeftArrow))
        {
            moverJ2NegativoJ2();
        }

        if (boolPositivoJ2 == true)
        {

            moverJ2PositivoJ2();

            Debug.Log("btnpress");

        }

        if(Input.GetKey(KeyCode.A))
        {
            moverPositivoJ1();
        }
        if ((Input.GetKey(KeyCode.D)))
        {
            moverNegativoJ1();
        }

    }

    public void moverPositivoJ1()
    {
        grauDaRotacaoJ1 = J1.transform.eulerAngles.y + velocityJ1 * Time.deltaTime;

        grauDaRotacaoJ1 = Mathf.Clamp(grauDaRotacaoJ1, limiteDireitoJ1, limiteEsquerdoJ1);

        if(grauDaRotacaoJ1 >= limiteDireitoJ1 && grauDaRotacaoJ1 <= limiteEsquerdoJ1)
        {
            J1.transform.rotation = Quaternion.Euler(0, grauDaRotacaoJ1, 0);
        }
    }

    public void moverNegativoJ1()
    {

    }

    public void moverJ2PositivoJ2()
    {
        grauDaRotacoJ2 = J2.transform.rotation.eulerAngles.z + velocityJ2 * Time.deltaTime;

        grauDaRotacoJ2 = Mathf.Clamp(grauDaRotacoJ2, limiteInferiorJ2, limiteSuperiorJ2);

        if (grauDaRotacoJ2 >= limiteInferiorJ2 && grauDaRotacoJ2 <= limiteSuperiorJ2)
        {
            J2.transform.rotation = Quaternion.Euler(0, 0, grauDaRotacoJ2);
        }
    }

    public void moverJ2NegativoJ2()
    {
        grauDaRotacoJ2 = J2.transform.rotation.eulerAngles.z - velocityJ2 * Time.deltaTime;

        grauDaRotacoJ2 = Mathf.Clamp(grauDaRotacoJ2, limiteInferiorJ2, limiteSuperiorJ2);

        if (grauDaRotacoJ2 >= limiteInferiorJ2 && grauDaRotacoJ2 <= limiteSuperiorJ2)
        {
            J2.transform.rotation = Quaternion.Euler(0, 0, grauDaRotacoJ2);
        }
    }
}
