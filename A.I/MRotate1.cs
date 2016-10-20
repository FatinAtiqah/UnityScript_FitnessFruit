using UnityEngine;
using System.Collections;

public class MRotate1 : MonoBehaviour {

    public float speedRotate;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, speedRotate);
    }

}
