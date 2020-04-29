using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud1 : MonoBehaviour
{
    public float speed;
    void Start()
    {

    }


    void Update()
    {
        _CloudMovement();
    }

    void _CloudMovement()
    {
        Vector3 temp = transform.position;
        temp.x += speed * Time.deltaTime;
        transform.position = temp;
    }

    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Destroy1")
        {
            Destroy(gameObject);
        }
    }
}
