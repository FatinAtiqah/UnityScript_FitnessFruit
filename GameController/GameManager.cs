using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public Transform mapGenerator;
	private Vector3 mapGeneratorStartPoint;

	public PlayerController thePlayer;
	private Vector3 thePlayerStartPoint;

	private MapDestroy[] mapList;

	public ScoreManager theScoreManager;

	//public DeathMenu deathScreen;

	public AudioSource Ahh;
	// Use this for initialization
	void Start () 
	{
		mapGeneratorStartPoint = mapGenerator.position;
		thePlayerStartPoint = thePlayer.transform.position;
		theScoreManager = FindObjectOfType<ScoreManager>();
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	
	}

	public void RestartGame()
	{
		theScoreManager.scoreIncreasing = false;
		thePlayer.gameObject.SetActive (false);

		Ahh.Play ();
		//deathScreen.gameObject.SetActive (true);
//		StartCoroutine ("Restart");
	}
	public void Reset()
	{
		//deathScreen.gameObject.SetActive (false);
		mapList = FindObjectsOfType<MapDestroy> ();
		for (int i = 0 ; i < mapList.Length; i++ )
		{
			mapList [i].gameObject.SetActive (false);
		}
		mapGenerator.position = mapGeneratorStartPoint;
		thePlayer.transform.position = thePlayerStartPoint;
		thePlayer.gameObject.SetActive (true);
		theScoreManager.scoreCount = 0;
		theScoreManager.scoreIncreasing = true;
	}

	/*public IEnumerator Restart()
	{
		theScoreManager.scoreIncreasing = false;
		thePlayer.gameObject.SetActive (false);
		yield return new WaitForSeconds(0.2f);
		mapList = FindObjectsOfType<MapDestroy> ();
		for (int i = 0 ; i < mapList.Length; i++ )
		{
			mapList [i].gameObject.SetActive (false);
		}
		mapGenerator.position = mapGeneratorStartPoint;
		thePlayer.transform.position = thePlayerStartPoint;
		thePlayer.gameObject.SetActive (true);
		theScoreManager.scoreCount = 0;
		theScoreManager.scoreIncreasing = true;
		
	}*/
}
