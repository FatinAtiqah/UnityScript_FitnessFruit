using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class DeathMenu : MonoBehaviour {


	public AudioSource sfx;
	public void RestartGame()
	{
		
		StartCoroutine ("WaitSound");
	}

	public void QuitToMain()
	{
		sfx.Play ();
		SceneManager.LoadScene ("MainMenu");
	}

	IEnumerator WaitSound()
	{
		sfx.Play ();
		yield return new WaitForSeconds (0.5f);
		FindObjectOfType<GameManager>().Reset ();

	}
}
