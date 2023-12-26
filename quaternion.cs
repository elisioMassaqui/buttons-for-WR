using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.IO.Ports;
using Unity.VisualScripting;

public class quaternion : MonoBehaviour
{
    public SerialPort serialPort = new SerialPort ("COM19", 9600); 

     //...Carte de amor, que será recebido do arduino, com certas informações, interprete cada informação do seu jeito e use ela como quiser.
    public string mensagem;
    public TextMeshProUGUI messageLove;
    public TextMeshProUGUI anguloJ1;

    public Toggle[] toggleJuntas;

     //.Esses são pra especificamente confirmar qual das juntas queremos mover quando pressionamos o botão no protoboard.
    public bool btnJ1 = false;
    public bool btnJ2 = false;
    public bool btnJ3 = false;
    public bool btnJ4 = false;
    public bool btnJ5 = false;

     #region ConfiguracoesJ1

     [Header("Vida J1")]
     //Vida J1 e sua velocidade..
    public Transform J1; // Transformação do Nosso objecto!
    public Slider sliderVelocityJ1;
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
    public Slider sliderVelocityJ2;
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
    public Slider sliderVelocityJ3;
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
    public Slider sliderVelocityJ4;
    public float velocidadeJ4; // Velocidade dda J4;

    [Header("Eixos de J4, Usaremos Y")]
    // eixos de rotação da nossa J4, usaremos o Y.
    public float RotationJ4X; // progresso da nossa rotaçãoX, ótimo pra exibir na tela, alias todo valor pode ser exibido em tempo real!
    public float RotationJ4Y; // progresso da nossa rotaçãoY, ótimo pra exibir na tela, alias todo valor pode ser exibido em tempo real!
    public float RotationJ4Z; // progresso da nossa rotaçãoZ, ótimo pra exibir na tela, alias todo valor pode ser exibido em tempo real!
    
    [Header("Slider e valor do slider J4")]
    //Incremento e decremento num unico slider..
    public Slider sliderJ4; // slider de controle de velocidade!
    public float valorDoSliderJ4; // valor do nosso slider!

    [Header("Botões J4")]
    //botão de incrementar e decrementar..
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
    public Slider sliderVelocityJ5;
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
    // Start is called before the first frame update.
    void Start()
    {
        serialPort.Open();
    }

    // Update is called once per frame
    void Update()
    {
        //VALORES MAXIMOS MINIMOS DOS SLIDERS NA UI DE CADA JUNTA, ESSE VALOR É DO MOVIMENTO * VELCOCIDADE.

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

        velocidadeJ1 = sliderVelocityJ1.value;
        velocidadeJ2 = sliderVelocityJ2.value;
        velocidadeJ3 = sliderVelocityJ3.value;
        velocidadeJ4 = sliderVelocityJ4.value;
        velocidadeJ5 = sliderVelocityJ5.value;

        UpdateJ1();
        UpdateJ2();
        UpdateJ3();
        UpdateJ4();
        UpdateJ5();

         anguloJ1.text = "Angulo: J1.Y: " + RotationJ1Y;


        if (serialPort.IsOpen)
        {
            try
            {
                mensagem = serialPort.ReadLine();

                 //Se a mensagem na carta de amor do arduino constar "botaoblalbalbla" e a booleana do botão especifico estiver ativa.
                    //Mover J1
                    if(mensagem.Contains("botao01Pressionado") && btnJ1 == true)
                {
                    //Botoes, um para valor minimo e outro pra maximo, diferentes direcçoes!
                    UpdateJ1Min();
                    Debug.Log("botao01Pressionado");
                }
                    if(mensagem.Contains("botao02Pressionado") && btnJ1 == true)
                {
                    //Botoes, um para valor minimo e outro pra maximo, diferentes direcçoes!
                    UpdateJ1Max();
                     Debug.Log("botao02Pressionado");
                }


                    //Mover J2
                    if(mensagem.Contains("botao01Pressionado") && btnJ2 == true)
                {
                    //Botoes, um para valor minimo e outro pra maximo, diferentes direcçoes!
                    UpdateJ2Min();
                    Debug.Log("botao01Pressionado");
                }
                    if(mensagem.Contains("botao02Pressionado") && btnJ2 == true)
                {
                    //Botoes, um para valor minimo e outro pra maximo, diferentes direcçoes!
                    UpdateJ2Max();
                     Debug.Log("botao02Pressionado");
                }


                    //Mover J3
                    if(mensagem.Contains("botao01Pressionado") && btnJ3 == true)
                {
                    //Botoes, um para valor minimo e outro pra maximo, diferentes direcçoes!
                    UpdateJ3Min();
                    Debug.Log("botao01Pressionado");
                }
                    if(mensagem.Contains("botao02Pressionado") && btnJ3 == true)
                {
                    //Botoes, um para valor minimo e outro pra maximo, diferentes direcçoes!
                    UpdateJ3Max();
                     Debug.Log("botao02Pressionado");
                }


                    //Mover J4
                    if(mensagem.Contains("botao01Pressionado") && btnJ4 == true)
                {
                    //Botoes, um para valor minimo e outro pra maximo, diferentes direcçoes!
                    UpdateJ4Min();
                    Debug.Log("botao01Pressionado");
                }
                    if(mensagem.Contains("botao02Pressionado") && btnJ4 == true)
                {
                    //Botoes, um para valor minimo e outro pra maximo, diferentes direcçoes!
                    UpdateJ4Max();
                     Debug.Log("botao02Pressionado");
                }


                    //Mover J5
                    if(mensagem.Contains("botao01Pressionado") && btnJ5 == true)
                {
                    //Botoes, um para valor minimo e outro pra maximo, diferentes direcçoes!
                    UpdateJ5Min();
                    Debug.Log("botao01Pressionado");
                }
                    if(mensagem.Contains("botao02Pressionado") && btnJ5 == true)
                {
                    //Botoes, um para valor minimo e outro pra maximo, diferentes direcçoes!
                    UpdateJ5Max();
                     Debug.Log("botao02Pressionado");
                }


                //Lidando com carta de amor pra colocar e tirar da tela, metodo clãssico de limpar string pra dar um ar atualizado kkk
                 if(mensagem.Contains("botao01Pressionado") && btnJ1 == true)
                {
                    messageLove.text = "Botão Negativo Pressionado";
                }
                    else if(mensagem.Contains("botao02Pressionado") && btnJ1 == true)
                {
                    messageLove.text = "Botão Positivo Pressionado";
                }
                else
                {
                    messageLove.text = "";
                }
  

            }
            
                catch (System.Exception)
            {
                
                throw;
            }
        }

        //Loops
  
       
    }

