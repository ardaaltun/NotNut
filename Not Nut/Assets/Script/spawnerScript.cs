using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class spawnerScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject nut;
    public GameObject notNut;
    Transform pos;
    GameObject insted;
    
    private void Start()
    {
        pos = gameObject.GetComponent<Transform>();
        
        Spawner();
    }
    private void Update()
    {
        
        if (insted)
        {
            insted.transform.position += new Vector3(-1.6f, 0f, 0f) * Time.deltaTime;
            insted.transform.Rotate(0f, 0f, 200f * Time.deltaTime) ;
        }
        else
        {
            Spawner();
        }
        //print(insted.transform.position.x);
        if (insted.transform.position.x < -2.5f)
        {
            Destroy(insted);
            if(insted.tag == "nut")
            GameObject.FindGameObjectWithTag("collider").GetComponent<collision>().underZero++;
            //print(GameObject.FindGameObjectWithTag("collider").GetComponent<collision>().underZero);

        }
    }
    void Spawner()
    {
        int selection = Random.Range(0, 2);
        //print(selection);
        if(selection == 0)
        {
            insted = Instantiate(nut);
            insted.transform.position = pos.position;
        }
        else if (selection == 1)
        {
            insted = Instantiate(notNut);
            insted.transform.position = pos.position;
        }
            
        //nutInst.transform.position += new Vector3(10f, 0f, 0f) * Time.deltaTime;
    }
}
