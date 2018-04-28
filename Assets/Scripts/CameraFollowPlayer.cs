using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour {

    public Transform player;

	// Use this for initialization
	void Start ()
    {
        //transform.position = player.position;

    }
	
	// Update is called once per frame
	void Update ()
    {
        transform.position = new Vector3(player.position.x + (float)6.45, 0, -10); //8.45, 0, -10);
	}
}
