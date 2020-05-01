using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sun : MonoBehaviour
{
    private Vector3 temp=new Vector3();
    private Vector3 temp2=new Vector3();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        temp.y += 4*Time.deltaTime;
        temp2 = this.transform.position;
        temp2.z = -10;
       this.transform.eulerAngles = temp;
       this.transform.position = temp2;
    }
}
