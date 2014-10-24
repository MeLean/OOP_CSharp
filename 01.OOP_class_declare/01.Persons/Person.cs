using System;
using System.Text.RegularExpressions;


public class Person
{
    private string name;
    private byte age;
    private string eMail;

    public Person(string name, byte age, string eMail)
    {
        this.Name = name;
        this.Age = age;
        this.Email = eMail;

    }

    public Person(string name, byte age)
        : this(name, age, null)
    {
    }

    public string Name
    {
        get
        {
            return this.name;
        }

        set
        {
            this.name = value;
        }
    }
    public byte Age
    {
        get
        {
            return this.age;
        }

        set
        {
            if (value >= 0 && value <= 100)
            {
                this.age = value;
            }
            else
            {
                throw new ArgumentException("The age must be between 0 and 100");
            }
        }
    }
    public string Email
    {
        get
        {
            return this.eMail;
        }
        set
        {
            if (!(string.IsNullOrEmpty(value)))
            {
                string a = value;
                bool isItVal = false;
                int matchIndex = a.IndexOf('@');
                if (matchIndex > 0)
                {

                    string aRight = a.Substring(matchIndex + 1);

                    if (!(aRight.IndexOf('@') > 0))
                    {
                        isItVal = true;
                    }
                }

                if (isItVal)
                {
                    this.eMail = value;
                }
                else
                {
                    throw new ArgumentException("An invalid Email!");
                }
            }
            else 
            {
                this.eMail = value;
            }

        }
    }

    public override string ToString()
    {
        string strEmail = this.Email;
        if (String.IsNullOrEmpty(strEmail))
        {
            strEmail = "none";
        }
        return "Name: " + this.Name + "\nAge: " + this.Age + "\nEmail: " + strEmail;
    }
}
