using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenWrap : MonoBehaviour
{
    public bool TopRow;
    public bool BotRow;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x >= 7 && BotRow) {
            transform.position = new Vector3(-6.5757f, transform.position.y, transform.position.z);
        }

        else if (transform.position.x <= -6.5757f && TopRow)
        {
            transform.position = new Vector3(7, transform.position.y, transform.position.z);
        }
        Debug.Log("moving");
        Debug.Log(transform.position.x);
    }
}
