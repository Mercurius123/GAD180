using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minion : MonoBehaviour
{
    public GameObject turret;
    public float speed = 5;



   private void Start()
   {
        turret = GameObject.Find("Turret");


   }

    
    void Update()
    {
       
        transform.LookAt(turret.transform.position);


        transform.position += transform.forward * Time.deltaTime * speed;
    }
}
