using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour
{
    public static int finalScore = 0;
    public Text scoreUI;
    private void Start()
    {
        scoreUI.text = "Score: " + finalScore.ToString();
    }
    
    // Start is called before the first frame update
    public void PlayAgain()
    {
        SceneManager.LoadScene("Game");
        finalScore = 0;
    }
    public void Quit()
    {
        Application.Quit();
    }
}
