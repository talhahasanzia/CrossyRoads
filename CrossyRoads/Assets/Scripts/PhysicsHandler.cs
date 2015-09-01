using UnityEngine;
using System.Collections;

public class PhysicsHandler : MonoBehaviour {


    Rigidbody rb;
	// Use this for initialization
	void Start () {


        rb = GetComponent<Rigidbody>();
        rb.isKinematic = true;
        rb.detectCollisions = true;

	}
	
	// Update is called once per frame
	void Update () {
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;





	}

    public void OnCollisionEnter(Collision collision)
    {
        

    }

   

    

}
