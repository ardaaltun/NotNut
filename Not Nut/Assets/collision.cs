using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collision : MonoBehaviour
{
    // Start is called before the first frame update
    public Text score;
    public int scoreInt = 0;

    
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
        }

        if (collision.gameObject.tag == "notNut")
        {
            //print("WRONG");
            Destroy(collision.gameObject);
            scoreInt--;
            
        }
    }
}
