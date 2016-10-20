using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public PlayerController player;

	private Vector3 lastPlayerPosition;

	private float distanceToMoveForward;

	// Use this for initialization
	void Start ()
	{
		player = FindObjectOfType<PlayerController>();
		lastPlayerPosition = player.transform.position;
	}
	
	// Update is called once per frame
	void Update () 
	{
		distanceToMoveForward = player.transform.position.z - lastPlayerPosition.z;

        transform.position = new Vector3(transform.position.x, transform.position.y, (transform.position.z + distanceToMoveForward));
        lastPlayerPosition = player.transform.position;
	}
}
