using UnityEngine;
using System.Collections;

public class ChangePosition : MonoBehaviour {
 
	// Use this for initialization
	void Start ()
    {
        
    }
	
	// Update is called once per frame
	void Update () {
        float posX = transform.position.x;
        float posY = transform.position.y;
        float posZ = transform.position.z;
        if (Input.GetKeyDown("up") && transform.position.z<10)
        {
            posZ = transform.position.z + 10;
            transform.position=new Vector3(posX, posY, posZ);
        }else if (Input.GetKeyDown("down") && transform.position.z>-10)
        {
            posZ = transform.position.z - 10;
            transform.position = new Vector3(posX, posY, posZ);
        }
    }
}