      void OnApplicationQuit() 
    {
        serialPort.Close();
    }

    //Atualização das nossas operaçoes pra rotacionar o objecto!
    //primeiro o valor do slider recebe o valor do slider do input no UI do usuario
    //segundo o valor da rotação recebe o valor do slider vezes velociade do objecto vezes variaçao do tempo real.
    //terceiro difinimos limites fazendo o valor da rotação com limite direito e limite esquerdo, pra o valor da rotação permanecer dentre os limites.
    //quarto é aqui onde aplicamos a operação Quaternion.Euler com as rotações do objecto cuja unica rotação que está sofrer alteração é do eixo Rotation(nome da junta e eixo nesse caso J1Y) atribuindo na rotação local do nosso objecto.

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


    //Tem que resetar o slider e o valor do slider pra não houver acumulo de dados e pra não rotar continuamente sozinho.
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

    //Botoes, um para valor minimo e outro pra maximo, diferentes direcçoes!

        //Botões J1
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


        //Botões J2
        public void UpdateJ2Min()
    {
        valorDoSliderJ2 = sliderJ2.value;
        RotationJ2Z += valorButtonJ2Min * velocidadeJ2 * Time.deltaTime;
        RotationJ2Z = Mathf.Clamp(RotationJ2Z, J2Min, J2Max);
        J2.localRotation = Quaternion.Euler(RotationJ2X, RotationJ2Y, RotationJ2Z);
    }

       public void UpdateJ2Max()
    {
        valorDoSliderJ2 = sliderJ2.value;
        RotationJ2Z += valorButtonJ2Max * velocidadeJ2 * Time.deltaTime;
        RotationJ2Z = Mathf.Clamp(RotationJ2Z, J2Min, J2Max);
        J2.localRotation = Quaternion.Euler(RotationJ2X, RotationJ2Y, RotationJ2Z);
    }


        //Botões J3
            public void UpdateJ3Min()
    {
        valorDoSliderJ3 = sliderJ3.value;
        RotationJ3Z += valorButtonJ3Min * velocidadeJ3 * Time.deltaTime;
        RotationJ3Z = Mathf.Clamp(RotationJ3Z, J3Min, J3Max);
        J3.localRotation = Quaternion.Euler(RotationJ3X, RotationJ3Y, RotationJ3Z);
    }

       public void UpdateJ3Max()
    {
        valorDoSliderJ3 = sliderJ3.value;
        RotationJ3Z += valorButtonJ2Max * velocidadeJ3 * Time.deltaTime;
        RotationJ3Z = Mathf.Clamp(RotationJ3Z, J3Min, J3Max);
        J3.localRotation = Quaternion.Euler(RotationJ3X, RotationJ3Y, RotationJ3Z);
    }


        //Botões J4
            public void UpdateJ4Min()
    {
        valorDoSliderJ4 = sliderJ4.value;
        RotationJ4Y += valorButtonJ4Min * velocidadeJ4 * Time.deltaTime;
        RotationJ4Y = Mathf.Clamp(RotationJ4Y, J4Min, J4Max);
        J4.localRotation = Quaternion.Euler(RotationJ4X, RotationJ4Y, RotationJ4Z);
    }

       public void UpdateJ4Max()
    {
        valorDoSliderJ4 = sliderJ4.value;
        RotationJ4Y += valorButtonJ4Max * velocidadeJ4 * Time.deltaTime;
        RotationJ4Y = Mathf.Clamp(RotationJ4Y, J4Min, J4Max);
        J4.localRotation = Quaternion.Euler(RotationJ4X, RotationJ4Y, RotationJ4Z);
    } 


        //Botões J5
            public void UpdateJ5Min()
    {
        valorDoSliderJ5 = sliderJ5.value;
        RotationJ5Z += valorButtonJ5Min * velocidadeJ5 * Time.deltaTime;
        RotationJ5Z = Mathf.Clamp(RotationJ5Z, J5Min, J5Max);
        J5.localRotation = Quaternion.Euler(RotationJ5X, RotationJ5Y, RotationJ5Z);
    }

       public void UpdateJ5Max()
    {
        valorDoSliderJ5 = sliderJ5.value;
        RotationJ5Z += valorButtonJ5Max * velocidadeJ5 * Time.deltaTime;
        RotationJ5Z = Mathf.Clamp(RotationJ5Z, J5Min, J5Max);
        J5.localRotation = Quaternion.Euler(RotationJ5X, RotationJ5Y, RotationJ5Z);
    }

}
