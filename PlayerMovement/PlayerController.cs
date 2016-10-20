using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {



	public float moveSpeed;
	private float moveSpeedStore;
	public float speedMultiplier;

	public float speedIncreaseMilestone;
	private float speedIncreaseMilestoneStore;

	private float speedMilestoneCount;
	private float speedMilestoneCountStore;

	private Rigidbody rb;

	public GameManager theGameManager;
    public JointOrientation myo;



	void Start()
	{
	    rb = GetComponent<Rigidbody> ();
		speedMilestoneCount = speedIncreaseMilestone;

		moveSpeedStore = moveSpeed;
		speedIncreaseMilestoneStore = speedIncreaseMilestone;
		speedMilestoneCountStore = speedMilestoneCount;

        myo = GetComponent<JointOrientation>();
	}
	void Update()
	{
		if (transform.position.z > speedMilestoneCount)
		{
			speedMilestoneCount += speedIncreaseMilestone;
			speedIncreaseMilestone = speedIncreaseMilestone * speedMultiplier;
			moveSpeed = moveSpeed * speedMultiplier;
		}

		rb.velocity = new Vector3 (rb.velocity.x, rb.velocity.y, moveSpeed);
        //if (myo.transform.forward.x > 5)
        //{
        //    //transform.Translate(5f * Time.deltaTime, 0, 0);
        //    rb.velocity = new Vector3(moveSpeed, rb.velocity.y, rb.velocity.z);
        //}
        //else if (myo.transform.forward.x < -3)
        //{
        //    // transform.Translate(-5f * Time.deltaTime, 0, 0);
        //    rb.velocity = new Vector3(-moveSpeed, rb.velocity.y, rb.velocity.z);
        //}

    }

	void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.tag == "Props") 
		{
			theGameManager.RestartGame ();
			moveSpeed = moveSpeedStore;
			speedIncreaseMilestone = speedIncreaseMilestoneStore;
			speedMilestoneCount = speedMilestoneCountStore;
		}
	}
}


