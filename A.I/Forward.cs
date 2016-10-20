using UnityEngine;
using System.Collections;

public class Forward : MonoBehaviour {
    private Vector3 prevPos;

	// Use this for initialization
	void Start () {
        prevPos = transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        Vector3 dir = prevPos - transform.position;
        transform.forward= dir;
        prevPos = transform.position;
	}
}
