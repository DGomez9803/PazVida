using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    public string scene;



    public void OnTriggerEnter2D(Collider2D collision){
        if(collision.CompareTag("Player") && !collision.isTrigger){
            SceneManager.LoadScene(scene);
                        GameObject.FindGameObjectWithTag("position").transform.position=GameObject.FindGameObjectWithTag("Player").transform.position;

        }
    }
   
}
