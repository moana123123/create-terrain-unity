using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using UnityEngine;

public class TerrainManager : MonoBehaviour
{
    public GameObject[] terrainObj;
    int index = 0;
    GameObject[] terrain = new GameObject[5];
    // Start is called before the first frame update
    void Start()
    {
        
        terrain[index] = Instantiate(terrainObj[0], transform.position, Quaternion.identity);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClickNext()
    {
        if(index < terrainObj.Length-1)
        {
            index++;
            print(index);
            terrain[index] = Instantiate(terrainObj[index], transform.position, Quaternion.identity);
            Destroy(terrain[index-1]);
        }
        else
        {
            index = 0;
            terrain[index] = Instantiate(terrainObj[index], transform.position, Quaternion.identity);
            Destroy(terrain[4]);
        }
    }
}
