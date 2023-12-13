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
    public float J1Min; // Valor Minimo da rotaçãoY!
    public float J1Max; // Valor Máximo da rotaçãoY!
    
    #endregion

         #region ConfiguracoesJ2

     [Header("Vida J2")]
     //Vida J2 e sua velocidade.
    public Transform J2; // Transformação do Nosso objecto!
    public float velocidadeJ2; // Velocidade dda J2;

    [Header("Eixos de J2, Usaremos Z")]
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
    public float J2Min; // Valor Minimo da rotaçãoX!
    public float J2Max; // Valor Máximo da rotaçãoX!
    
    #endregion

    
         #region ConfiguracoesJ3

     [Header("Vida J3")]
     //Vida J3 e sua velocidade.
    public Transform J3; // Transformação do Nosso objecto!
    public float velocidadeJ3; // Velocidade dda J3;

    [Header("Eixos de J3, Usaremos Z")]
    // eixos de rotação da nossa J3, usaremos o Z.
    public float RotationJ3X; // progresso da nossa rotaçãoX, ótimo pra exibir na tela, alias todo valor pode ser exibido em tempo real!
    public float RotationJ3Y; // progresso da nossa rotaçãoY, ótimo pra exibir na tela, alias todo valor pode ser exibido em tempo real!
    public float RotationJ3Z; // progresso da nossa rotaçãoZ, ótimo pra exibir na tela, alias todo valor pode ser exibido em tempo real!
    
    [Header("Slider e valor do slider J3")]
    //Incremento e decremento num unico slider.
    public Slider sliderJ3; // slider de controle de velocidade!
    public float valorDoSliderJ3; // valor do nosso slider!

    [Header("Botões J3")]
    //botão de incrementar e decrementar.
    public float valorButtonJ3Min = -1; //valor do botão pra ser decrementado a rotação!
    public float valorButtonJ3Max = 1; //valor do botão pra ser incrementado a rotação!

    [Header("Limites J3")]
    // valor da rotação Minima e maxima do eixo Z.
    public float J3Min; // Valor Minimo da rotaçãoZ!
    public float J3Max; // Valor Máximo da rotaçãoZ!
    
    #endregion

          #region ConfiguracoesJ4

     [Header("Vida J4")]
     //Vida J4 e sua velocidade.
    public Transform J4; // Transformação do Nosso objecto!
    public float velocidadeJ4; // Velocidade dda J4;

    [Header("Eixos de J4, Usaremos Y")]
    // eixos de rotação da nossa J4, usaremos o Y.
    public float RotationJ4X; // progresso da nossa rotaçãoX, ótimo pra exibir na tela, alias todo valor pode ser exibido em tempo real!
    public float RotationJ4Y; // progresso da nossa rotaçãoY, ótimo pra exibir na tela, alias todo valor pode ser exibido em tempo real!
    public float RotationJ4Z; // progresso da nossa rotaçãoZ, ótimo pra exibir na tela, alias todo valor pode ser exibido em tempo real!
    
    [Header("Slider e valor do slider J4")]
    //Incremento e decremento num unico slider.
    public Slider sliderJ4; // slider de controle de velocidade!
    public float valorDoSliderJ4; // valor do nosso slider!

    [Header("Botões J4")]
    //botão de incrementar e decrementar.
    public float valorButtonJ4Min = -1; //valor do botão pra ser decrementado a rotação!
    public float valorButtonJ4Max = 1; //valor do botão pra ser incrementado a rotação!

    [Header("Limites J4")]
    // valor da rotação Minima e maxima do eixo Y.
    public float J4Min; // Valor Minimo da rotaçãoY!
    public float J4Max; // Valor Máximo da rotaçãoY!
    
    #endregion

          #region ConfiguracoesJ5

     [Header("Vida J5")]
     //Vida J5 e sua velocidade.
    public Transform J5; // Transformação do Nosso objecto!
    public float velocidadeJ5; // Velocidade dda J5;

    [Header("Eixos de J5, Usaremos Z")]
    // eixos de rotação da nossa J5, usaremos o Z.
    public float RotationJ5X; // progresso da nossa rotaçãoX, ótimo pra exibir na tela, alias todo valor pode ser exibido em tempo real!
    public float RotationJ5Y; // progresso da nossa rotaçãoY, ótimo pra exibir na tela, alias todo valor pode ser exibido em tempo real!
    public float RotationJ5Z; // progresso da nossa rotaçãoZ, ótimo pra exibir na tela, alias todo valor pode ser exibido em tempo real!
    
    [Header("Slider e valor do slider J5")]
    //Incremento e decremento num unico slider.
    public Slider sliderJ5; // slider de controle de velocidade!
    public float valorDoSliderJ5; // valor do nosso slider!

    [Header("Botões J5")]
    //botão de incrementar e decrementar.
    public float valorButtonJ5Min = -1; //valor do botão pra ser decrementado a rotação!
    public float valorButtonJ5Max = 1; //valor do botão pra ser incrementado a rotação!

    [Header("Limites J5")]
    // valor da rotação Minima e maxima do eixo Z.
    public float J5Min; // Valor Minimo da rotaçãoZ!
    public float J5Max; // Valor Máximo da rotaçãoZ!
    
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

        sliderJ3.minValue = -1;
        sliderJ3.maxValue = 1;

        sliderJ4.minValue = -1;
        sliderJ4.maxValue = 1;

        sliderJ5.minValue = -1;
        sliderJ5.maxValue = 1;

        UpdateJ1();
        UpdateJ2();
        UpdateJ3();
        UpdateJ4();
        UpdateJ5();
       
    }

    public void UpdateJ1()
    {
        valorDoSliderJ1 = sliderJ1.value;
        RotationJ1Y += valorDoSliderJ1 * velocidadeJ1 * Time.deltaTime;
        RotationJ1Y = Mathf.Clamp(RotationJ1Y, J1Min, J1Max);
        J1.localRotation = Quaternion.Euler(RotationJ1X, RotationJ1Y, RotationJ1Z);
    }

      public void UpdateJ2()
    {
        valorDoSliderJ2 = sliderJ2.value;
        RotationJ2Z += valorDoSliderJ2 * velocidadeJ2 * Time.deltaTime;
        RotationJ2Z = Mathf.Clamp(RotationJ2Z, J2Min, J2Max);
        J2.localRotation = Quaternion.Euler(RotationJ2X, RotationJ2Y, RotationJ2Z);
    }

          public void UpdateJ3()
    {
        valorDoSliderJ3 = sliderJ3.value;
        RotationJ3Z += valorDoSliderJ3 * velocidadeJ3 * Time.deltaTime;
        RotationJ3Z = Mathf.Clamp(RotationJ3Z, J3Min, J3Max);
        J3.localRotation = Quaternion.Euler(RotationJ3X, RotationJ3Y, RotationJ3Z);
    }

        public void UpdateJ4()
    {
        valorDoSliderJ4 = sliderJ4.value;
        RotationJ4Y += valorDoSliderJ4 * velocidadeJ4 * Time.deltaTime;
        RotationJ4Y = Mathf.Clamp(RotationJ4Y, J3Min, J3Max);
        J4.localRotation = Quaternion.Euler(RotationJ4X, RotationJ4Y, RotationJ4Z);
    }

        public void UpdateJ5()
    {
        valorDoSliderJ5 = sliderJ5.value;
        RotationJ5Z += valorDoSliderJ5 * velocidadeJ5 * Time.deltaTime;
        RotationJ5Z = Mathf.Clamp(RotationJ5Z, J5Min, J5Max);
        J5.localRotation = Quaternion.Euler(RotationJ5X, RotationJ5Y, RotationJ5Z);
    }


    public void resetarValores()
    {
        sliderJ1.value = 0f;
        valorDoSliderJ1 = 0f;

        sliderJ2.value = 0f;
        valorDoSliderJ2 = 0f;

        sliderJ3.value = 0f;
        valorDoSliderJ3 = 0f;

        sliderJ4.value = 0f;
        valorDoSliderJ4 = 0f;

        sliderJ5.value = 0f;
        valorDoSliderJ5 = 0f;
    }

       public void UpdateJ1Min()
    {
        valorDoSliderJ1 = sliderJ1.value;
        RotationJ1Y += valorButtonJ1Min * velocidadeJ1 * Time.deltaTime;
        RotationJ1Y = Mathf.Clamp(RotationJ1Y, J1Min, J1Max);
        J1.localRotation = Quaternion.Euler(RotationJ1X, RotationJ1Y, RotationJ1Z);
    }

       public void UpdateJ1Max()
    {
        valorDoSliderJ1 = sliderJ1.value;
        RotationJ1Y += valorButtonJ1Max * velocidadeJ1 * Time.deltaTime;
        RotationJ1Y = Mathf.Clamp(RotationJ1Y, J1Min, J1Max);
        J1.localRotation = Quaternion.Euler(RotationJ1X, RotationJ1Y, RotationJ1Z);
    }
}
