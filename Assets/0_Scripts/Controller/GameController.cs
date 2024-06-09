using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    [SerializeField] GameObject controlsPanel;
    [SerializeField] GameObject menuPanel;
    [SerializeField] GameObject menuInfoPanel;
    void Start()
    {
        if (SceneManager.GetActiveScene().name == "Vilage")
        {
            controlsPanel.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void ExitPanel()
    {
        controlsPanel.SetActive(false);
        if (menuPanel == null || !menuPanel.activeInHierarchy)
        {
            Time.timeScale = 1;
        }
    }
    public void ExitMenuPanel()
    {
        menuPanel.SetActive(false);
        Time.timeScale = 1;
    }
    public void ExitMenuInfoPanel()
    {
        menuInfoPanel.SetActive(false);
    }
}
