using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SpinPropellorX : MonoBehaviour
{
    public float rotationSpeed = 1200.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {// we rotate the propeler on its z axsis based on its self(current center location)
        transform.Rotate(0f,0f, rotationSpeed * Time.deltaTime, Space.Self);
    }
}
