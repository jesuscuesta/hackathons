using UnityEngine;
using System.Collections;

public class gameObjects : MonoBehaviour {
    public float speedBackground;
    GameObject[] planes;
    float timer,timercontroler;
    
    // Use this for initialization
    void Start () {
        timercontroler = 1;
	}
	
	// Update is called once per frame
	void Update () {
        planes = GameObject.FindGameObjectsWithTag("Plane");
        foreach(GameObject plane in planes)
        plane.transform.Translate((-1)*speedBackground * Time.deltaTime, 0f, 0f);
        timer = timercontroler*Time.realtimeSinceStartup;
        if ( timer > 30)//al pasar 30 segundos, aparece el boss
        {
            bossAppearance();
            timercontroler = 0;
        }
    }


    void bossAppearance()
    {
        print("WOP");
        
    }
}
