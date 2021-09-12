using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MYPROJECT : MonoBehaviour
{
    public InputField LOGIN;
    public InputField SENHA;
    public Button FAZERLOGIN;
    public Text RESPOSTALOGIN;

    // Start is called before the first frame update
    void Start()
    {
        FAZERLOGIN.onClick.AddListener(() => { CADASTRO(); });
    }

    // Update is called once per frame
    void CADASTRO()
    {
        if (LOGIN == LOGIN DO BANCO DE DADOS)
            {
            if (SENHA == SENHA DO MESMO LOGIN)
                {//ACESSO CONCLUIDO AO APP
            }
        else
            { RESPOSTALOGIN.text = "Senha ou login incorreto"; }
        }
        else
        { RESPOSTALOGIN.text = "Senha ou login incorreto"; }
    }
}
