using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play : MonoBehaviour
{
    float lastFall = 0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(-1, 0, 0);
            if (IsValiGridPosition())
            {
                UpdateMatrix();
            }
            else
            {
                transform.position += new Vector3(1, 0, 0);
            }
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.position += new Vector3(1, 0, 0);
            if (IsValiGridPosition())
            {
                UpdateMatrix();
            }
            else
            {
                transform.position += new Vector3(-1, 0, 0);
            }
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.Rotate(new Vector3(0, 0, -90));
            if (IsValiGridPosition())
            {
                UpdateMatrix();
            }
            else
            {
                transform.Rotate(new Vector3(0, 0, 90));
            }
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) || Time.time -lastFall>=1)
        {
            transform.position += new Vector3(0, -1, 0);
            if (IsValiGridPosition())
            {
                UpdateMatrix();
            }
            else
            {
                transform.position += new Vector3(0, 1, 0);
                Matrix.DeleteWholeRows();
                FindObjectOfType<Spawner>()._SpwanRandom();
                enabled = false;
            }
            lastFall = Time.time;
        }
    }
    bool IsValiGridPosition()
    {
        foreach(Transform child in transform)
        {
            Vector2 v = Matrix.RoundVector(child.position);
            if (!Matrix.IsInsideBorder(v))
            {
                return false;
            }
            if (Matrix.grid[(int)v.x, (int)v.y] != null && Matrix.grid[(int)v.x, (int)v.y].parent != transform)
            {
                return false;
            }
        }
        return true;
    }
    void UpdateMatrix()
    {
        for(int y=0; y< Matrix.column;++y)
        {
            for(int x=0; x < Matrix.row; ++x)
            {
                if(Matrix.grid[x, y] != null)
                {
                    if(Matrix.grid[x,y].parent == transform)
                    {
                        Matrix.grid[x, y] = null;
                    }
                }
            }
        }
        foreach(Transform child in transform)
        {
            Vector2 v = Matrix.RoundVector(child.position);
            Matrix.grid[(int)v.x, (int)v.y] = child;
        }
    }
}
