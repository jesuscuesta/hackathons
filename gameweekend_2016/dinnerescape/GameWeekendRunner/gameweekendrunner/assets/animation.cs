using UnityEngine;
using System.Collections;

public class animation : MonoBehaviour {
    bool attack=false;
    Animator anim;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("space"))
        {
            anim.SetBool("attack",true);
            
        }else
        {
            anim.SetBool("attack", false);
        }
        }
}
