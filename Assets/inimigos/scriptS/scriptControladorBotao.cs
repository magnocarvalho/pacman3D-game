using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scriptControladorBotao : MonoBehaviour
{
    public void iniciar()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }

    public void sair()
    {
        Application.Quit();
    }
}
