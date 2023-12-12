using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class quaternion : MonoBehaviour
{
     //Vida J1
    public Transform J1; // Transformação do Nosso objecto!
    public float velocidadeJ1; // Velocidade dda J1;
    public Slider sliderJ1; // slider de controle de velocidade!
    public float valorDoSliderJ1; // valor do nosso slider!
    public float J1YMin; // Valor Minimo da rotaçãoY!
    public float J1YMax; // Valor Máximo da rotaçãoY!
    public float RotationJ1X; // progresso da nossa rotaçãoX, ótimo pra exibir na tela, alias todo valor pode ser exibido em tempo real!
    public float RotationJ1Y; // progresso da nossa rotaçãoY, ótimo pra exibir na tela, alias todo valor pode ser exibido em tempo real!
    public float RotationJ1Z; // progresso da nossa rotaçãoZ, ótimo pra exibir na tela, alias todo valor pode ser exibido em tempo real!
    public float valorButtonMin = -1;
    public float valorButtonMax = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        sliderJ1.minValue = -1;
        sliderJ1.maxValue = 1;
        UpdateJ1();
    }

    public void UpdateJ1()
    {
        valorDoSliderJ1 = sliderJ1.value;
        RotationJ1Y += valorDoSliderJ1 * velocidadeJ1 * Time.deltaTime;
        RotationJ1Y = Mathf.Clamp(RotationJ1Y, J1YMin, J1YMax);
        J1.localRotation = Quaternion.Euler(RotationJ1X, RotationJ1Y, RotationJ1Z);
    }
    public void resetarValores()
    {
        sliderJ1.value = 0f;
        valorDoSliderJ1 = 0f;
    }

       public void UpdateJ1Min()
    {
        valorDoSliderJ1 = sliderJ1.value;
        RotationJ1Y += valorButtonMin * velocidadeJ1 * Time.deltaTime;
        RotationJ1Y = Mathf.Clamp(RotationJ1Y, J1YMin, J1YMax);
        J1.localRotation = Quaternion.Euler(RotationJ1X, RotationJ1Y, RotationJ1Z);
    }

       public void UpdateJ1Max()
    {
        valorDoSliderJ1 = sliderJ1.value;
        RotationJ1Y += valorButtonMax * velocidadeJ1 * Time.deltaTime;
        RotationJ1Y = Mathf.Clamp(RotationJ1Y, J1YMin, J1YMax);
        J1.localRotation = Quaternion.Euler(RotationJ1X, RotationJ1Y, RotationJ1Z);
    }
}
