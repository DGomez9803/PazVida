using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetParametric : MonoBehaviour
{
    public ParametricList Department;

    public static ParametricList City;

    public static ParametricList CityCurrent;

    public static ParametricList Ethnic;

    public static ParametricList Gender;

    public TMPro.TMP_Dropdown dropdownDepartment;
        public TMPro.TMP_Dropdown dropdownDepartmentCurrent;


    public TMPro.TMP_Dropdown dropdownCity;


    public TMPro.TMP_Dropdown dropdownCityCurrent;

    public TMPro.TMP_Dropdown dropdownEthnic;

    public TMPro.TMP_Dropdown dropdownGender;

  

    void Start()
    {
        Department = ParametricService.GetAllDepartment();
        Ethnic = ParametricService.GetAllEthnic();
        Gender = ParametricService.GetGender();
        foreach (Parametric parametric in Department.parametricList)
        {
            dropdownDepartment
                .options
                .Add(new TMPro.TMP_Dropdown.OptionData()
                { text = parametric.text });
            dropdownDepartmentCurrent
                .options
                .Add(new TMPro.TMP_Dropdown.OptionData()
                { text = parametric.text });
        }
        foreach (Parametric parametric in Ethnic.parametricList)
        {
            dropdownEthnic
                .options
                .Add(new TMPro.TMP_Dropdown.OptionData()
                { text = parametric.text });
        }
        foreach (Parametric parametric in Gender.parametricList)
        {
            dropdownGender
                .options
                .Add(new TMPro.TMP_Dropdown.OptionData()
                { text = parametric.text });
        }
    }

    public void GetAllCityByDepartment()
    {
        dropdownCity.ClearOptions();
        City =
            ParametricService
                .GetAllCity(Department
                    .parametricList[dropdownDepartment.value]
                    .value);
        foreach (Parametric parametric in City.parametricList)
        {
            dropdownCity
                .options
                .Add(new TMPro.TMP_Dropdown.OptionData()
                { text = parametric.text });
        }
    }

    public void GetAllCityCurrentByDepartment()
    {
        dropdownCityCurrent.ClearOptions();
        CityCurrent =
            ParametricService
                .GetAllCity(Department
                    .parametricList[dropdownDepartmentCurrent.value]
                    .value);
        foreach (Parametric parametric in CityCurrent.parametricList)
        {
            dropdownCityCurrent
                .options
                .Add(new TMPro.TMP_Dropdown.OptionData()
                { text = parametric.text });
        }
    }

    

    // Update is called once per frame
    void Update()
    {
    }
}
