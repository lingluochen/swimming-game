using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwimmerMove : MonoBehaviour
{
    public bool TopRow;
    public bool BotRow;
    public float speed = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(1.0f, 5.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (BotRow)
        {
            transform.position += transform.right * speed * Time.deltaTime;
        }

        else if (TopRow) {
            transform.position += transform.right * -speed * Time.deltaTime;
        }
    }
}
