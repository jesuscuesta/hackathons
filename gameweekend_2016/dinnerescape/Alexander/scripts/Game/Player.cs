using UnityEngine;
using System.Collections;

/*
 * This is the player's base class, it holdes both input managment and health system.
 */
public class Player : IDestructible {

    private new void OnKilled(GameObject killer)
    {

    }

    private GameObject gm;
	void Start () {
        gm = this.gameObject;
	}
}
