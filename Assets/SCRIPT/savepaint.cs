using UnityEngine;
using System.Collections;
using System.IO;

public class savepaint : MonoBehaviour
{

    public string x="ペイント";

    public void textSave(string txt)
    {
        StreamWriter sw = new StreamWriter("logu.txt", true); //true=追記 false=上書き
        sw.WriteLine(txt);
        sw.Flush();
        sw.Close();
    }

    // Use this for initialization
    void Start()
    {

    }

    void OnTriggerEnter(Collider collider)
    {
        //ここに速度を保存するプログラム

        textSave(x);



    }
}
