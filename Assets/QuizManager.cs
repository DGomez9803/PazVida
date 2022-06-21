using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class QuizManager : MonoBehaviour
{
    public List<QuestionAndAnswers> QnA;
    public GameObject[] options;
    public int currentQuestion;
    public GameObject QuizPanel;
    public GameObject RetryPanel;
    public GameObject PanelNotificacion;

     public Animator animator;
    

    public Text QuestionTxt;
    public Text ScoreTxt;
    public Text Notificacion;
    public int totalQuestion = 0 ;
    public int score;
    private void Start() {
        
        RetryPanel.SetActive(false);
    
       // generarQuestion();
   }
  

   public void retry()
   {
       /*
       RetryPanel.SetActive(false);
       QuizPanel.SetActive(true);
       currentQuestion=0;
       score=0;
       */
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
   }

   public void continuar(){
       RetryPanel.SetActive(false);
       QuizPanel.SetActive(false);
       if(score == totalQuestion){
            animator.SetTrigger("activado");
            Notificacion.text="Has terminado con éxito el eje temático. Puedes continuar con con otros y aprender mas!.";
       }
       else{
        animator.SetTrigger("activado");
            Notificacion.text="Para un mejor entendimiento del eje tematico es recomendable que completes la prueba correctamente.";
                   }
       currentQuestion=0;
       score=0;

     
    }

   void GameOver(){
       QuizPanel.SetActive(false);
       RetryPanel.SetActive(true);
       ScoreTxt.text = score +"/"+totalQuestion;
   }

   public void correct()
   {
       score +=1;
       //QnA.RemoveAt(currentQuestion);
       currentQuestion+=1;
       generarQuestion();
   }

   public void wrong(){
      //QnA.RemoveAt(currentQuestion);
       currentQuestion+=1;
       generarQuestion();

   }
   void setAnswers()
   {
        
       for(int i =0 ;i<options.Length; i++)
       {
           options[i].transform.GetChild(0).GetComponent<Text>().text = QnA[currentQuestion].Answers[i];
           if(QnA[currentQuestion].CorrectAnswer ==i+1)
           {
               options[i].GetComponent<AnswerScript>().isCorrect=true;
           }else{
               options[i].GetComponent<AnswerScript>().isCorrect = false;

           }
       }
        /*
       for(int i =0 ;i<options.Length; i++)
       {
           options[i].GetComponent<RespuestasScript>().isCorrect = false;
           options[i].transform.GetChild(0).GetComponent<Text>().text = QnA[currentQuestion].Answers[i];
           if(QnA[currentQuestion].CorrectAnswer ==i+1)
           {
               options[i].GetComponent<RespuestasScript>().isCorrect=true;
           }
       }
       */

   }
   public void generarQuestion(){

        if(currentQuestion!=totalQuestion){
            QuestionTxt.text= QnA[currentQuestion].Question;
            setAnswers();

        }else{
            Debug.Log("termino las preguntas");
            GameOver();

        }
        /*
        if(QnA.Count>0)
        {
            currentQuestion = Random.Range(0, QnA.Count);
            QuestionTxt.text= QnA[currentQuestion].Question;
            setAnswers();
        }
        else
        {
            Debug.Log("termino las preguntas");
            GameOver();
        }
        */
        

        

    }
}
