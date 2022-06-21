using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MiniMap : MonoBehaviour
{
     private bool ButtonBClick = false;
     public GameObject PanelMap;
    
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
          GameObject.FindGameObjectsWithTag("ButtonB")[0].GetComponent<Button>().onClick.AddListener(ButtonClickB);
            if(ButtonBClick){
               
              
                PanelMap.SetActive(true);
             }else{
                 PanelMap.SetActive(false);

             }
             
         
}
private void ButtonClickB(){
       ButtonBClick=!ButtonBClick;
    }

}
