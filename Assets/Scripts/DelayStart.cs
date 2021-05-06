using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayStart : MonoBehaviour
{

    [SerializeField]
    GameObject readyText;

    [SerializeField]
    GameObject player;

    [SerializeField]
    GameObject rockSpawner;

    [SerializeField]
    float delay = 3f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartGame());
    }

    private IEnumerator StartGame()
    {
        GameObject ready = Instantiate(readyText);
        yield return new WaitForSeconds(delay);
        Destroy(ready);
        Instantiate(player);
        Instantiate(rockSpawner);
    }
}
