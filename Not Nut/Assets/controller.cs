using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{
    Rigidbody rb;
    Vector3 mouse;
    bool ready = true;
    bool pressing = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 position = Input.mousePosition.normalized * 5f;
        //gameObject.transform.position = position;
        if (ready && !pressing)
        {
            if (Input.GetMouseButtonDown(0))
            {
                UseHammer();
            }
        }
       
        else if(!ready && pressing && !Input.GetMouseButtonUp(0))
        {
            gameObject.transform.Rotate(-45f, 0f, 0f, Space.World);
            ready = true;
            pressing = false;
        }
    }
    void UseHammer()
    {
        gameObject.transform.Rotate(45f, 0f, 0f, Space.World);
        ready = false;
        pressing = true;
    }
    void ResetHammer()
    {
        gameObject.transform.Rotate(-45f, 0f, 0f, Space.World);
        ready = true;
        pressing = false;
    }
}
