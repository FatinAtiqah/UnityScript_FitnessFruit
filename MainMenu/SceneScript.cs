using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneScript : MonoBehaviour {

    public Canvas creditCanvas;
    public Canvas instCanvas;

    void Start()
    {
        creditCanvas.enabled = false;
        instCanvas.enabled = false;
    }
    public void startMenu()
    {
        creditCanvas.enabled = false;
        instCanvas.enabled = false;
        SceneManager.LoadScene("GamePlay");

    }
    public void exitMenu()
    {
        creditCanvas.enabled = false;
        instCanvas.enabled = false;
        Application.Quit();

    }
    public void creditMenu()
    {
        creditCanvas.enabled = true;
        instCanvas.enabled = false;
    }
    public void instMenu()
    {
        creditCanvas.enabled = false;
        instCanvas.enabled = true;
    }

}
