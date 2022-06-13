using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SaveUser : MonoBehaviour
{
    public User user;

    public UserLogin loginUser;

    public InputField userNameInput;

    public InputField emailInput;

    public InputField passwordInput;

    public InputField nameInput;

    public InputField surnameInput;

    public InputField dateBirthInput;

    public TMPro.TMP_Dropdown dropdownCity;

    public TMPro.TMP_Dropdown dropdownCityCurrent;

    public TMPro.TMP_Dropdown dropdownEthnic;

    public TMPro.TMP_Dropdown dropdownGender;

    public GameObject GameObjectUserLogin;

    public GameObject GameObjectUser;

    int prevLength;

    void Start()
    {
        dateBirthInput.onValueChanged.AddListener (OnValueChanged);
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void OnValueChanged(string str)
    {
        if (str.Length > 0)
        {
            dateBirthInput.onValueChanged.RemoveAllListeners();
            if (!char.IsDigit(str[str.Length - 1]) && str[str.Length - 1] != '-'
            )
            {
                // Remove Letters
                dateBirthInput.text = str.Remove(str.Length - 1);
                dateBirthInput.caretPosition = dateBirthInput.text.Length;
            }
            else if (str.Length == 4 || str.Length == 7)
            {
                if (str.Length < prevLength)
                {
                    // Delete
                    dateBirthInput.text = str.Remove(str.Length - 1);
                    dateBirthInput.caretPosition = dateBirthInput.text.Length;
                }
                else
                {
                    // Add
                    dateBirthInput.text = str + "-";
                    dateBirthInput.caretPosition = dateBirthInput.text.Length;
                }
            }
            dateBirthInput.onValueChanged.AddListener (OnValueChanged);
        }
        prevLength = dateBirthInput.text.Length;
    }

    public void saveUserLogin()
    {
        loginUser.userName = userNameInput.text;
        loginUser.email = emailInput.text;
        loginUser.password = passwordInput.text;
        var userLoginId = UserLoginService.SaveUserLogin(loginUser);

        if (userLoginId != null)
        {
            user.userId = Int32.Parse(userLoginId);
            GameObjectUser.SetActive(true);
            GameObjectUserLogin.SetActive(false);
        }
    }

    public void saveUser()
    {
        user.name = nameInput.text;
        user.surname = surnameInput.text;
        user.dateBirth =  dateBirthInput.text;
        user.cityCurrent =
            GetParametric
                .CityCurrent
                .parametricList[dropdownCityCurrent.value]
                .value;
        user.citySource =
            GetParametric.City.parametricList[dropdownCity.value].value;
        user.ethnic =
            GetParametric.Ethnic.parametricList[dropdownEthnic.value].value;
        user.gender =
            GetParametric.Gender.parametricList[dropdownGender.value].value;

        var userId = UserLoginService.SaveUser(user);

        if (userId != null)
        {
            SceneManager.LoadScene("Inicio");
        }
    }
}
