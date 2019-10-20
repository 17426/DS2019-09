using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using UnityStandardAssets.CrossPlatformInput;


public class Speed_LOG2 : MonoBehaviour {

	[SerializeField] GameObject CarObj;
	public float car_spead_f;
	public string car_spead_log;

	public float count_f = 0f;
	public string count_log;

    public float pedal_f;
    public string pedal_log;

    public float brake_f;
    public string brake_log;

    public string day_log;

    public void textSave(string day,string count,string txt,string pedal,string brake){
		StreamWriter sw = new StreamWriter("../2019DSLogData.txt",true); //true=追記 false=上書き
		sw.WriteLine(day + "          " + count + "          " + txt + "          " + pedal + "          " + brake);
		sw.Flush();
		sw.Close();
	}

	void Start () {
        day_log = DateTime.Now.ToString("yyyy年MM月dd日hh時mm分ss秒");
        textSave (day_log,"0", "開始","0","0");
	}

	private void OnTriggerEnter(Collider collision)// 物体がトリガーに接触しとき、１度だけ呼ばれる
	{
		Debug.Log("Hit"); // OK
		car_spead_f = CarObj.GetComponent<Rigidbody> ().velocity.magnitude * 2.23693629f;
		car_spead_log = (car_spead_f).ToString ();

		count_log = (count_f).ToString ();

        pedal_f = CrossPlatformInputManager.GetAxis("Vertical");
        pedal_log = (pedal_f).ToString();

        brake_f = CrossPlatformInputManager.GetAxis("Jump");
        brake_log = (brake_f).ToString();

        day_log = DateTime.Now.ToString("hh時mm分ss秒");

        textSave(day_log, count_log, car_spead_log, pedal_log, brake_log);

		count_f += 1;

	}

}
