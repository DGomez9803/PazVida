using System.IO;
using System;
using System.Net;
using System.Web;
using System.Text; 
using UnityEngine;
using System.Collections.Generic;

public  static class ParametricService 
{
    
    public static ParametricList GetAllCity(int idDepartment){
            var request = (HttpWebRequest)WebRequest.Create($"{Settings.getApi()}Parametric/GetAllCity?idDepartment={idDepartment}");

            request.Method = "GET";
            request.ContentType = "application/json";          

            var response = (HttpWebResponse)request.GetResponse();

            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            ParametricList respondeList =  JsonUtility.FromJson<ParametricList>("{\"parametricList\":" + responseString + "}");

            return respondeList;
    }
    public static ParametricList GetAllDepartment(){
            var request = (HttpWebRequest)WebRequest.Create($"{Settings.getApi()}Parametric/GetAllDepartment");

            request.Method = "GET";
            request.ContentType = "application/json";          

            var response = (HttpWebResponse)request.GetResponse();

            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

            ParametricList respondeList =  JsonUtility.FromJson<ParametricList>("{\"parametricList\":" + responseString + "}");
 
            return respondeList;
    }
    public static ParametricList GetAllEthnic(){
            var request = (HttpWebRequest)WebRequest.Create($"{Settings.getApi()}Parametric/GetAllEthnic");

            request.Method = "GET";
            request.ContentType = "application/json";          

            var response = (HttpWebResponse)request.GetResponse();

            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            ParametricList respondeList =  JsonUtility.FromJson<ParametricList>("{\"parametricList\":" + responseString + "}");

            return respondeList;
    }
    public static ParametricList GetGender(){
           var request = (HttpWebRequest)WebRequest.Create($"{Settings.getApi()}Parametric/GetGender");

            request.Method = "GET";
            request.ContentType = "application/json";          

            var response = (HttpWebResponse)request.GetResponse();

            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            ParametricList respondeList =  JsonUtility.FromJson<ParametricList>("{\"parametricList\":" + responseString + "}");

            return respondeList;
    }
}
