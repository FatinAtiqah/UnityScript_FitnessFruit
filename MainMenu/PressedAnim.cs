using UnityEngine;
using System.Collections;

public class PressedAnim : MonoBehaviour {

    public Animation buttonPressed;
    // Use this for initialization
    void Start () {
        buttonPressed = GetComponent<Animation>();
        buttonPressed.Stop();

    }

    // Update is called once per frame
    public void OnCollisionEnter(Collision obj)
    {
        if (obj.gameObject.tag == "Player")
        {
            print("hit");
            buttonPressed.Play();

        }
    }
}
