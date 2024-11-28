using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShots : MonoBehaviour
{
    public Camera thirdPerson;
    public Camera outRange;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp("1"))
        {
            OutRange();
        }

        if (Input.GetKeyUp("2"))
        {
            ThirdPerson();
        }
    }

    public void OutRange()
    {
        outRange.enabled = true;
        thirdPerson.enabled = false;

    }

    public void ThirdPerson()
    {
        thirdPerson.enabled = true;
        outRange.enabled = false;

    }
}
