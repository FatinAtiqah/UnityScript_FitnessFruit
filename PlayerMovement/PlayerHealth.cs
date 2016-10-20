using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour {

    public float max_Health = 100f;
    public float curr_Health = 0f;
    public GameObject healthBar;

	// Use this for initialization
	public void Start ()
    {
        curr_Health = max_Health;

	}
	
	// Update is called once per frame
	void Update ()
    {  
        if (curr_Health <= 0)
        {
            SceneManager.LoadScene("MainMenu");
        }
	
	}

   public void decreaseHealth()
    {
        curr_Health -= 2;
        float calc_health = curr_Health / max_Health;
        SetHealthBar(calc_health);
    }

    public void SetHealthBar(float myHealth)
    {
        //myHealth value of 0 - 1
        healthBar.transform.localScale = new Vector3(myHealth, healthBar.transform.localScale.y, healthBar.transform.localScale.z);
    }


}