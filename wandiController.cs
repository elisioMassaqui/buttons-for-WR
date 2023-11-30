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

        if (Input.GetKey(KeyCode.JoystickButton0)){
            Debug.Log("Joy");
        }
        if (Input.GetKey(KeyCode.JoystickButton1))
        {
            Debug.Log("Joy1");
        }
        if (Input.GetKey(KeyCode.JoystickButton2))
        {
            Debug.Log("Joy2");
        }
        if (Input.GetKey(KeyCode.JoystickButton3))
        {
            Debug.Log("Joy3");
        }
        if (Input.GetKey(KeyCode.JoystickButton4))
        {
            Debug.Log("Joy4");
        }
        if (Input.GetKey(KeyCode.JoystickButton5))
        {
            Debug.Log("Joy5");
        }
        if (Input.GetKey(KeyCode.JoystickButton6))
        {
            Debug.Log("Joy6");
        }
        if (Input.GetKey(KeyCode.JoystickButton7))
        {
            Debug.Log("Joy7");
        }
        if (Input.GetKey(KeyCode.JoystickButton8))
        {
            Debug.Log("Joy8");
        }
        if (Input.GetKey(KeyCode.JoystickButton9)) 
        {
            Debug.Log("Joy9");
        }
        if (Input.GetKey(KeyCode.JoystickButton10))
        {
            Debug.Log("Joy10");
        }
        if (Input.GetKey(KeyCode.JoystickButton11))
        {
            Debug.Log("Joy11");
        }
        if (Input.GetKey(KeyCode.JoystickButton12))
        {
            Debug.Log("Joy12");
        }
        if (Input.GetKey(KeyCode.JoystickButton13))
        {
            Debug.Log("Joy13");
        }
        if (Input.GetKey(KeyCode.JoystickButton14))
        {
            Debug.Log("Joy14");
        }
        if (Input.GetKey(KeyCode.JoystickButton15))
        {
            Debug.Log("Joy15");
        }
        if (Input.GetKey(KeyCode.JoystickButton16))
        {
            Debug.Log("Joy16");
        }
        if (Input.GetKey(KeyCode.JoystickButton17))
        {
            Debug.Log("Joy17");
        }
        if (Input.GetKey(KeyCode.JoystickButton18))
        {
            Debug.Log("Joy18");
        }
        if (Input.GetKey(KeyCode.Joystick2Button13))
        {
            Debug.Log("Joy20");
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
