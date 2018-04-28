using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject obj;
    public float spawnMin = 3f; //0.2f; //1f;
    public float spawnMax = 3f; //0.5f; //2f

	// Use this for initialization
	void Start () {
        Spawn();
	}
	
	//// Update is called once per frame
	//void Update () {
		
	//}

    void Spawn()
    {
        //randomly creates the objects; small, medium, and large ground
        //Instantiate(obj[Random.Range(0, obj.GetLength(0))], transform.position, Quaternion.identity);
        Instantiate(obj, transform.position, Quaternion.identity);

        //randomly spawns these objects every 3 seconds
        Invoke("Spawn", Random.Range(spawnMin, spawnMax));
    }
}
