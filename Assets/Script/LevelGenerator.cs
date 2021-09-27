using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;



public class LevelGenerator : MonoBehaviour
{
    public List<TileBase> allbase;

    public List<int> ids;
    public Tilemap map;
    // Start is called before the first frame update
    void Start()
    {
        InitIds();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void InitIds()
    {
        int[,] levelMap =
        {
           {1,2,2,2,2,2,2,2,2,2,2,2,2,7},
           {2,5,5,5,5,5,5,5,5,5,5,5,5,4},
           {2,5,3,4,4,3,5,3,4,4,4,3,5,4},
           {2,6,4,0,0,4,5,4,0,0,0,4,5,4},
           {2,5,3,4,4,3,5,3,4,4,4,3,5,3},
           {2,5,5,5,5,5,5,5,5,5,5,5,5,5},
           {2,5,3,4,4,3,5,3,3,5,3,4,4,4},
           { 2,5,3,4,4,3,5,4,4,5,3,4,4,3},
           {2,5,5,5,5,5,5,4,4,5,5,5,5,4},
           {1,2,2,2,2,1,5,4,3,4,4,3,0,4},
           {0,0,0,0,0,2,5,4,3,4,4,3,0,3},
           {0,0,0,0,0,2,5,4,4,0,0,0,0,0},
           {0,0,0,0,0,2,5,4,4,0,3,4,4,0},
           {2,2,2,2,2,1,5,3,3,0,4,0,0,0},
           {0,0,0,0,0,0,5,0,0,0,4,0,0,0},
        };
        int arrow = 15;
        int grid = 14;
        int[,] firstarray = new int[,]
        {
            {10,14,14,14,14,14,14,14,14,14,14,14,14,9}, 
            {2,11,11,11,11,11,11,11,11,11,11,11,11,1}, 
            {2,11,5,13,13,3,11,5,13,13,13,3,11,1}, 
            {2,12,1,0,0,1,11,1,0,0,0,1,11,1}, 
            {2,11,6,13,13,4,11,6,13,13,13,4,11,1}, 
            {2,11,11,11,11,11,11,11,11,11,11,11,11,11},
            {2,11,5,13,13,3,11,5,13,3,11,5,13,3}, 
            {2,11,6,13,13,4,11,1,0,1,11,6,13,4}, 
            {2,11,11,11,11,11,11,1,0,1,11,11,11,1}, 
            {8,14,14,14,14,9,11,1,0,0,13,13,3,1}, 
            {0,0,0,0,0,2,11,1,0,5,13,13,4,1}, 
            {0,0,0,0,0,2,11,1,0,1,0,0,0,0},
            {0,0,0,0,0,2,11,1,0,1,0,5,13,13},
            {14,14,14,14,14,7,11,6,13,4,0,1,0,0}, 
            {0,0,0,0,0,0,11,0,0,0,0,1,0,0}
        };
        //first quadrant
        TileBase[] tilearray = new TileBase[15 * 14];
        
        Vector3Int pos = Vector3Int.zero;
        Vector3Int[] poss = new Vector3Int[15 * 14];
        int count = 0;
        for (int i = 0; i < arrow; ++i)
        {
            for (int j = grid - 1; j >= 0; --j)
            {
                pos = new Vector3Int(j, -i, 0);
                tilearray[count] = allbase[firstarray[i, j]];
                poss[count] = pos;
                count++;
                Debug.Log(pos + "--" + firstarray[i, j]);
            }
        }
        map.SetTiles(poss, tilearray);
        map.RefreshAllTiles();
        Debug.Log("111");
    }
   
}
