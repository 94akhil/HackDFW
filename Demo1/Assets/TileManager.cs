using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    public GameObject[] tilePrefabs;
    public float zSpawn = 0;
    public float tileLength = 30;
    public float numOftiles = 100;
    public float zpos;
   
    
    public Transform playerTransform;
    // Start is called before the first frame update
    void Start()
    {

        // SpawnTile(0);
        // // SpawnTile(Random.Range(0,tilePrefabs.Length));
        // for(int i=0;i<numOftiles;i++){
        //     SpawnTile(Random.Range(0,tilePrefabs.Length));
            
        // }

        // while(zpos != target){
            // SpawnTile(Random.Range(0,tilePrefabs.Length));
        // }

        // SpawnTile(6);
    }

    // Update is called once per frame
    void Update()
    {
        
    //  if(playerTransform.position.z < (tileCount * tileLength)/2)   {
    //     SpawnTile(Random.Range(0,tilePrefabs.Length));
    //  }

        // if(zpos != target){
        //     SpawnTile(Random.Range(0,tilePrefabs.Length));
            
        // }
        // zpos=playerTransform.position.z;
     
    }

    // public void SpawnTile(int tileIndex = 0){
    //     Instantiate(tilePrefabs[tileIndex],transform.forward * zSpawn, transform.rotation);
    //     zSpawn += tileLength;

    // }
}
