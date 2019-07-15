using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scriptScore : MonoBehaviour
{

    private static int score=0;
    private static Text txtPlacar;

    private void Start()
    {
        txtPlacar = GameObject.Find("txtPlacar").GetComponent<Text>();
    }

    public static void addScore(int s)
    {
        score = score + s;
        txtPlacar.text = "Placar: " + score;
       
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)){
            if (SceneManager.sceneCount == 1){
                Time.timeScale = 0;
                SceneManager.LoadScene(0, LoadSceneMode.Additive);
            }else{
                Time.timeScale = 1;
                SceneManager.UnloadSceneAsync(0);
            }
        }
        
    }

}
