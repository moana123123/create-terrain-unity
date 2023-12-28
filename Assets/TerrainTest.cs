using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainTest : MonoBehaviour
{
    public Vector3 terrainArea;
    public float spinSpeed = 2.0f;
    public int cloneTeleportations;
    public GameObject prefab;

    private bool rotate = false;
    private bool exited = false;
    private Transform[] teleportations;
    // private static Random rnd = new Random();
    private float xMinimum, xMaximum, zMinimum, yMinimum, zMaximum;
    private void Start()
    {
        GameObject go = GameObject.Find("Terrain");            
        Terrain terrain = go.GetComponent<Terrain>();
        terrainArea = terrain.terrainData.size;
        print(terrainArea);
       xMinimum = transform.position.x;
        zMinimum = transform.position.z;
        xMaximum = xMinimum + terrainArea.x;
        zMaximum = zMinimum + terrainArea.z;

        for (int i = 0; i < cloneTeleportations; i++)
        {
            InstantiateGameObject();
        }
    }

    private void InstantiateGameObject()
    {
        GameObject newGameObject = Instantiate(prefab, 
            new Vector3(Random.Range(xMinimum, xMaximum), -40, 
            Random.Range(zMinimum, zMaximum)), Quaternion.identity);

        newGameObject.transform.parent = this.transform;
        newGameObject.transform.tag = "Teleportation";
    }
     
}
