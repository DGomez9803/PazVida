using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InicioPrueba : MonoBehaviour
{
    public GameObject PanelInicio;
    public GameObject PanelQuiz;
    public GameObject PanelRetry;


    
    private void OnTriggerEnter2D(Collider2D collision){
        if (collision.gameObject.CompareTag("Player")){
            PanelInicio.SetActive(true);
        }
        

    }

     public void Aceptar(){

        PanelInicio.SetActive(false);
        PanelQuiz.SetActive(true);
    }

     public void Cerrar(){

        PanelInicio.SetActive(false);
        PanelQuiz.SetActive(false);
    }


}
