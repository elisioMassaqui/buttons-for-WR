using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class quaternion : MonoBehaviour
{
     //Vida J1
    public Transform J1; // Transformação do Nosso objecto!
    public float velocidadeJ1; // velocidade do nosso objecto!
    public Slider sliderJ1; // slider de controle de velocidade!
    public float J1Min; // Valor Minimo da rotação!
    public float J1Max; // Valor Máximo da rotação!
    public float grausDaRotacaoJ1; // progresso da nossa rotação, ótimo pra exibir na tela, alias todo valor pode ser exibido em tempo real!
    
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
        velocidadeJ1 = sliderJ1.value;
        grausDaRotacaoJ1 += velocidadeJ1 * Time.deltaTime;
        J1.localRotation = Quaternion.Euler(0f, 0f, grausDaRotacaoJ1);
    }
}
