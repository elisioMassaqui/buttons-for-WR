using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class quaternion : MonoBehaviour
{
     #region ConfiguracoesJ1

     [Header("Vida J1")]
     //Vida J1 e sua velocidade.
    public Transform J1; // Transformação do Nosso objecto!
    public float velocidadeJ1; // Velocidade dda J1;

    [Header("Eixos de J1, Usaremos Y")]
    // eixos de rotação da nossa J1, usaremos o Y.
    public float RotationJ1X; // progresso da nossa rotaçãoX, ótimo pra exibir na tela, alias todo valor pode ser exibido em tempo real!
    public float RotationJ1Y; // progresso da nossa rotaçãoY, ótimo pra exibir na tela, alias todo valor pode ser exibido em tempo real!
    public float RotationJ1Z; // progresso da nossa rotaçãoZ, ótimo pra exibir na tela, alias todo valor pode ser exibido em tempo real!
    
    [Header("Slider e valor do slider J1")]
    //Incremento e decremento num unico slider.
    public Slider sliderJ1; // slider de controle de velocidade!
    public float valorDoSliderJ1; // valor do nosso slider!

    [Header("Botões J1")]
    //botão de incrementar e decrementar.
    public float valorButtonJ1Min = -1; //valor do botão pra ser decrementado a rotação!
    public float valorButtonJ1Max = 1; //valor do botão pra ser incrementado a rotação!

    [Header("Limites J1")]
    // valor da rotação Minima e maxima do eixo Y.
    public float J1YMin; // Valor Minimo da rotaçãoY!
    public float J1YMax; // Valor Máximo da rotaçãoY!
    
    #endregion

         #region ConfiguracoesJ2

     [Header("Vida J2")]
     //Vida J2 e sua velocidade.
    public Transform J2; // Transformação do Nosso objecto!
    public float velocidadeJ2; // Velocidade dda J2;

    [Header("Eixos de J2, Usaremos X")]
    // eixos de rotação da nossa J1, usaremos o X.
    public float RotationJ2X; // progresso da nossa rotaçãoX, ótimo pra exibir na tela, alias todo valor pode ser exibido em tempo real!
    public float RotationJ2Y; // progresso da nossa rotaçãoY, ótimo pra exibir na tela, alias todo valor pode ser exibido em tempo real!
    public float RotationJ2Z; // progresso da nossa rotaçãoZ, ótimo pra exibir na tela, alias todo valor pode ser exibido em tempo real!
    
    [Header("Slider e valor do slider J2")]
    //Incremento e decremento num unico slider.
    public Slider sliderJ2; // slider de controle de velocidade!
    public float valorDoSliderJ2; // valor do nosso slider!

    [Header("Botões J2")]
    //botão de incrementar e decrementar.
    public float valorButtonJ2Min = -1; //valor do botão pra ser decrementado a rotação!
    public float valorButtonJ2Max = 1; //valor do botão pra ser incrementado a rotação!

    [Header("Limites J2")]
    // valor da rotação Minima e maxima do eixo X.
    public float J2XMin; // Valor Minimo da rotaçãoX!
    public float J2XMax; // Valor Máximo da rotaçãoX!
    
    #endregion
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        sliderJ1.minValue = -1;
        sliderJ1.maxValue = 1;
        
        sliderJ2.minValue = -1;
        sliderJ2.maxValue = 1;
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
        RotationJ1Y += valorButtonJ1Min * velocidadeJ1 * Time.deltaTime;
        RotationJ1Y = Mathf.Clamp(RotationJ1Y, J1YMin, J1YMax);
        J1.localRotation = Quaternion.Euler(RotationJ1X, RotationJ1Y, RotationJ1Z);
    }

       public void UpdateJ1Max()
    {
        valorDoSliderJ1 = sliderJ1.value;
        RotationJ1Y += valorButtonJ1Max * velocidadeJ1 * Time.deltaTime;
        RotationJ1Y = Mathf.Clamp(RotationJ1Y, J1YMin, J1YMax);
        J1.localRotation = Quaternion.Euler(RotationJ1X, RotationJ1Y, RotationJ1Z);
    }
}
