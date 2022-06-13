using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Login : MonoBehaviour
{
    public UserLogin loginUser;
    public  InputField userName;
    public  InputField password;

    public void login(){
        loginUser.userName =userName.text;
        loginUser.email =userName.text;
        loginUser.password =password.text;

        if(UserLoginService.ValidateUser(loginUser)!=null){
          SceneManager.LoadScene("Main menu");
          }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}