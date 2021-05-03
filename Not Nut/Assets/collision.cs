using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class collision : MonoBehaviour
{
    // Start is called before the first frame update
    public Text score;
    public int scoreInt = 0;
    public RawImage heart1;
    public RawImage heart2;
    public RawImage heart3;
    int underZero = 0;
    private void Update()
    {
        score.text = scoreInt.ToString();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "nut")
        {
            //print("hit");
            Destroy(collision.gameObject);
            scoreInt++;
            EndMenu.finalScore++;
        }

        if (collision.gameObject.tag == "notNut")
        {
            //print("WRONG");
            Destroy(collision.gameObject);
            scoreInt--;

        }

        if(underZero == 0 && scoreInt < 0)
        {
            heart3.enabled = false;
            scoreInt = 0;
            underZero++;
        }

        else if(underZero == 1 && scoreInt < 0)
        {
            heart2.enabled = false;
            scoreInt = 0;
            underZero++;
        }
        else if (underZero == 2 && scoreInt < 0)
        {
            heart1.enabled = false;
            scoreInt = 0;
            underZero++;
        }


        if (underZero == 3)
        {
            SceneManager.LoadScene("EndMenu");
        }
    }
}
