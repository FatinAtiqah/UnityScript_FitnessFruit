using UnityEngine;
using System.Collections;

public class PlayerAttached : MonoBehaviour {

    //public float Speed;
    //// Use this for initialization
    //void Start () {

    //}

    //// Update is called once per frame
    //void Update () {

    //}

    //void OnTriggerEnter (Collider obj)
    //{
    //	if (obj.gameObject.tag == "Player") 
    //	{
    //		transform.position = Vector3.MoveTowards(transform.position, obj.transform.position, Speed*Time.deltaTime);
    //	}
    //}

    //void OnTriggerStay (Collider obj)
    //{
    //	if (obj.gameObject.tag == "Player") 
    //	{
    //		transform.position = Vector3.MoveTowards(transform.position, obj.transform.position, Speed*Time.deltaTime);

    //		if (transform.position == obj.gameObject.transform.position)
    //		{
    //			Destroy (transform.gameObject);
    //		}
    //	}
    //}

    //void OnTriggerExit (Collider obj)
    //{
    //	if (obj.gameObject.tag == "Player") 
    //	{
    //		Destroy (transform.gameObject);
    //	}
    //}

    public Transform target;
    public float speed;
    void Update()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
    }
}
