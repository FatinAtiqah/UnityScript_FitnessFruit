using UnityEngine;
using System.Collections;

public class DestroyEnemies : MonoBehaviour {


  void OnCollisionEnter(Collision obj)
    {
        if(obj.gameObject.tag == "Enemy")
        {
           // obj.gameObject.GetComponent<PlayerHealth>().decreaseHealth();
            Destroy(obj.gameObject);
        }
    }


}
