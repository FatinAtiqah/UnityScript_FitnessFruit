using UnityEngine;
using System.Collections;

public class MapGenerator : MonoBehaviour
{
//	public GameObject theMap;
	public Transform generationPoint;
	public float distanceBetween;

//	private float platformWidth;
	// Use this for initialization

	private int mapSelector;

	public ObjectPool[] theObjectPools;

	void Start () 
	{
//		platformWidth = theMap.GetComponent<
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (transform.position.z < generationPoint.position.z) 
		{
			transform.position = new Vector3 (transform.position.x, -5.0f, (transform.position.z + distanceBetween));
			mapSelector = Random.Range (0, theObjectPools.Length);
//			Instantiate (theMap, transform.position, Quaternion.identity);

			GameObject newMap = theObjectPools [mapSelector].GetPooledObject ();

			newMap.transform.position = transform.position;
			newMap.transform.rotation = transform.rotation;
			newMap.SetActive (true);
		}

	}
}
