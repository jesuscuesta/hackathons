using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Collider))]
public abstract class ICollisionable : ExMono {

    private Collider pCollider;

    //Abstract implementation of collision
    public virtual void OnCollision(Vector3 point, GameObject self, GameObject collidedObj)
    {

    }

	// Use this for initialization
	void Start () {
        pCollider = this.GetComponent<Collider>();
	}
	
    void OnCollisionEnter(Collision collision)
    {
        OnCollision(collision.contacts[0].point ,this.gameObject, collision.collider.gameObject);
    }

	// Update is called once per frame
	void Update () {
	
	}
}
