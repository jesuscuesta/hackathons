using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateObjects : MonoBehaviour {

	public GameObject pos1;
	public GameObject pos2;
	public GameObject pos3;
	public GameObject pos4;
	public GameObject pos5;
	public GameObject pos6;
	public GameObject pos7;
	public GameObject pos8;
	public GameObject pos9;

    public GameObject enemyType;

    public int quantity;
	int position;

	// Use this for initialization
	void Start () {
		GenerateObjectsScene (null);
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void GenerateObjectsScene(GameObject g){
		

		var numEnemies = Random.Range (1,quantity);
		//print ("Num enemies "+ numEnemies);


		for (int i = 0; i < numEnemies; i++)
		{
			
			position = Random.Range (1,10);

            GameObject obj = Instantiate(enemyType);

			switch (position) {
			case 1:
                    obj.transform.position = pos1.transform.position;
                    obj.transform.parent = transform;
				break;
			case 2:
                    obj.transform.position = pos2.transform.position;
                    obj.transform.parent = transform;
				break;
			case 3:
                    obj.transform.position = pos3.transform.position;
                    obj.transform.parent = transform;
				break;
			case 4:

                    obj.transform.position = pos4.transform.position;
                    obj.transform.parent = transform;
				break;
			case 5:
                    obj.transform.position = pos5.transform.position;
                    obj.transform.parent = transform;
				break;
			case 6:
                    obj.transform.position = pos6.transform.position;
                    obj.transform.parent = transform;
				break;
			case 7:
                    obj.transform.position = pos7.transform.position;
                    obj.transform.parent = transform;
				break;
			case 8:
                    obj.transform.position = pos8.transform.position;
                    obj.transform.parent = transform;
				break;
			case 9:
                    obj.transform.position = pos9.transform.position;
                    obj.transform.parent = transform;
				break;
			}
				
		
		}
	}
}