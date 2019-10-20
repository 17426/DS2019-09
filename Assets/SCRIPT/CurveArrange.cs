using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurveArrange : MonoBehaviour {

    public GameObject ArrangeObj;

    [SerializeField] private float r;
    [SerializeField] private float AngPer;
    [SerializeField] private float AngLeast;

	private float AngLeastR;
	private float AngPer_thisR; 

    private float x = 0;
    private float y = 0.001f;
    private float z = 0;

    //private float deg = 90.0f;//度
	private float deg = 30.0f;
	private float degR;
    private float rad_con;
    [SerializeField] private float rad = 0f;

    //private float distance =40f;//数
    private float i = 0f;

    void Start()
    {
		AngLeastR = AngLeast * Mathf.Deg2Rad;
		degR = deg * Mathf.Deg2Rad;
        //rad_con = deg * Mathf.Deg2Rad / distance;//ラジアン
        ArrangeObj.transform.position = new Vector3(x, y, z);
       // Instantiate(ArrangeObj, new Vector3(x, y, z), Quaternion.identity);
    }

    // Update is called once per frame
    void Update () {
        i = i + 1f;
        //if (i <= distance)
        
		if(rad < degR)
		{
            //rad = rad + rad_con;

            x = r * Mathf.Cos(rad);
            z = r * Mathf.Sin(rad);

            Instantiate(ArrangeObj, new Vector3(x, y, z), Quaternion.Euler(0f, 90f-rad * Mathf.Rad2Deg,0f));

			AngPer_thisR = 1f + (1f - AngPer) * (-rad) / degR;

			rad += AngLeastR * AngPer_thisR;


        }


    }
}
