using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using Unity.VisualScripting;

public class wandiController : MonoBehaviour
{

    //Vida Da Nossa JuntaJ1 e verifica��es booleanas.
    public GameObject J1;
    public float velocityJ1 = 0f;
    public Slider sliderVelocityJ1;
    public float limiteEsquerdoJ1;
    public float limiteDireitoJ1;
    public float grauDaRotacaoJ1;
    public bool J1POSITIVO = false;
    public bool J1NEGATIVO = false;

    //Vida Da Nossa Junta2 e verifica��es booleanas.
    public GameObject J2;
    public float velocityJ2 = 0f;
    public Slider sliderVelocityJ2;
    public float limiteSuperiorJ2;
    public float limiteInferiorJ2;
    public float grauDaRotacoJ2;
    public bool J2POSITIVO = false;
    public bool J2NEGATIVO = false;

    //Vida Da Nossa Junta3 e verifica��es booleanas.
    public GameObject J3;
    public float velocityJ3 = 0f;
    public Slider sliderVelocityJ3;
    public float limiteSuperiorJ3;
    public float limiteInferiorJ3;
    public float grauDaRotacoJ3;
    public bool J3POSITIVO = false;
    public bool J3NEGATIVO = false;

    //Vida Da Nossa Junta4 e verifica��es booleanas.
    public GameObject J4;
    public float velocityJ4 = 0f;
    public Slider sliderVelocityJ4;
    public float limiteEsquerdoJ4;
    public float limiteDireitoJ4;
    public float grauDaRotacoJ4;
    public bool J4POSITIVO = false;
    public bool J4NEGATIVO = false;

    //Vida Da Nossa Junta5 e verifica��es booleanas.
    public GameObject J5;
    public float velocityJ5 = 0f;
    public Slider sliderVelocityJ5;
    public float limiteSuperiorJ5;
    public float limiteInferiorJ5;
    public float grauDaRotacoJ5;
    public bool J5POSITIVO = false;
    public bool J5NEGATIVO = false;


    // Start is called before the first frame update......
    void Start()
    {
       
    }

    // Update is called once per frame.
    void Update()
    {
        // A velocidade da nossa junta recebe o valor do Slider.
        velocityJ1 = sliderVelocityJ1.value;
        velocityJ2 = sliderVelocityJ2.value;
        velocityJ3 = sliderVelocityJ3.value;
        velocityJ4 = sliderVelocityJ4.value;
        velocityJ5 = sliderVelocityJ5.value;


    cubinhos();  

    inputKey();     
        

    }

    public void moverPositivoJ1()
    {
        grauDaRotacaoJ1 = J1.transform.localRotation.eulerAngles.y + velocityJ1 * Time.deltaTime;

        grauDaRotacaoJ1 = Mathf.Clamp(grauDaRotacaoJ1, limiteEsquerdoJ1, limiteDireitoJ1);

        if (grauDaRotacaoJ1 >= limiteEsquerdoJ1 && grauDaRotacaoJ1 <= limiteDireitoJ1)
        {
            J1.transform.localRotation = Quaternion.Euler(0, grauDaRotacaoJ1, 0);
        }

    }

    public void moverNegativoJ1()
    {
        grauDaRotacaoJ1 = J1.transform.localRotation.eulerAngles.y - velocityJ1 * Time.deltaTime;

        grauDaRotacaoJ1 = Mathf.Clamp(grauDaRotacaoJ1, limiteEsquerdoJ1, limiteDireitoJ1);

        if (grauDaRotacaoJ1 >= limiteEsquerdoJ1 && grauDaRotacaoJ1 <= limiteDireitoJ1)
        {
            J1.transform.localRotation = Quaternion.Euler(0, grauDaRotacaoJ1, 0);
        }
    }



    public void moverPositivoJ2()
    {
        grauDaRotacoJ2 = J2.transform.localRotation.eulerAngles.z + velocityJ2 * Time.deltaTime;

        grauDaRotacoJ2 = Mathf.Clamp(grauDaRotacoJ2, limiteInferiorJ2, limiteSuperiorJ2);

        if (grauDaRotacoJ2 >= limiteInferiorJ2 && grauDaRotacoJ2 <= limiteSuperiorJ2)
        {
            J2.transform.localRotation = Quaternion.Euler(0, 0, grauDaRotacoJ2);
        }
    }

    public void moverNegativoJ2()
    {
        grauDaRotacoJ2 = J2.transform.localRotation.eulerAngles.z - velocityJ2 * Time.deltaTime;

        grauDaRotacoJ2 = Mathf.Clamp(grauDaRotacoJ2, limiteInferiorJ2, limiteSuperiorJ2);

        if (grauDaRotacoJ2 >= limiteInferiorJ2 && grauDaRotacoJ2 <= limiteSuperiorJ2)
        {
            J2.transform.localRotation = Quaternion.Euler(0, 0, grauDaRotacoJ2);
        }
    }

    public void moverPositivoJ3()
    {
        grauDaRotacoJ3 = J3.transform.localRotation.eulerAngles.z + velocityJ3 * Time.deltaTime;

        grauDaRotacoJ3 = Mathf.Clamp(grauDaRotacoJ3, limiteInferiorJ3, limiteSuperiorJ3);

        if (grauDaRotacoJ3 >= limiteInferiorJ3 && grauDaRotacoJ3 <= limiteSuperiorJ3)
        {
            J3.transform.localRotation = Quaternion.Euler(0, 0, grauDaRotacoJ3);
        }
    }

