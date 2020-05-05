using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TertrisBlock1 : MonoBehaviour
{
    public Vector3 rotationPoint;
    private float previousTime;
    public static float  fallTime = 1.0f;
    public static int height = 20;
    public static int width = 10;
    private static Transform[,] grid = new Transform[width,height];// tao loop cho cac khoi
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(-1, 0, 0);
            if (!Move())
                transform.position -= new Vector3(-1, 0, 0);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.position += new Vector3(1, 0, 0);
            if (!Move())
                transform.position -= new Vector3(1, 0, 0);
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.RotateAround(transform.TransformPoint(rotationPoint), new Vector3(0, 0, 1), 90);
            if (!Move())
                transform.RotateAround(transform.TransformPoint(rotationPoint), new Vector3(0, 0, 1), -90);
        }
        if (Time.time - previousTime > (Input.GetKey(KeyCode.DownArrow) ? fallTime / 10 : fallTime))
        {
            transform.position += new Vector3(0, -1, 0);
            if (!Move())
            {
                transform.position -= new Vector3(0, -1, 0);
                AddToGrid();
                CheckLine();

                if (!check())
                {
                   
                   GameOver();
                    

                }

                this.enabled = false;// tao loop cho cac khoi
                FindObjectOfType<SpawnTetromino>().NewTetromino();
                this.enabled = false;
                FindObjectOfType<Score>().UpdateScore();
                
                this.enabled = false;
                FindObjectOfType<Score>().UpdateUI();
                
                this.enabled = false;
                FindObjectOfType<Level>().UILevel();
                this.enabled = false;
                FindObjectOfType<Level>().UILine();
                this.enabled = false;
                FindObjectOfType<Level>().UpdateSpeed();
                



                // tao loop cho cac khoi

            }

            previousTime = Time.time;

        }

    }
   

   
    void AddToGrid()// tao loop cho cac khoi
    {
        foreach (Transform children in transform)
        {
            int roundedX = Mathf.RoundToInt(children.transform.position.x);
            int roundedY = Mathf.RoundToInt(children.transform.position.y);
            grid[roundedX, roundedY] = children;
        }
    }
    bool Move()
{
    
        foreach( Transform children in transform)
        {
            int roundedX = Mathf.RoundToInt(children.transform.position.x);
            int roundedY = Mathf.RoundToInt(children.transform.position.y);
            if (roundedX < 0 || roundedX >= width || roundedY <0 )
            {
                return false;
            }
            if (grid[roundedX, roundedY] != null)// tao loop cho cac khoi

                return false;
            
        }
        return true;
    }
void CheckLine()
{
    for (int y = 0; y < height; y++)
    {
        if (isRowFull(y))
        {
            deleteRow(y);
            decreaseRowAbove(y+1);
                --y;
           
        }
    }
}
public static void deleteRow(int y)
{
    for (int x = 0; x < width; x++)
    {
        Destroy(grid[x, y].gameObject);
        grid[x, y] = null;
    }
}
public static void decreaseRow(int y)
{
    for (int x = 0; x < width; x++)
    {
        if (grid[x, y] != null)
        {
            // move one twoards bottom
            grid[x, y - 1] = grid[x, y];
            grid[x, y] = null;

            // Update block position
            grid[x, y - 1].position += new Vector3(0, -1, 0);
        }
    }
}
public static void decreaseRowAbove(int y)
{
    for (int i = y; i < height; i++)
    {
        decreaseRow(i);
    }
}
public static bool isRowFull(int y)
{
    for (int x = 0; x < width; x++)
    {
        if (grid[x, y] == null)
        {
            return false;
        }
    }
        Score.numberOfRowThisTurn++;
    return true;

}
public bool check()
    {
        
            foreach(Transform children in transform)
            {
                int roundedX = Mathf.RoundToInt(children.transform.position.x);
                int roundedY = Mathf.RoundToInt(children.transform.position.y);
                if(roundedY > height-3)
                {
                    return false;
                }
            }
        
        return true;
    }
    public void GameOver()
    {
        Application.LoadLevel("GameOver");
    }
    
  
}
