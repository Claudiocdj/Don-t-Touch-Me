using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class SpawnController : MonoBehaviour
{

    [SerializeField]
    private GameObject enemyPrefab = null;
    [SerializeField]
    private Vector2 spawnTime = new Vector2( 0.5f,1f);
    [SerializeField]
    private Vector2 speed = new Vector2( 1f, 3f );
    [SerializeField]
    private Vector2 movementDirection = Vector2.zero;

    private BoxCollider2D bc;

    private float timer;

    private void Start()
    {
        timer = RandomFloat(spawnTime);

        bc = GetComponent<BoxCollider2D>();
    }

    private void Update()
    {
        timer -= Time.deltaTime;

        if(timer <= 0)
        {
            SpawnEnemy();

            timer = RandomFloat(spawnTime);
        }
    }

    private void SpawnEnemy()
    {
        Vector2 pos = RandomPointInBounds( bc.bounds );

        InstantiateEnemy( pos );
    }

    private float RandomFloat(Vector2 n)
    {
        return Random.Range( n.x, n.y );
    }

    private Vector2 RandomPointInBounds(Bounds bounds)
    {
        return new Vector2(
            Random.Range( bounds.min.x, bounds.max.x ),
            Random.Range( bounds.min.y, bounds.max.y )
        );
    }

    private void InstantiateEnemy(Vector2 pos)
    {
        GameObject obj = Instantiate( enemyPrefab, pos, Quaternion.identity );

        LinearMovement move = obj.GetComponent<LinearMovement>();

        move.direction = movementDirection;

        move.speed = RandomFloat( speed );
    }
}