    public void moverNegativoJ3()
    {
        grauDaRotacoJ3 = J3.transform.localRotation.eulerAngles.z - velocityJ3 * Time.deltaTime;

        grauDaRotacoJ3 = Mathf.Clamp(grauDaRotacoJ3, limiteInferiorJ3, limiteSuperiorJ3);

        if (grauDaRotacoJ3 >= limiteInferiorJ3 && grauDaRotacoJ3 <= limiteSuperiorJ3)
        {
            J3.transform.localRotation = Quaternion.Euler(0, 0, grauDaRotacoJ3);
        }
    }

    public void moverNegativoJ4()
    {
        grauDaRotacoJ4 = J4.transform.localRotation.eulerAngles.y - velocityJ4 * Time.deltaTime;

        grauDaRotacoJ4 = Mathf.Clamp(grauDaRotacoJ4, limiteEsquerdoJ4, limiteDireitoJ4);

        if(grauDaRotacoJ4 >= limiteEsquerdoJ4 && grauDaRotacoJ4 <= limiteDireitoJ4)
        {
            J4.transform.localRotation = Quaternion.Euler(0, grauDaRotacoJ4, 0);
        }
    }

    public void moverPositivoJ4()
    {
        grauDaRotacoJ4 = J4.transform.localRotation.eulerAngles.y + velocityJ4 * Time.deltaTime;

        grauDaRotacoJ4 = Mathf.Clamp(grauDaRotacoJ4, limiteEsquerdoJ4, limiteDireitoJ4);

        if (grauDaRotacoJ4 >= limiteEsquerdoJ4 && grauDaRotacoJ4 <= limiteDireitoJ4)
        {
            J4.transform.localRotation = Quaternion.Euler(0, grauDaRotacoJ4, 0);
        }
    }

    public void moverPositivoJ5()
    {
        grauDaRotacoJ5 = J5.transform.localRotation.eulerAngles.z + velocityJ5 * Time.deltaTime;

        grauDaRotacoJ5 = Mathf.Clamp(grauDaRotacoJ5, limiteInferiorJ5, limiteSuperiorJ5);

        if(grauDaRotacoJ5 >= limiteInferiorJ5 && grauDaRotacoJ5 <= limiteSuperiorJ5) 
        {
            J5.transform.localRotation = Quaternion.Euler(0, 0, grauDaRotacoJ5);
        }
    }

    public void moverNegativoJ5()
    {
        grauDaRotacoJ5 = J5.transform.localRotation.eulerAngles.z - velocityJ5 * Time.deltaTime;

        grauDaRotacoJ5 = Mathf.Clamp(grauDaRotacoJ5, limiteInferiorJ5, limiteSuperiorJ5);

        if(grauDaRotacoJ5 >= limiteInferiorJ5 && grauDaRotacoJ5 < limiteSuperiorJ5)
        {
            J5.transform.localRotation = Quaternion.Euler(0, 0, grauDaRotacoJ5);
        }
    }

    void cubinhos()
    {
        
        if(J1POSITIVO == true)
        {
            moverPositivoJ1();
        }
        if(J1NEGATIVO == true)
        {
            moverNegativoJ1();
        }


        if(J2POSITIVO == true)
        {
            moverPositivoJ2();
        }

        if(J2NEGATIVO == true)
        {
            moverNegativoJ2();
        }


        if (J3POSITIVO == true)
        {
            moverPositivoJ3();
        }
        if(J3NEGATIVO == true)
        {
            moverNegativoJ3();
        }
        if (J4POSITIVO == true)
        {
            moverPositivoJ4();
        }
        if (J4NEGATIVO == true) 
        {
            moverNegativoJ4();
        }
        if (J5POSITIVO == true)
        {
         
        }
        if (J5NEGATIVO == true)
        {

        }
    }

    void inputKey()
    {
              // Controle do Teclado Junta 1
        if (Input.GetKey(KeyCode.A))
        {
            moverPositivoJ1();
        }
        if (Input.GetKey(KeyCode.D))
        {
            moverNegativoJ1();
        }

        // Controle do Teclado Junta 2
        if (Input.GetKey(KeyCode.Alpha2) && Input.GetKey(KeyCode.RightArrow))
        {
            moverPositivoJ2();
        }
        if (Input.GetKey(KeyCode.Alpha2) && Input.GetKey(KeyCode.LeftArrow))
        {
            moverNegativoJ2();
        }

        // Controle do Teclado Junta 3.
        if (Input.GetKey(KeyCode.Alpha3) && Input.GetKey(KeyCode.RightArrow))
        {
            moverPositivoJ3();
        }
        if(Input.GetKey(KeyCode.Alpha3) && Input.GetKey(KeyCode.LeftArrow))
        {
            moverNegativoJ3();
        }

        // Controle do Teclado Junta 4.
        if (Input.GetKey(KeyCode.Alpha4) && Input.GetKey(KeyCode.RightArrow))
        {
            moverPositivoJ4();
        }
        if(Input.GetKey(KeyCode.Alpha4) && Input.GetKey(KeyCode.LeftArrow))
        {
            moverNegativoJ4();
        }

    }

}
