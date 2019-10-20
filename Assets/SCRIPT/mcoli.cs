using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mcoli : MonoBehaviour {

	public GameObject Wallobj;
	private float x_posi = 0;
	private Vector3 posi;

	// Use this for initialization
	void Start () {
		posi = Wallobj.transform.position;
	}
	
	// Update is called once per frame
	void Update () {

		if(x_posi <= 10000)
		{
			Wallobj.transform.position = new Vector3 (posi.x - x_posi, posi.y, posi.z);
			Instantiate(Wallobj,Wallobj.transform.position,Quaternion.identity);
			x_posi = x_posi + 1;
		}
	}
}
