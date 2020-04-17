using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject menuInicial;
    public GameObject menuCredito;

    // Start is called before the first frame update
    void Start()
    {
        // Variável para a pontuação
        pontuacao = 0;
        // Mostra o resultado do jogador na caixa de texto
        textPontuacao.text = pontuacao.ToString();
    }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void abrirCreditos()
    {
        menuInicial.SetActive(false);
        menuCredito.SetActive(true);
    }

    public void fecharCredito()
    {
        menuInicial.SetActive(true);
        menuCredito.SetActive(false);
    }
}
