using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    public float xSpeed;
    public bool toRight;

    public GameObject prefab1;
    public GameObject prefab2;

    public GameObject baseDer;
    public GameObject baseIzq;
    // Start is called before the first frame update
    void Start()
    {
        toRight = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (toRight == true)
        {
            transform.position += new Vector3(xSpeed, 0, 0);
        }

        else
        {
            transform.position -= new Vector3(xSpeed, 0, 0);
        }


        if (transform.position.x > 3)
        {
            toRight = false;

            GameObject clon;
            clon = Instantiate(prefab1);
            clon.transform.position = baseDer.transform.position + new Vector3(0, 1, 0);
        }

        if(transform.position.x < -4)
        {
            toRight = true;

            GameObject clon;
            clon = Instantiate(prefab2);
            clon.transform.position = baseIzq.transform.position + Vector3.up;
        }
    }
}
