using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class SceneManage : MonoBehaviour
{
    public Tilemap spawnTilemap;       // Assign in Inspector
    public GameObject enemyPrefab;     // Assign in Inspector
    public float spawnInterval = 10f;

    private List<Vector3Int> cachedTiles;

    void Start()
    {
        CacheTiles();
        StartCoroutine(SpawnRoutine());
    }

    void CacheTiles()
    {
        cachedTiles = new List<Vector3Int>();

        foreach (var pos in spawnTilemap.cellBounds.allPositionsWithin)
        {
            if (spawnTilemap.HasTile(pos))
            {
                cachedTiles.Add(pos);
            }
        }

        if (cachedTiles.Count == 0)
        {
            Debug.LogWarning("SceneManager: No tiles found in the assigned tilemap.");
        }
    }

    // -----------------------------
    // Spawn every X seconds
    // -----------------------------
    IEnumerator SpawnRoutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnInterval);
            SpawnEnemy();
        }
    }

    // -----------------------------
    // Spawn on a random tile
    // -----------------------------
    void SpawnEnemy()
    {
        if (cachedTiles.Count == 0) return;

        Vector3Int randomCell = cachedTiles[Random.Range(0, cachedTiles.Count)];
        Vector3 worldPos = spawnTilemap.GetCellCenterWorld(randomCell);

        Instantiate(enemyPrefab, worldPos, Quaternion.identity);
    }
}
