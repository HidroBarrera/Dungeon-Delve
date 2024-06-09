using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class SigninController : MonoBehaviour
{
    [SerializeField] GameObject panelSignin;
    [SerializeField] Button buttonSignin;
    [SerializeField] TMP_InputField textUserName;
    [SerializeField] TMP_InputField textEmail;
    [SerializeField] TMP_InputField textPassword;
    [SerializeField] TextMeshProUGUI successState;

    void Start()
    {
        buttonSignin.onClick.AddListener(OnSigninButtonClick);
    }

    void OnSigninButtonClick()
    {
        if (textUserName.text == "" || textUserName.text.Length <= 1 && textEmail.text == "" || textEmail.text.Length <= 1 && textPassword.text == "" || textPassword.text.Length <= 1)
        {
            FailApi("Camp d'Usuari, Email o Contrasenya, no està omplert o no compleix els requisits");
        }
        else
        {
            StartCoroutine(LoginExecute());
        }
    }
    IEnumerator LoginExecute()
    {
        string url = DataBaseApiUri.BaseUri() + "/api/usuari";

        using UnityWebRequest www = UnityWebRequest.Post(url, CreatePostBody(), "application/json");
        yield return www.SendWebRequest();

        if (www.result != UnityWebRequest.Result.Success)
        {
            FailApi(www.error);
        }
        else
        {
            SuccessApi("Usuari creat correctament");
        }
    }
    string CreatePostBody()
    {
        Usuari user = new()
        {
            identificador = Convert.ToInt32(CountIdentificadors()),
            userName = textUserName.text,
            email = textEmail.text,
            password = textPassword.text
        };
        return JsonConvert.SerializeObject(user);
    }

    private string CountIdentificadors()
    {
        string url2 = DataBaseApiUri.BaseUri() + "/api/usuari/get";
        UnityWebRequest www = UnityWebRequest.Get(url2);
        www.downloadHandler = new DownloadHandlerBuffer();
        return www.downloadHandler.text;
    }

    private void FailApi(string messatge)
    {
        successState.color = Color.red;
        successState.text = messatge;
    }
    private void SuccessApi(string messatge)
    {
        successState.color = Color.green;
        successState.text = messatge;
    }
}
