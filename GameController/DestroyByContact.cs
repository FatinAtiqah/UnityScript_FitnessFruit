using UnityEngine;
using System.Collections;

public class DestroyByContact : MonoBehaviour {

    public GameObject brokenPrefab;


    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            Instantiate(brokenPrefab, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
