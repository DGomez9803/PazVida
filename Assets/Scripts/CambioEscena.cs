using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioEscena : MonoBehaviour
{
     // Start is called before the first frame update
     [SerializeField] private float transitionTime=1f;
      public string Escena;
     public Animator TransiAnimator;


      private   void Start()
    {
       
    }
    // Update is called once per frame
    private void Update()
    {
        
    }
    public void change()
    {
          StartCoroutine(SceneLoad());
          
    }
     public IEnumerator SceneLoad()
     {
          TransiAnimator.SetTrigger("startTransi");
          yield return new WaitForSeconds(transitionTime);
          SceneManager.LoadScene(Escena);

     }
}