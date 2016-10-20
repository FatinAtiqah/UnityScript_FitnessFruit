using UnityEngine;
using System.Collections;

public class MapDestroy : MonoBehaviour {

	public GameObject mapRemovePrefab;
	// Use this for initialization
	void Start () 
	{
		mapRemovePrefab = GameObject.Find ("MapDestroyPoint");
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (transform.position.z < mapRemovePrefab.transform.position.z) 
		{
			gameObject.SetActive (false);
		}
	}
}
