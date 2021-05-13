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
    public int underZero = 0;
    public GameObject cracked;
    public GameObject crackedNotNUT;
    GameObject crackedOne;
    private void Start()
    {
        Physics.IgnoreLayerCollision(0, 1);
    }
    private void Update()
    {
        //print(underZero);
        score.text = scoreInt.ToString();

        if (underZero == 1)
        {
            heart3.enabled = false;
        }

        else if (underZero == 2)
        {
            heart2.enabled = false;
        }
        else if (underZero == 3)
        {
            heart1.enabled = false;
        }


        if (underZero == 3)
        {
            SceneManager.LoadScene("EndMenu");
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        Vector3 curretPos;
        
        if (collision.gameObject.tag == "nut")
        {
            curretPos = collision.gameObject.transform.position;
            Destroy(collision.gameObject);
            crackedOne = Instantiate(cracked);
            crackedOne.transform.position = curretPos;
            //print(curretPos + "    " + cracked.transform.position);
            scoreInt++;
            Destroy(crackedOne, 1f);
            EndMenu.finalScore++;
        }

        else if (collision.gameObject.tag == "notNut")
        {
            curretPos = collision.gameObject.transform.position;
            Destroy(collision.gameObject);
            crackedOne = Instantiate(crackedNotNUT);
            crackedOne.transform.position = curretPos;
            //print(curretPos + "    " + crackedNotNUT.transform.position);
            Destroy(crackedOne, 1f);
            scoreInt--;
        }
        
        if (underZero == 0 && scoreInt < 0)
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
        

        
    }
}
