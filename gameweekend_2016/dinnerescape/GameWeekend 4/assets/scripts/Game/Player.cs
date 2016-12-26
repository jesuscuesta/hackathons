using UnityEngine;
using System.Collections;

/*
 * This is the player's base class, it holdes both input managment and health system.
 */
public class Player : IDestructible {

    public int currentLane;
    public GameObject[] LANE_ORIGINS;
    public Enemy onRange;
    
    public override void Start()
    {
        base.Start();
        MoveToLane(currentLane);
    }

    public int MoveLaneUp()
    {
        if(currentLane > 0)
        {
            currentLane--;
            MoveToLane(currentLane);
        }
        return currentLane;
    }
    public void MoveToLane(int lane)
    {
        Debug.Log("Changin to lane: " + (lane));
        this.currentLane = lane;
        this.transform.position = LANE_ORIGINS[lane].transform.position;
    }
    public int MoveLaneDown()
    {
        if (currentLane < LANE_ORIGINS.Length - 1)
        {
            currentLane++;
            MoveToLane(currentLane);
        }
        return currentLane;
    }

    private new void OnKilled(GameObject killer)
    {
        Time.timeScale = 0;
    }

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            MoveLaneDown();
        };
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            MoveLaneUp();
        };
    }

    public void Attack()
    {
        if(onRange != null)
        {
            onRange.Damage(transform.gameObject, 1);
            //playAttack
        } else {
            //playAttack
        }
    }

    public void OnRange(Enemy onRange)
    {
        this.onRange = onRange;
    }
}
