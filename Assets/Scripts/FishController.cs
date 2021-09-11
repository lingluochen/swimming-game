using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishController : MonoBehaviour
{
    public float speed = 1f;
    public bool player1 = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player1)
        {
            if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(0, speed * Time.deltaTime, 0);
                //Debug.Log("up");
            }

            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(0, -speed * Time.deltaTime, 0);
                //Debug.Log("down");
            }
        }
        else
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.Translate(0, speed * Time.deltaTime, 0);
                //Debug.Log("up");
            }

            if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.Translate(0, -speed * Time.deltaTime, 0);
                //Debug.Log("down");
            }
        }
    }
}
