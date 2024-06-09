using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraController : MonoBehaviour
{
    [SerializeField] GameObject Player;
    private Vector3 Offset = new(0, 0, -15);

    private void Start()
    {
        if (Player == null)
        {
            Player = GameObject.FindWithTag("Player");
        }
    }

    void LateUpdate()
    {
        if (SceneManager.GetActiveScene().name != "Combat")
        {
            transform.position = Player.transform.position + Offset;
        }
        else
        {
            transform.position = Offset;
        }
    }
}
