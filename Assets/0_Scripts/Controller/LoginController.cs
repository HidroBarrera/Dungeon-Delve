using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using System;
using Newtonsoft.Json;
using UnityEngine.SceneManagement;

public class LoginController : MonoBehaviour
{
    [SerializeField] GameObject panelLogin;
    [SerializeField] Button buttonLogin;
    [SerializeField] TMP_InputField textUserName;
    [SerializeField] TMP_InputField textPassword;
    [SerializeField] TextMeshProUGUI successState;

    void Start()
    {
        buttonLogin.onClick.AddListener(OnLoginButtonClick);
    }

    void OnLoginButtonClick()
    {
        if (textUserName.text == "" || textUserName.text.Length <= 1 && textPassword.text == "" || textPassword.text.Length <= 1)
        {
            FailApi("Camp d'Usuari o Contrasenya, no està omplert o no compleix els requisits");
        }
        else
        {
            StartCoroutine(LoginExecute(LoadJsonDataCallBack));
        }
    }
    IEnumerator LoginExecute(Action<string> callback)
    {
        string response;
        string url = DataBaseApiUri.BaseUri() + "/api/usuari";
        Debug.Log(url);

        UnityWebRequest www = UnityWebRequest.Get(url);
        www.downloadHandler = new DownloadHandlerBuffer();

        yield return www.SendWebRequest();

        if (www.isHttpError)
        {
            response = null;
            Debug.Log("www.isHttpError");
        }
        else if (www.isNetworkError)
        {
            response = null;
            Debug.Log("www.isNetworkError");
        }
        else
        {
            response = www.downloadHandler.text;

        }

        callback(response);
    }
    private void LoadJsonDataCallBack(string res)
    {
        if (res != null)
        {
            var itemsData = JsonConvert.DeserializeObject<List<Usuari>>(res);
            foreach (var item in itemsData)
            {
                if (item.userName == textUserName.text && item.password == textPassword.text)
                {
                    SuccessApi();
                }
                else if (item.email == textUserName.text && item.password == textPassword.text)
                {
                    SuccessApi();
                }
            }
            if (successState.text != "Login correcte")
            {
                FailApi("Usuari o contrasenya incorrecte");
            }
        }
        else
        {
            FailApi("Error!");
        }
    }
    private void FailApi(string messatge)
    {
        successState.color = Color.red;
        successState.text = messatge;
    }
    private void SuccessApi()
    {
        successState.color = Color.green;
        successState.text = "Login correcte";
        SceneManager.LoadScene("Vilage");
    }
}
