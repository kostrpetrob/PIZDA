using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationStateController: MonoBehaviour
{
    Animator animator;
    int begit;
    int taunt;

    // Start is called before the first frame update
    void Start()
    {
         animator = GetComponent<Animator>();
         begit = Animator.StringToHash("begit");
         taunt = Animator.StringToHash("taunt");
        
    }

    // Update is called once per frame
    void Update()
    {
	
      bool press = (Input.GetAxis("Horizontal") > 0.1) | (Input.GetAxis("Horizontal") < -0.1) | (Input.GetAxis("Vertical") > 0.1) | (Input.GetAxis("Vertical") < -0.1);
	bool taunt = Input.GetKey("t");
	
	if (press) 
    { 
          animator.SetBool("begit", true);
    }
       if (!press) 
    { 
          animator.SetBool("begit", false);
    } 
    if (taunt) 
    { 
          animator.SetBool("taunt", true);
    } 
	if (!taunt) 
    { 
          animator.SetBool("taunt", false);
    } 
    }
}
