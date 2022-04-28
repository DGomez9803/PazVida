using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class MenuSeleccionPersonaje : MonoBehaviour
{
  private int index;
    public Image imagen;
    public TextMeshProUGUI nombre;
    public GameManager gameManager;
     [SerializeField] private float transitionTime=1f;
      public string Escena;
     public Animator TransiAnimator;
    private void Start(){
        index = PlayerPrefs.GetInt("JugadorIndex");
        if(index > gameManager.personajes.Count){
            index =0;
        }
    }

    private void CambiarPantalla(){
        PlayerPrefs.SetInt("JugadorIndex", index);
        imagen.sprite = gameManager.personajes[index].imagen;
        nombre.text = gameManager.personajes[index].nombre;
    }

    public void SiguientePersonaje(){
        if(index ==gameManager.personajes.Count -1)
        {
            index = 0 ;
        }
        else 
        {
            index +=1;
        }
        CambiarPantalla();
    }
      public void AnteriorPersonaje(){
        if(index ==0)
        {
            index = gameManager.personajes.Count -1 ;
        }
        else 
        {
            index -=1;
        }
        CambiarPantalla();
    }
    public void IniciarJuego()
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


