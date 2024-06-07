using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AreaEnter : MonoBehaviour
{
    public string areaJointPoint;

    // Use this for initialization
    void Start()
    {
        //si te el mateix nom que el que guarda el Player, el teletransportem a aquest punt
        if (areaJointPoint == PlayerController.instance.areaJointPoint)
        {
            PlayerController.instance.transform.position = transform.position;
            PlayerController.instance.SetCurrentArea(SceneManager.GetActiveScene().name);
        }
    }
}

