using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AreaExit : MonoBehaviour
{
    public string areaToLoad;
    public string areaJointPoint;

    //el punt que servira de sortida
    // si el tornessim al mateix punt on estava
    // tornaria cololisionar i farem un bucle infinit...
    public AreaEnter entranceAssociatedToExit;

    // Use this for initialization
    void Start()
    {
        try
        {
            //li diem que el punt d'unio d'arees de l'Entrance es el mateix que te
            // Exit
            entranceAssociatedToExit.areaJointPoint = areaJointPoint;
        }
        catch
        {
            Debug.Log("Error al Start del AreaExit");
        }

    }


    //Quan cololisiona amb algun altre collider
    private void OnTriggerEnter2D(Collider2D other)
    {
        //Si es el jugador
        if (other.CompareTag("Player"))
        {
            //guardem al jugador el punt on el voldrem posar
            PlayerController.instance.areaJointPoint = areaJointPoint;
            PlayerController.instance.SetLastArea(SceneManager.GetActiveScene().name);

            //carreguem l'escena
            SceneManager.LoadScene(areaToLoad);
        }
    }
}

