using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InicioPrueba : MonoBehaviour
{
    public GameObject PanelInicio;
    
    public GameObject PanelQuiz;
    public GameObject QuizManager;
    public List<QuestionAndAnswers> QnAux;
    public GameObject PanelPresentacion;

    
    private void OnTriggerEnter2D(Collider2D collision){
        if (collision.gameObject.CompareTag("Player")){
            QuizManager.GetComponent<QuizManager>().totalQuestion = QnAux.Count;
            QuizManager.GetComponent<QuizManager>().QnA=QnAux;
            QuizManager.GetComponent<QuizManager>().generarQuestion();
            PanelInicio.SetActive(true);
        }
        

    }
    public void Start()
    {
         PanelInicio.SetActive(false);
         PanelQuiz.SetActive(false);
        

    }

     public void Aceptar(){

        PanelInicio.SetActive(false);
        PanelQuiz.SetActive(true);
      
    }

     public void Cerrar(){

        PanelInicio.SetActive(false);
        PanelQuiz.SetActive(false);
        
    }

    public void Continuar(){

        PanelPresentacion.SetActive(false);
      
    }


}
