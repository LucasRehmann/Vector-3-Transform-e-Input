using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPosition : MonoBehaviour
{
    public Vector3 newPosition;
    public GameObject myCube;
    // Start is called before the first frame update
    void Start()
    {
        myCube.transform.position = newPosition;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
