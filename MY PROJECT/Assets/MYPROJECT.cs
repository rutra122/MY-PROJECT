using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MYPROJECT : MonoBehaviour
{
    [SerializeField]
    private InputField loginField;
    [SerializeField]
    private InputField passwordField;
    [SerializeField]
    private Button loginButton;
    [SerializeField]
    private Text reponseText;

    [SerializeField]
    private int test_userAmount;

    [SerializeField]
    private EXCEL excel = new EXCEL();

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < test_userAmount; i++)
        {
            excel.AddUser(i.ToString(), "");
        }

        loginButton.onClick.AddListener(() =>
        {
            if (Login(loginField.text, passwordField.text))
            {

                reponseText.text = "Successful login";
            }
            else
            {

                reponseText.text = "Senha ou login incorreto";
                Cadastro(loginField.text, passwordField.text);
            }
        });
    }

    bool Login(string userID, string password)
    {
        return excel.IsUserValid(userID, password);
    }

    void Cadastro(string userID, string password)
    {
        excel.AddUser(userID, password);
    }
}

[System.Serializable]
public class User
{

    public string UserName;
    public string PassWord;

    public User(string userName, string passWord)
    {
        UserName = userName;
        PassWord = passWord;
    }
}

[System.Serializable]
public class EXCEL
{
    [SerializeField]
    private List<User> users = new List<User>();

    public bool IsUserValid(string userName, string password)
    {

        for (int i = 0; i < users.Count; i++)
        {
            if (users[i].UserName == userName && users[i].PassWord == password)
            {

                return true;
            }
        }

        return false;
    }

    public bool UserExist(string userName)
    {
        for (int i = 0; i < users.Count; i++)
        {
            if (users[i].UserName == userName)
            {
                return true;
            }
        }
        return false;
    }

    public void AddUser(string userName, string password)
    {
        if (!UserExist(userName))
        {
            users.Add(new User(userName, password));
        }
    }
}
