using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using System;
using Newtonsoft.Json;
using UnityEngine.SceneManagement;
using System.Security.Cryptography;

public class LoginController : MonoBehaviour
{
    [SerializeField] GameObject panelLogin;
    [SerializeField] Button buttonLogin;
    [SerializeField] TMP_InputField textUserName;
    [SerializeField] TMP_InputField textPassword;
    [SerializeField] TextMeshProUGUI successState;
    [SerializeField] SO_Stats stats;

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
                    SuccessApi(item);
                }
                else if (item.email == textUserName.text && item.password == textPassword.text)
                {
                    SuccessApi(item);
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
    private void SuccessApi(Usuari item)
    {
        successState.color = Color.green;
        successState.text = "Login correcte";
        ChargeScene(item.identificador);
    }

    private void ChargeScene(int identificador)
    {
        var data = DataBaseApiUri.BaseUri() + "/api/stats/" + identificador;
        UnityWebRequest www = UnityWebRequest.Get(data);
        www.downloadHandler = new DownloadHandlerBuffer();

        var statsBdd = JsonConvert.DeserializeObject<Stat>(data);
        Debug.Log("------------>  " + statsBdd);

        if (statsBdd != null)
        {
            Debug.Log("------------>  diferent a null");
            stats = JsonConvert.DeserializeObject<SO_Stats>(data);
            SceneManager.LoadScene("Vilage");
        }
        else
        {
            Debug.Log("------------>  igual a null");
            StartCoroutine(PutStats(identificador));
            SceneManager.LoadScene("Vilage");
        }
    }
    IEnumerator PutStats(int identificador)
    {
        string url = DataBaseApiUri.BaseUri() + "/api/stats";

        using UnityWebRequest www = UnityWebRequest.Post(url, CreatePostBody(identificador), "application/json");
        yield return www.SendWebRequest();

        if (www.result != UnityWebRequest.Result.Success)
        {
            FailApi(www.error);
        }
    }
    string CreatePostBody(int id)
    {
        IdStatsUsuari user = new()
        {
            identificador = id,
            stat = stats
        };
        return JsonConvert.SerializeObject(user);
    }
}
