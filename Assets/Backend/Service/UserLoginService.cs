using System;
using System.IO;
using System.Net;
using System.Text;
using System.Web;
using UnityEngine;

public static class UserLoginService
{
    public static string ValidateUser(UserLogin user)
    {
        try
        {
            var request =
                (HttpWebRequest)
                WebRequest.Create($"{Settings.getApi()}UserLogin/Login");
            var postData =
                "{" +
                $"\"userName\":\"{user.userName}\",\"password\":\"{user.password}\",\"email\":\"{user.email}\"" +
                "}";

            var data = Encoding.ASCII.GetBytes(postData);

            request.Method = "POST";
            request.ContentType = "application/json";
            request.ContentLength = data.Length;

            using (var stream = request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }

            var response = (HttpWebResponse) request.GetResponse();

            var responseString =
                new StreamReader(response.GetResponseStream()).ReadToEnd();

            return responseString;
        }
        catch (WebException webExcp)
        {
            string result = string.Empty;

            WebExceptionStatus status = webExcp.Status;
            if (status == WebExceptionStatus.ProtocolError)
            {
                HttpWebResponse httpResponse =
                    (HttpWebResponse) webExcp.Response;
                using (Stream respStream = httpResponse.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(respStream);
                    result = reader.ReadToEnd();
                }
                Debug.Log (result);
            }
            return null;
        }
    }
    public static string SaveUserLogin(UserLogin user)
    {
        try
        {
            var request =
                (HttpWebRequest)
                WebRequest.Create($"{Settings.getApi()}UserLogin/SaveUserLogin");
            var postData =
                "{" +
                $"\"userName\":\"{user.userName}\",\"password\":\"{user.password}\",\"email\":\"{user.email}\"" +
                "}";

            var data = Encoding.ASCII.GetBytes(postData);

            request.Method = "POST";
            request.ContentType = "application/json";
            request.ContentLength = data.Length;

            using (var stream = request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }

            var response = (HttpWebResponse) request.GetResponse();

            var responseString =
                new StreamReader(response.GetResponseStream()).ReadToEnd();

            return responseString;
        }
        catch (WebException webExcp)
        {
            string result = string.Empty;

            WebExceptionStatus status = webExcp.Status;
            if (status == WebExceptionStatus.ProtocolError)
            {
                Console.Write("The server returned protocol error ");
                HttpWebResponse httpResponse =
                    (HttpWebResponse) webExcp.Response;
                using (Stream respStream = httpResponse.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(respStream);
                    result = reader.ReadToEnd();
                }
                Debug.Log (result);
            }
            return null;
        }
    }
      public static string SaveUser(User user)
    {
        try
        {
            Debug.Log(user.dateBirth);
            var request =
                (HttpWebRequest)
                WebRequest.Create($"{Settings.getApi()}User/Save");
            var postData =
                "{" +
                $"\"name\":\"{user.name}\",\"surname\":\"{user.surname}\",\"dateBirth\":\"{user.dateBirth}\",\"cityCurrent\":{user.cityCurrent},\"citySource\":{user.citySource},\"ethnic\":{user.ethnic},\"gender\":{user.gender},\"userId\":{user.userId}" +
                "}";

            var data = Encoding.ASCII.GetBytes(postData);

            request.Method = "POST";
            request.ContentType = "application/json";
            request.ContentLength = data.Length;

            using (var stream = request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }

            var response = (HttpWebResponse) request.GetResponse();

            var responseString =
                new StreamReader(response.GetResponseStream()).ReadToEnd();

            return responseString;
        }
        catch (WebException webExcp)
        {
            string result = string.Empty;

            WebExceptionStatus status = webExcp.Status;
            if (status == WebExceptionStatus.ProtocolError)
            {
                HttpWebResponse httpResponse =
                    (HttpWebResponse) webExcp.Response;
                using (Stream respStream = httpResponse.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(respStream);
                    result = reader.ReadToEnd();
                }
                Debug.Log (result);
            }
            return null;
        }
    }
}
