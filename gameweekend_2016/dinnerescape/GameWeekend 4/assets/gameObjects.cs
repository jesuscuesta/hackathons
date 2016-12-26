using UnityEngine;
using System.Collections;

public class gameObjects : MonoBehaviour {
    public static float speedBackground;
    public float GameSpeed;
    public float speed
    {
        get
        {
            return speedBackground;
        }
        set
        {
            speedBackground = value;
        }
    }
    GameObject[] planes;
    // Use this for initialization
    void Start () {
        speed = GameSpeed;
    }
	
	// Update is called once per frame
	void Update () {
        planes = GameObject.FindGameObjectsWithTag("Plane");
        foreach(GameObject plane in planes)
            plane.transform.Translate((-1)*speedBackground * Time.deltaTime, 0f, 0f);
    }
}
