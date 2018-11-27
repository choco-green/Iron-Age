using System;
using System.Runtime.InteropServices;
using UnityEngine;

public class WorldGenerator : MonoBehaviour
{
    //Radius around player
    public int Radius;
    
    public GameObject Player;
    public GameObject Grass;
    public GameObject Floor;

    private void Start()
    {
        for (int z = -Radius; z <= Radius; z++)
        {
            for (int x = -Radius; x <= Radius; x++)
            {
                var floor = Instantiate(Grass, new Vector3(x, 0, z), Quaternion.Euler(90, 0, 0));
                floor.transform.parent = Floor.transform;
            }
        }
        
    }
}