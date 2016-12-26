using UnityEngine;
using System.Collections;

public class GeneratePlane : MonoBehaviour {

    // Use this for initialization+
    public GameObject PlaneA;
    public GameObject PlaneB;
    public GameObject PlaneC;
    public GameObject PlaneD;
    GameObject[] planes = new GameObject[4];

    void Start()
    {
        planes[0] = PlaneA;
        planes[1] = PlaneB;
        planes[2] = PlaneC;
        planes[3] = PlaneD;

    }


    void OnTriggerEnter(Collider col)
    {
        //print(planes.Length);
        
        if (col.GetType().Equals("Cube"))
        {
            Destroy(col.gameObject);
        }else
        {
            GameObject newPlane;
            Destroy(col.transform.parent.gameObject);

            int index = Random.Range(0, planes.Length);
            newPlane = Instantiate(planes[index]);


            changeNames(newPlane);


            Vector3 temp = new Vector3(30, 0, 0);
            newPlane.transform.position = GameObject.Find("CentralPlane").transform.position;
            newPlane.transform.position += temp;
        }
        



    }

    void changeNames(GameObject newPlane)
    {
        GameObject.Find("CentralPlane").name = "LeftPlane";
        GameObject.Find("RightPlane").name = "CentralPlane";
        newPlane.name = "RightPlane";
    }

}
