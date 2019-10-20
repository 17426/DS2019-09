using UnityEngine;
using System.Collections;
using System.IO;

public class savespeedScript : MonoBehaviour {

    public int i;
    public float savespeed;
    public string x;
    public GameObject car;
    private Rigidbody _rigidbody;
    public string data;
    public string datam;

    public void textSave(string txt)
    {
        StreamWriter sw = new StreamWriter("logu.txt", true); //true=追記 false=上書き
        sw.WriteLine(txt);
        sw.Flush();
        sw.Close();
    }

    // Use this for initialization
    void Start () {
        car = GameObject.Find("Car");
        _rigidbody = car.GetComponent<Rigidbody>();
        i = 0;
	}

    void OnTriggerEnter(Collider collider) {
        //ここに速度を保存するプログラム

        savespeed = _rigidbody.velocity.magnitude;
        savespeed *= 3.6f;
        data = System.DateTime.Now.ToString();
        datam= System.DateTime.Now.Millisecond.ToString();
        i++;
        x =i+" "+data+" " +datam+ " " + savespeed.ToString();

        textSave(x);
        


    }
}
