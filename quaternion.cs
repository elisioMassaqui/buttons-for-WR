using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.IO.Ports;

public class quaternion : MonoBehaviour
{

    public SerialPort serialPort; 

    [Header("Serial Unity-Arduino")]
     //...Carte de amor, que será recebido do arduino,, com certas informações, interprete cada informação do seu jeito e use ela como quiser.
    public string mensagem;
    public TextMeshProUGUI messageLove;  //Botão a ser pressionado

    [Header("Pra Usuário Definir A Porta Ou Tipo De Arduino.")]
    public string portaArduino;
    public TMP_InputField inputArduinoPorta;
    public TextMeshProUGUI statusPort;
    public GameObject ConfigPort;

    [Header("Angulos das Juntas Na UI")]
    public TextMeshProUGUI anguloJ1;  //Mostrar, o angulo da junta a ser movida, em tempo real na tela.
    public TextMeshProUGUI anguloJ2;
    public TextMeshProUGUI anguloJ3;
    public TextMeshProUGUI anguloJ4;
    public TextMeshProUGUI anguloJ5;

    //O toggle é o componente da UI que funciona como bool..
    [Header("Ativar e Desativar Botões Da Protoboard")]
    public Toggle toggleJ1;
    public Toggle toggleJ2;
    public Toggle toggleJ3;
    public Toggle toggleJ4;
    public Toggle toggleJ5;

    [Header("Modo Automático")]
    public Toggle updateJ1Min;
    public Toggle updateJ1Max;
    public Toggle updateJ2Min;
    public Toggle updateJ2Max;
    public Toggle updateJ3Min;
    public Toggle updateJ3Max;
    public Toggle updateJ4Min;
    public Toggle updateJ4Max;
    public Toggle updateJ5Min;
    public Toggle updateJ5Max;

    [Header("Tempo Do Repouso Da Junta Na UI")]
    public TextMeshProUGUI floatJ1;
    public TextMeshProUGUI floatJ2;
    public TextMeshProUGUI floatJ3;
    public TextMeshProUGUI floatJ4;
    public TextMeshProUGUI floatJ5;

    [Header("Valor Tempo Do Repouso Da Junta Na UI")]
    public float yieldJ1;
    public float yieldJ2;
    public float yieldJ3;
    public float yieldJ4;
    public float yieldJ5;

    [Header("Slider Pra Controle Do Tempo De Repouso Da Junta")]
    public Slider sliderYieldJ1;
    public Slider sliderYieldJ2;
    public Slider sliderYieldJ3;
    public Slider sliderYieldJ4;
    public Slider sliderYieldJ5;


    [Header("Rastreio De Funções")]
    public GameObject Painel;

    public Scrollbar scrollbar;

    [Header("=============Vida das Juntas=============")]
     #region ConfiguracoesJ1

     [Header("Vida J1")]
     //Vida J1 e sua velocidade...
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
        //É melhor começar inicializar como falso ou null ou não usaveis pra não ter conflitos de controles e não dar problema parecido com Gimpal Lock e fazer o coitado tremer kkk.
        updateJ1Min.isOn = !true;
        updateJ1Max.isOn = false;

        updateJ2Min.isOn = !true;
        updateJ2Max.isOn = false;

        updateJ3Min.isOn = !true;
        updateJ3Max.isOn = false;

        updateJ4Min.isOn = !true;
        updateJ4Max.isOn = false;

        updateJ5Min.isOn = !true;
        updateJ5Max.isOn = false;


