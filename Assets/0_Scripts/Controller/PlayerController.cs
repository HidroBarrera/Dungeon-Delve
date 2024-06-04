using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] GameObject menuPause;

    private PlayerControls playerInput;
    private Rigidbody2D rb2d;
    Vector2 movementInput;
    public static PlayerController instance;
    public string areaJointPoint;
    private string lastArea;
    private string currentArea;
    private Vector3 lastPositionPlayer;
    private Animator animator;

    private void Awake()
    {
        playerInput = new PlayerControls();
        // Inicialitzacio del inputSistem Overwold
        playerInput.Dungeon.Enable();
        playerInput.Dungeon.Menu.performed += Menu_Controller;
    }
    private void Menu_Controller(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        if (SceneManager.GetActiveScene().name != "Combat")
        {
            menuPause.SetActive(true);
            Time.timeScale = 0;
        }
    }

    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
        rb2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Es crida per cada frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name != "Combat")
        {
            movementInput = playerInput.Dungeon.Movement.ReadValue<Vector2>();
        }
        else
        {
            movementInput = new(0, 0);
        }
    }
    private void FixedUpdate()
    {
        // Calculem el moviment, per moure el personatge
        rb2d.velocity = new Vector2(movementInput.x * speed, movementInput.y * speed);
    }


    // Guarda la darrera posició del jugador a l'escena
    public void SetLastArea(string area)
    {
        lastArea = area;
        lastPositionPlayer = this.transform.position;
        Debug.Log("PlayerController:: Guardem la darrera Area on hem estat: " + lastArea);
    }
    public void SetCurrentArea(string area)
    {
        currentArea = area;
    }

    //Recupera la darrera àrea emmagatzemada on ha estat el Player
    public string GetLastArea()
    {
        return lastArea;
    }
    public string GetCurrentArea()
    {
        return currentArea;
    }

    //Recupera la darrera posició emmagatzemada
    public Vector3 GetLastPosition()
    {
        return lastPositionPlayer;
    }
}
