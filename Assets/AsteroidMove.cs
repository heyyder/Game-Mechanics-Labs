using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidMove : MonoBehaviour
{
    public int rotz;
    public int mx, my;
    private Rigidbody2D myRigid;
 
    void Start()
    {
      
        myRigid = this.GetComponent<Rigidbody2D>();

        this.transform.Rotate(new Vector3(0, 0, rotz));

        myRigid.AddForce(Vector3.up * mx);
        myRigid.AddForce(Vector3.right * mx);

    }

    // Update is called once per frame
    void Update()
    {
    }

}
