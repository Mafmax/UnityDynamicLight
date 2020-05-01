using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCamera : MonoBehaviour
{
    private Vector3 tempVector=new Vector3();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tempVector = Camera.main.ScreenPointToRay(Input.mousePosition).origin;
        tempVector.z = 1;
        this.transform.position =tempVector;
    }
}
