using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    public virtual void AppClose()
    {
        Application.Quit();
    }
    public virtual void StartGame()
    {
        SceneManager.LoadScene("Vilage");
    }
}
