using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPausa : MonoBehaviour
{
    public GameObject PanelMenu;
    public string Escena;
    public void menuPausa(){
        Time.timeScale = 0f;
        PanelMenu.SetActive(true);

    }

    public void reanudar(){
        Time.timeScale = 1f;
        PanelMenu.SetActive(false);
    }

    public void reiniciar(){
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    
    public void Inicio(){
      Time.timeScale = 1f;
        SceneManager.LoadScene(Escena);

    }
}
