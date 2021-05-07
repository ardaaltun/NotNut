using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{
    Rigidbody rb;
    public Animator anim;
    Vector3 mouse;
    //bool ready = true;
    //bool pressing = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        //anim = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        //Vector3 position = Input.mousePosition.normalized * 5f;
        //gameObject.transform.position = position;
        /*
        if (ready && !pressing)
        {
            if (!pauseMenu.paused && Input.GetMouseButtonDown(0))
            {
                UseHammer();
            }
        }
       
        else if(!pauseMenu.paused && !ready && pressing && !Input.GetMouseButtonUp(0))
        {
            gameObject.transform.Rotate(-45f, 0f, 0f, Space.World);
            ready = true;
            pressing = false;
        }
        */
        
        if (!pauseMenu.paused && Input.GetMouseButtonDown(0))
        {
            UseHammer();
        }
        else
        {
            ResetHammer();
        }
        
    }
    void UseHammer()
    {

        anim.SetBool("clicked", true);
        
       /*
        gameObject.transform.Rotate(45f, 0f, 0f, Space.World);
        ready = false;
        pressing = true;
        */
    }
    void ResetHammer()
    {
        anim.SetBool("clicked", false);
        /*
        gameObject.transform.Rotate(-45f, 0f, 0f, Space.World);
        ready = true;
        pressing = false;
        */
    }
}
