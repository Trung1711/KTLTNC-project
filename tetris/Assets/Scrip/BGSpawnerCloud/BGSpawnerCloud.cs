using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class BGSpawnerCloud : MonoBehaviour
{
    [SerializeField]
    private GameObject cloud1;
    void Start()
    {

        StartCoroutine (Spawner());
    }

    
    IEnumerator Spawner() //Deplay để sinh ra
    {
        yield return new WaitForSeconds(5);//tạo ra sau ..s
        Vector3 temp = cloud1.transform.position;//vị trí cloud
        temp.y = Random.Range(-1f, 5f);//random
        temp.x = 5f;
        Instantiate(cloud1,temp, Quaternion.identity);//tạo ra cloud mới
        cloud1.transform.position = temp;
        StartCoroutine (Spawner());
    }
}
