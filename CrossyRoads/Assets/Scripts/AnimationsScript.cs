using UnityEngine;
using System.Collections;

public class AnimationsScript : MonoBehaviour {


    Animator anim;
    public GameObject obj;

   
	// Use this for initialization
	void Start () {


        anim = gameObject.GetComponent<Animator>();
        
	}
	
	// Update is called once per frame
	void Update () {
        

        if (Bounce.Jump)
        {

            anim.SetBool("Jump", true);
            

        }
        else
        {

            anim.SetBool("Jump", false);
        
        
        }
	}
}
