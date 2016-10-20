using UnityEngine;
using System.Collections;

public class MRotate2 : MonoBehaviour {
    //Tomato
    public float speedMove;

    public float speedRotate;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {

        rb.velocity = new Vector3(0, 0, -speedMove);
        transform.Rotate(0, speedRotate, 0);
    }
}
