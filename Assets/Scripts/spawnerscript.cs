using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerscript : MonoBehaviour
{
    public GameObject bombPrefab;
    private float minX = -2.55f;
    private float maxX = 2.55f;

    void Start()
    {
        StartCoroutine(spawnbomb());
    }

    IEnumerator spawnbomb()
    {
        yield return new WaitForSeconds(Random.Range(0f, 0.5f));
        Instantiate(bombPrefab, new Vector2(Random.Range(minX, maxX), transform.position.y),
        Quaternion.identity);

        StartCoroutine(spawnbomb());
    }
}
