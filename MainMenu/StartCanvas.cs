using UnityEngine;
using System.Collections;

public class StartCanvas : MonoBehaviour {

    public Animation buttonPressed;

    public SceneScript pressed;

    //Use this for initialization
    void Start()
    {
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
            pressed.startMenu();
        }
    }
#if UNITY_EDITOR

    public void OnMouseDown()
    {
        buttonPressed.Play();
        pressed.startMenu();
    }
#endif

}
