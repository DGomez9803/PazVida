using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
     public string EscenaTienda;
    public void Tienda()
    {
         SceneManager.LoadScene(EscenaTienda);

    }
}
