using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGSpawnerCloud1 : MonoBehaviour
{
    [SerializeField]
    private GameObject cloud;
    void Start()
    {
        StartCoroutine(Spawner());
    }


    IEnumerator Spawner() //Deplay để sinh ra
    {
        yield return new WaitForSeconds(5);
        Vector3 temp = cloud.transform.position;
        temp.y = Random.Range(-1f, 5f);
        temp.x = -5f;
        Instantiate(cloud, temp, Quaternion.identity);
        cloud.transform.position = temp;
        StartCoroutine(Spawner());
    }
}
