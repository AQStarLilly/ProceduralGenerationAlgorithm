using UnityEditorInternal;
using UnityEngine;
using UnityEngine.InputSystem.Android;

public class RandomWalkGenerator : MonoBehaviour
{
    public int width = 50;
    public int height = 23;
    public int steps = 500;

    public GameObject floorPrefab;
    public GameObject wallPrefab;

    public bool[,] grid;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        grid = new bool[width, height];
        GenerateLevel();
        DrawLevel();
    }

    void GenerateLevel()
    {
        int x = width / 2;
        int y = height / 2;

        grid[x, y] = true;

        for(int i = 0; i < steps; i++)
        {
            int dir = Random.Range(0, 4);

            if (dir == 0 && x > 0) x--;
            else if (dir == 1 && x < width - 1) x++;
            else if (dir == 2 && y > 0) y--;
            else if (dir == 3 && y < height - 1) y++;

            grid[x, y] = true;

        }
    }
    
    void DrawLevel()
    {
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                Vector3 pos = new Vector3(x, y, 0);
                if (grid[x, y])
                {
                    Instantiate(floorPrefab, pos, Quaternion.identity);
                }
                else
                {
                    Instantiate(wallPrefab, pos, Quaternion.identity);
                }
            }
        }
    }
}
