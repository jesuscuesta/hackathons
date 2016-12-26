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
		print ("Num enemies "+ numEnemies);


		for (int i = 0; i < numEnemies; i++)
		{
			
			position = Random.Range (1,10);



			switch (position) {
			case 1:
				GameObject cube = GameObject.CreatePrimitive (PrimitiveType.Cube);
				cube.transform.position = pos1.transform.position;
                cube.transform.parent = transform;
				break;
			case 2:
				GameObject cube2 = GameObject.CreatePrimitive (PrimitiveType.Cube);
				cube2.transform.position = pos2.transform.position;
                cube2.transform.parent = transform;
				break;
			case 3:
				GameObject cube3 = GameObject.CreatePrimitive (PrimitiveType.Cube);
				cube3.transform.position = pos3.transform.position;
                cube3.transform.parent = transform;
				break;
			case 4:
				GameObject cube4 = GameObject.CreatePrimitive (PrimitiveType.Cube);
				cube4.transform.position = pos4.transform.position;
                cube4.transform.parent = transform;
				break;
			case 5:
				GameObject cube5 = GameObject.CreatePrimitive (PrimitiveType.Cube);
				cube5.transform.position = pos5.transform.position;
                cube5.transform.parent = transform;
				break;
			case 6:
				GameObject cube6 = GameObject.CreatePrimitive (PrimitiveType.Cube);
				cube6.transform.position = pos6.transform.position;
                cube6.transform.parent = transform;
				break;
			case 7:
				GameObject cube7 = GameObject.CreatePrimitive (PrimitiveType.Cube);
				cube7.transform.position = pos7.transform.position;
                cube7.transform.parent = transform;
				break;
			case 8:
				GameObject cube8 = GameObject.CreatePrimitive (PrimitiveType.Cube);
				cube8.transform.position = pos8.transform.position;
                cube8.transform.parent = transform;
				break;
			case 9:
				GameObject cube9 = GameObject.CreatePrimitive (PrimitiveType.Cube);
				cube9.transform.position = pos9.transform.position;
                cube9.transform.parent = transform;
				break;
			}
				
		
		}
	}
}