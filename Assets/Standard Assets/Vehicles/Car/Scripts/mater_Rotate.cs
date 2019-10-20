using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class mater_Rotate : MonoBehaviour {

	[SerializeField] GameObject CarObj;
	//[SerializeField] private CarController anotherScript;

	public float car_spead;
	public float car_speed_before = 0;
	public float car_speed_delta;

	//private Rigidbody c_Rigidbody = CarObj.GetComponent<Rigidbody>(); 


	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {

		//car_spead = Car.m_Rigidbody.velocity.magnitude; //m_Rigidbody.velocity.magnitude
		//car_spead = CarController.CurrentSpeed;

		car_spead = CarObj.GetComponent<Rigidbody>().velocity.magnitude*2.23693629f;
		car_speed_delta = car_spead - car_speed_before;
		transform.Rotate(new Vector3(0, car_speed_delta, 0) * 1.5f, Space.Self);
		car_speed_before = car_spead;
	}
}
