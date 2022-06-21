using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Escena : MonoBehaviour
{
     // Start is called before the first frame update
        public string Escen;

      private   void Start()
    {
       
    }
    // Update is called once per frame
    private void Update()
    {
        
    }
    public void change()
    {
         SceneManager.LoadScene(Escen);

    }

}
