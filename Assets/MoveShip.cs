using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveShip : MonoBehaviour
{
    public string left;
    public string right;
    public string up;
  
    

    Rigidbody2D myRigid;
    public ParticleSystem myPart;
  


    void Start()
    {
        
        myPart = GameObject.Find("Engine").GetComponent<ParticleSystem>();
        myRigid = this.GetComponent<Rigidbody2D>();
        
    }

    void Update()
    {
      

        if (Input.GetKey(left))
        {
            this.transform.Rotate(new Vector3(0f, 0f, 100f)
               * Time.deltaTime);
        }

        if (Input.GetKey(right))
        {
            this.transform.Rotate(new Vector3(0f, 0f,
                -100f) * Time.deltaTime);
        }

        
    }

    void FixedUpdate()
    {
        if (Input.GetKey(up))
        {
            if(!myPart.isPlaying)
                myPart.Play();

            myRigid.AddForce(this.transform.up * 50 * Time.deltaTime);
            
        }
        else
        {
            if(myPart.isPlaying)
                myPart.Stop();

        }

    }
}
