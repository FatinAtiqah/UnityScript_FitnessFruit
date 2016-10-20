using UnityEngine;
using System.Collections;

public class DestroyByWall : MonoBehaviour
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
            print("Wall Destroy Innoncent");
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "Enemy")
        {
            print("Wall Destroy Enemy");
            health.decreaseHealth();
            Destroy(other.gameObject);
        }
    }
}
