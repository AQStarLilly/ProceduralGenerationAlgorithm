using UnityEditorInternal;
using UnityEngine;
using UnityEngine.InputSystem.Android;

public class RandomWalkGenerator : MonoBehaviour
{
    public int width = 50;
    public int height = 50;
    public int steps = 150;

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

    }
    
    void DrawLevel()
    {

    }
}
