using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] tetrisObjects;
    void Start()
    {
        _SpwanRandom();
    }

    // Update is called once per frame
    public void _SpwanRandom()
    {

        int index = Random.Range(0, tetrisObjects.Length);
        Instantiate(tetrisObjects[index], transform.position, Quaternion.identity);

    }
}
