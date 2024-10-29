using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject player1Prefab;
    public GameObject player2Prefab;
    public Transform[] spawnPoints;

    void Start()
    {
        SpawnPlayers();
    }

    void SpawnPlayers()
    {
        Instantiate(player1Prefab, spawnPoints[0].position, Quaternion.identity);
        Instantiate(player2Prefab, spawnPoints[1].position, Quaternion.identity);
    }
}
