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

   public Text QuestionTxt;
   public Text ScoreTxt;

   int totalQuestion = 0 ;
   public int score;

   private void Start() {
       totalQuestion = QnA.Count;
       RetryPanel.SetActive(false);
       generarQuestion();

   }
   public void retry()
   {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
   }
   void GameOver(){
       QuizPanel.SetActive(false);
       RetryPanel.SetActive(true);
       ScoreTxt.text = score +"/"+totalQuestion;
   }

   public void correct()
   {
       score +=1;
       QnA.RemoveAt(currentQuestion);
       generarQuestion();
   }

   public void wrong(){
      QnA.RemoveAt(currentQuestion);
       generarQuestion();

   }
   void setAnswers()
   {
       for(int i =0 ;i<options.Length; i++)
       {
           options[i].GetComponent<AnswerScript>().isCorrect = false;
           options[i].transform.GetChild(0).GetComponent<Text>().text = QnA[currentQuestion].Answers[i];
          
           if(QnA[currentQuestion].CorrectAnswer ==i+1)
           {
               options[i].GetComponent<AnswerScript>().isCorrect=true;
           }
       }

   }
    void generarQuestion(){
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
        

        

    }
}
