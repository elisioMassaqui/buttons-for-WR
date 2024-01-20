using UnityEngine;
using UnityEngine.UI;

public class robotController : MonoBehaviour
{
    public GameObject J2;
    public float velocityJ2 = 30f;
    public Slider sliderVelocityJ2;
    public float limiteSuperior = 380f; // Ajuste conforme necess�rio
    public float limiteInferior = 0f;
    public float grauDaRotacao = 0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        velocityJ2 = sliderVelocityJ2.value;

        // Verifica se a tecla Alpha1 est� sendo pressionada.
        if (Input.GetKey(KeyCode.Alpha1))
        {
            // Rota��o cont�nua enquanto a tecla est� pressionada
            grauDaRotacao = J2.transform.rotation.eulerAngles.z + velocityJ2 * Time.deltaTime;

            // Aplica limites � rota��o
            grauDaRotacao = Mathf.Clamp(grauDaRotacao, limiteInferior, limiteSuperior);

            // Verifica se a rota��o est� dentro dos limites
            if (grauDaRotacao >= limiteInferior && grauDaRotacao <= limiteSuperior)
            {   
                // Aplica a transforma��o apenas se estiver dentro dos limites
                J2.transform.localRotation = Quaternion.Euler(0, 0, grauDaRotacao);          

                // Exibe o grau de rota��o no console (voc� pode ajustar isso conforme necess�rio)
                Debug.Log("Grau de Rota��o: " + grauDaRotacao);

                //Calcular limites, (Opcional)...
                var calculaLlimite = limiteInferior - limiteSuperior;
                Debug.Log("Limites Calculado" + calculaLlimite);

            }
            else
            {
                Debug.Log("Fora dos limites de rota��o!");
            }
        }
    }
}
