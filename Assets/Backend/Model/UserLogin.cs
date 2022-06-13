using System;

[System.Serializable]
public class UserLogin
{
    public int? id;

    public string userName;

    public string email;

    public string password;
}

[System.Serializable]

public class User
{
    public int? id;

    public string name;

    public string surname;

    public string dateBirth;

    public int cityCurrent;

    public int citySource;

    public int ethnic;

    public int gender;

    public int userId;
}
