using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int pontuacao;
    //Variável para mostrar a pontuação na tela de jogo
    public Text textPontuacao;
    // Variável para mostrar a pontuação final na tela de game over
    public Text textPontuacaoFinal;
    public bool jogoPausado;
    public GameObject optionPanel;
    // Mostra painel de Game over
    public GameObject gameOverPanel;
    public GameObject quadro;
    public GameObject menuInicial;
    public GameObject menuCredito;

    // Start is called before the first frame update
    void Start()
    {
        // Variável para a pontuação
        pontuacao = 0;
        // Mostra o resultado do jogador na caixa de texto
        //textPontuacao.text = pontuacao.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            janelaOpcoes();
        }

        if(Input.GetMouseButtonDown(0))
        {

        }
    }

    // Aumenta a pontuação do jogador.
    public void aumentaPontuacao()
    {
        pontuacao++;
        textPontuacao.text = pontuacao.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Método para iniciar jogo
    public void iniciarJogo()
    {
        //SceneManager.LoadScene(1);
    }

    // Método para reiniciar jogo
    public void reiniciarJogo(){
        //SceneManager.LoadScene(1);
        Time.timeScale = 1f;
    }

    public void mostrarQuadro()
    {
        menuInicial.SetActive(false);
        menuCredito.SetActive(false);
        quadro.SetActive(true);
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

    //Método para sair do jogo.
    public void sairDoJogo(){
        Debug.Log("Clicou em SAIR");
        Application.Quit();
    }
}