        // Inicialize o SerialPort com as configurações necessárias
        serialPort = new SerialPort();
        // Configurar outras configurações do SerialPort, se necessário
        serialPort.BaudRate = 9600;
    }

    public void OpenPorta(){
         //A varaivel que vai dar a porta pra seriaPort está recebendo aqui o input do usuario.
        portaArduino = inputArduinoPorta.text;
        try
        {
        //Recebe o nome da porta da variavel que vai receber do Input.
            serialPort.PortName = portaArduino;
            serialPort.Open();
            statusPort.text = "A sua porta: |" + portaArduino + "| Foi Aberta Com Sucesso!";
            StartCoroutine(entrarCena());
            

        }
        catch (System.Exception e)
        {
            Debug.LogError("Erro ao abrir a porta: " + e.Message);
            statusPort.text = "Falha Ao Abrir A Porta: " + portaArduino;

        }

    }


    public void ClosePort()
    {
        // Fechar a porta se estiver aberta
        if (serialPort.IsOpen)
        {
            serialPort.Close();
            statusPort.text = "Porta fechada!!!";
        }
    }

    IEnumerator entrarCena(){
        yield return new WaitForSeconds(8f);
        ConfigPort.SetActive(false);
    }


    // Update is called once per frame
    void Update()
    {
        if (serialPort.IsOpen)
        {
            if(Input.GetKeyDown(KeyCode.Space)){
            try
            {
                serialPort.Write("A");
                Debug.Log("A fOR aRDUINO");
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }
    }
       
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

        sliderYieldJ1.minValue = 2f;
        sliderYieldJ1.maxValue = 15f;

        sliderYieldJ2.minValue = 2f;
        sliderYieldJ2.maxValue = 15f;

        sliderYieldJ3.minValue = 2f;
        sliderYieldJ3.maxValue = 15f;

        sliderYieldJ5.minValue = 2f;
        sliderYieldJ5.maxValue = 15f;

        //Sliders de velociadade na UI.
        velocidadeJ1 = sliderVelocityJ1.value;
        velocidadeJ2 = sliderVelocityJ2.value;
        velocidadeJ3 = sliderVelocityJ3.value;
        velocidadeJ4 = sliderVelocityJ4.value;
        velocidadeJ5 = sliderVelocityJ5.value;

        yieldJ1 = sliderYieldJ1.value;
        yieldJ2 = sliderYieldJ2.value;
        yieldJ3 = sliderYieldJ3.value;
        yieldJ4 = sliderYieldJ4.value;
        yieldJ5 = sliderYieldJ5.value;

        //As seguintes funções foram chamadas aqui segundo por segundo pra elas sem manterem atualizadas, que nem um listener.
        //Atualizar os metodos que serão usados pelo SliderController.
        UpdateJ1();
        UpdateJ2();
        UpdateJ3();
        UpdateJ4();
        UpdateJ5();
        //atualizar os metodos que serão usados na interface pelo botão pra deixar as juntas automaticas atraves de IEnumerator.
        ativarJ1Min();
        ativarJ1Max();
        ativarJ2Min();
        ativarJ2Max();
        ativarJ3Min();
        ativarJ3Max();
        ativarJ4Min();
        ativarJ4Max();
        ativarJ5Min();
        ativarJ5Max();


        

        /*/Pra receber automatação dos loops do arduino e exeutar os metodos na unity.
        if (mensagem.Contains("FORJ1MIN"))
        {
            UpdateJ1Min();
        }
        else if(mensagem.Contains("FORJ1MAX")){
            UpdateJ1Max();
        }

        if (mensagem.Contains("FORJ2MIN"))
        {
            UpdateJ2Min();
        }
        else if(mensagem.Contains("FORJ2MAX")){
            UpdateJ2Max();
        }
        */

        //o texto do angulo J da UI vai receber a string concatenada com o progresso do seu angulo.
        anguloJ1.text = "Angulo J1.Y: " + RotationJ1Y.ToString("F3");
        anguloJ2.text = "Angulo J2.Z: " + RotationJ2Z.ToString("F3");
        anguloJ3.text = "Angulo J3.Z: " + RotationJ3Z.ToString("F3");
        anguloJ4.text = "Angulo J4.Y: " + RotationJ4Y.ToString("F3");
        anguloJ5.text = "Angulo J5.Y: " + RotationJ5Z.ToString("F3");

        floatJ1.text = "J1 Repouso: " + yieldJ1.ToString("F2");
        floatJ2.text = "J2 Repouso: " + yieldJ2.ToString("F2");
        floatJ3.text = "J3 Repouso: " + yieldJ3.ToString("F2");
        floatJ4.text = "J4 Repouso: " + yieldJ4.ToString("F2");
        floatJ5.text = "J5 Repouso: " + yieldJ5.ToString("F2");

        if (serialPort.IsOpen)
        {
            try
            {

                //Receber carta de amor do arduino.
                mensagem = serialPort.ReadLine();
                 //Se a mensagem na carta de amor do arduino constar "botaoblalbalbla" e a booleana do botão especifico estiver ativa.
                    //Mover J1
                    if(mensagem.Contains("botao01Pressionado") && toggleJ1.isOn)
                {
                    //Botoes, um para valor minimo e outro pra maximo, diferentes direcçoes!
                    UpdateJ1Min();
                    Debug.Log("botao01Pressionado");
                }
                    if(mensagem.Contains("botao02Pressionado") && toggleJ1.isOn)
                {
                    //.Botoes, um para valor minimo e outro pra maximo, diferentes direcçoes!
                    UpdateJ1Max();
                     Debug.Log("botao02Pressionado");
                }


                    //Mover J2
                    if(mensagem.Contains("botao01Pressionado") && toggleJ2.isOn)
                {
                    //Botoes, um para valor minimo e outro pra maximo, diferentes direcçoes!
                    UpdateJ2Min();
                    Debug.Log("botao01Pressionado");
                }
                    if(mensagem.Contains("botao02Pressionado") && toggleJ2.isOn)
                {
                    //Botoes, um para valor minimo e outro pra maximo, diferentes direcçoes!
                    UpdateJ2Max();
                     Debug.Log("botao02Pressionado");
                }


                    //Mover J3
                    if(mensagem.Contains("botao01Pressionado") && toggleJ3.isOn)
                {
                    //Botoes, um para valor minimo e outro pra maximo, diferentes direcçoes!
                    UpdateJ3Min();
                    Debug.Log("botao01Pressionado");
                }
                    if(mensagem.Contains("botao02Pressionado") && toggleJ3.isOn)
                {
                    //Botoes, um para valor minimo e outro pra maximo, diferentes direcçoes!
                    UpdateJ3Max();
                     Debug.Log("botao02Pressionado");
                }


                    //Mover J4
                    if(mensagem.Contains("botao01Pressionado") && toggleJ4.isOn)
                {
                    //Botoes, um para valor minimo e outro pra maximo, diferentes direcçoes!
                    UpdateJ4Min();
                    Debug.Log("botao01Pressionado");
                }
                    if(mensagem.Contains("botao02Pressionado") && toggleJ4.isOn)
                {
                    //Botoes, um para valor minimo e outro pra maximo, diferentes direcçoes!
                    UpdateJ4Max();
                     Debug.Log("botao02Pressionado");
                }


                    //Mover J5
                    if(mensagem.Contains("botao01Pressionado") && toggleJ5.isOn)
                {
                    //Botoes, um para valor minimo e outro pra maximo, diferentes direcçoes!
                    UpdateJ5Min();
                    Debug.Log("botao01Pressionado");
                }
                    if(mensagem.Contains("botao02Pressionado") && toggleJ5.isOn)
                {
                    //Botoes, um para valor minimo e outro pra maximo, diferentes direcçoes!
                    UpdateJ5Max();
                     Debug.Log("botao02Pressionado");
                }


                //Lidando com carta de amor pra colocar e tirar da tela, metodo clãssico de limpar string pra dar um ar atualizado kkk
                 if(mensagem.Contains("botao01Pressionado") && toggleJ1.isOn)
                {
                    messageLove.text = "Botão Negativo Pressionado";
                }
                    else if(mensagem.Contains("botao02Pressionado") && toggleJ1.isOn)
                {
                    messageLove.text = "Botão Positivo Pressionado";
                }
                else
                {
                    messageLove.text = "Arduino Love Card";
                }
  

            }
            
                catch (System.Exception)
            {
                throw;
            }
        }

        //Enviar Carta de amor pra arduino.
         if(serialPort.IsOpen && RotationJ1Y < 0){
            try
            {
                serialPort.Write("C");
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }
        else if (serialPort.IsOpen && RotationJ1Y > 0)
        {
             try
            {
                serialPort.Write("B");
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }

        //Loops

  
    //Se sair do programa fecha a porta.
      void OnApplicationQuit() 
    {
        serialPort.Close();
    }

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

    //Botoes, um para valor minimo e outro pra maximo, diferentes direcçoes,podem ser chamados onde voce quiser, estão dispostas pra te servir!

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



     //Essas são as foqueiras que escutam por trás das cortinas e avisam pra outras tias se mexerem kkk
    public void ativarJ1Min(){
        if (updateJ1Min.isOn)
        {
            UpdateJ1Min();
        }
    }

    public void ativarJ1Max(){
        if (updateJ1Max.isOn)
        {
            UpdateJ1Max();
        }
    }
    
    public void ativarJ2Min(){
        if(updateJ2Min.isOn){
            UpdateJ2Min();
        }
    }

    public void ativarJ2Max(){
        if (updateJ2Max.isOn)
        {
            UpdateJ2Max();
        }
    }
    public void ativarJ3Min(){
        if (updateJ3Min.isOn)
        {
            UpdateJ3Min();
        }
    }
     public void ativarJ3Max(){
        if (updateJ3Max.isOn)
        {
            UpdateJ3Max();
        }
    }
    public void ativarJ4Min(){
        if(updateJ4Min.isOn){
            UpdateJ4Min();
        }
    }
    public void ativarJ4Max(){
        if (updateJ4Max.isOn)
        {
            UpdateJ4Max();
        }
    }
    public void ativarJ5Min(){
        if(updateJ5Min.isOn){
            UpdateJ5Min();
        }
    }
    public void ativarJ5Max(){
        if (updateJ5Max.isOn)
        {
            UpdateJ5Max();
        }
    }

     //Aqui estão aqueles que serão usados pelo evento de clique nos botões lá no insepector já que as cortinas não são os tipos de meotodos pra serem cahamados do Inspector.

    public void ativarJunta1()
    {
        StartCoroutine(primeiraJunta()); 
    }

    public void ativarJunta2(){
        StartCoroutine(segundaJunta());
    }
    public void ativarJunta3(){
        StartCoroutine(terceiraJunta());
    }
    public void ativarJunta4(){
        StartCoroutine(quartaJunta());
    }
    public void ativarJunta5(){
        StartCoroutine(quintaJunta());
    }



    //Essas são as nossas cortinas capazes de fazer jogos de luz e deixar algo com um ar automatico.

    IEnumerator primeiraJunta()
    {
        while (true)
        {
        updateJ1Min.isOn = true;
        updateJ1Max.isOn = false;
        yield return new WaitForSeconds(yieldJ1);

        updateJ1Min.isOn = false;
        updateJ1Max.isOn = true;
        yield return new WaitForSeconds(yieldJ1);
        }
    }

    IEnumerator segundaJunta(){
        while (true)
        {
            updateJ2Min.isOn = true;
            updateJ2Max.isOn = false;
            Debug.Log("J2-");
            yield return new WaitForSeconds(yieldJ2);

            updateJ2Min.isOn = false;
            updateJ2Max.isOn = true;
            Debug.Log("J2+");
            yield return new WaitForSeconds(yieldJ2);
        }
    }

    IEnumerator terceiraJunta(){
        while (true)
        {
        updateJ3Min.isOn = true;
        updateJ3Max.isOn = false;
        yield return new WaitForSeconds(yieldJ3);

        updateJ3Min.isOn = false;
        updateJ3Max.isOn = true;
        yield return new WaitForSeconds(yieldJ3);
     }  
  }

  IEnumerator quartaJunta(){
    while (true)
    {
        updateJ4Min.isOn = true;
        updateJ4Max.isOn = false;
        yield return new WaitForSeconds(yieldJ4);

        updateJ4Min.isOn = false;
        updateJ4Max.isOn = true;
        yield return new WaitForSeconds(yieldJ5);
    }
  }

  IEnumerator quintaJunta(){
    while (true)
    {
    updateJ5Min.isOn = true;
    updateJ5Max.isOn = false;
    yield return new WaitForSeconds(yieldJ5);

    updateJ5Min.isOn = false;
    updateJ5Max.isOn = true;
    yield return new WaitForSeconds(yieldJ5);   
    }
  }
}
