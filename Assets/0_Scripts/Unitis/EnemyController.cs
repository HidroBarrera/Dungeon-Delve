using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;
using UnityEngine.Tilemaps;

public class EnemyController : MonoBehaviour
{
    [SerializeField] List<SO_SpawnList> Enemy;
    [SerializeField] float detectionRadius;
    float tiempoEspera = 2f;
    [SerializeField] Tilemap tilemap;
    [SerializeField] NavMeshAgent agent;

    private Transform player;
    private Rigidbody2D rb2d;
    readonly System.Random rng = new();

    void Start()
    {
        if (SceneManager.GetActiveScene().name != "Combat")
        {
            agent = GetComponent<NavMeshAgent>();
            agent.updateRotation = false;
            agent.updateUpAxis = false;
            rb2d = GetComponent<Rigidbody2D>();

            GameObject playerObject = GameObject.Find("Player");
            if (playerObject != null)
            {
                player = playerObject.transform;
            }
        }
    }
    void Update()
    {
        if (SceneManager.GetActiveScene().name != "Combat")
        {
            float distanceToPlayer = Vector2.Distance(transform.position, player.position);

            if (distanceToPlayer < detectionRadius)
            {
                agent.SetDestination(player.position);
            }
            else
            {
                if (Time.time >= tiempoEspera)
                {
                    agent.SetDestination(new Vector2(UnityEngine.Random.Range(-50, 26), UnityEngine.Random.Range(-26, 11)));
                    tiempoEspera = Time.time + UnityEngine.Random.Range(1f, 10f);
                }
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (SceneManager.GetActiveScene().name != "Combat")
        {
            StaticFunc.SaveEnemyList(Enemy[rng.Next(Enemy.Count)]);
            this.IsDestroyed();
        }
    }
}
