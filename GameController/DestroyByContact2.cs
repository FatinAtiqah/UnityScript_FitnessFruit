using UnityEngine;
using System.Collections;

public class DestroyByContact2 : MonoBehaviour
{
    public PlayerHealth health;

    public void start()
    {
        health = GetComponent<PlayerHealth>();
    }
    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Innocent")
        {
            print("hit");
            health.decreaseHealth() ;
            Destroy(other.gameObject);
        }


    }
}
