using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Expressao : MonoBehaviour
{
    public string original;
    public GameObject resposta;
    public float tempoAcertou = 1.5f;
    public bool acertou = false;
    public float tempoMostrar = 1.5f;

    public bool mostrar = false;

    // Update is called once per frame
    void Update()
    {
        if (acertou) {
            tempoAcertou -= Time.deltaTime;
            if (tempoAcertou <= 0) {
                gameObject.GetComponent<Text>().text = original;
            }
        }
    }

}
