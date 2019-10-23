using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {

        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); 
        if(Physics.Raycast(ray, out hit, 100))
        {
            transform.LookAt(hit.transform.position);
            transform.LookAt(new Vector3(hit.point.x, 0, hit.point.z));
        }

    }
}
