using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockSpawner : MonoBehaviour
{

    [SerializeField]
    GameObject rockPrefab;

    [SerializeField]
    float delay = 5f;

    [SerializeField]
    float minY = -1.31f;

    [SerializeField]
    float maxY = 2f;

    private IEnumerator SpawnRocks()
    {
        while(true)
        {
            Instantiate(rockPrefab, new Vector2(transform.position.x, Random.Range(minY, maxY)), Quaternion.identity);
            yield return new WaitForSeconds(delay);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnRocks());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
