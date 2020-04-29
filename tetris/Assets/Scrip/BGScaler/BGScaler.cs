using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScaler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        Vector3 tempScale = transform.localScale;

        float height = sr.bounds.size.y;
        float width = sr.bounds.size.x;

        float worldHeight = Camera.main.orthographicSize * 2f ;//chiều cao camera 2xSize5
        float worldWidth = worldHeight * Screen.width / Screen.height;//Chều rộng camera=tỉ lệ hình x Chiều cao camera
        tempScale.y = worldHeight / height;//Tỉ lệ
        tempScale.x = worldWidth / width;

        transform.localScale = tempScale;
    }
    //để tỉ lị hình trên unity 
    //position 0:0:0
    //Scale 1:1:1
}
