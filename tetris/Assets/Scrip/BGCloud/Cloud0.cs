using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud0 : MonoBehaviour
{
    public float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _CloudMovement();
    }
    void _CloudMovement()// Cloud di chuyển
    {
        Vector3 temp = transform.position;
        temp.x -= speed * Time.deltaTime;
        transform.position = temp;
    }
    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Destroy")
        {
            Destroy (gameObject);
        }
    }
    
}
