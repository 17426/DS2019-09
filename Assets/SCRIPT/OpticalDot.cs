using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpticalDot : MonoBehaviour {

	public GameObject OPobj;

	private Vector3 posi;

	[SerializeField] private float size_per;
	[SerializeField] private float size_least; //最小半径 Scal x,z 0.1=1m
	private float size; //直径
	private float size_per_this;

	[SerializeField] private float wide_per; //最終間隔パーセント
	[SerializeField] private float wide_least; //最小間隔 
	private float wide; //間隔を挿入
	private float wide_per_this;
	private new Vector3 wide_total;

	[SerializeField] private float distance;
	[SerializeField] private float OP_num = 0;


	private float posi_zR = -6f; //r:-5.93 l:-9.25
    private float posi_zC = -7.5f;
	private float posi_zL = -9f;

	// Use this for initialization
	void Start () {
		wide = wide_least;
        size = size_least;

		OPobj.transform.localScale = new Vector3 (size_least * 3f, 0.1f, size_least);
		OPobj.transform.position = new Vector3 (0f, 0.001f, 0f);
		posi = OPobj.transform.position;

        Instantiate(OPobj, new Vector3(0f, 0.001f, posi_zL + size_least * 5f), Quaternion.identity);//左表示
       // Instantiate(OPobj, new Vector3(0f, 0.001f, posi_zC), Quaternion.identity);//中央表示
        Instantiate(OPobj, new Vector3(0f, 0.001f, posi_zR - size_least * 5f), Quaternion.identity);//右表示
	}

	// Update is called once per frame
	void Update () {

		wide_total = OPobj.transform.position;

		if( - wide_total.x <= distance)
		{
			size_per_this = size_per + (size_per -1f) * (- wide_total.x) / (distance);
			size = size_least * size_per_this;

			OPobj.transform.localScale = new Vector3 (size * 4f, 0.1f, size);

			OPobj.transform.position = new Vector3 (posi.x - wide, posi.y, posi_zL + size * 5f);
			Instantiate(OPobj,OPobj.transform.position,Quaternion.identity);//左表示
           // OPobj.transform.position = new Vector3(posi.x - wide, posi.y, posi_zC);
           // Instantiate(OPobj, OPobj.transform.position, Quaternion.identity);//中央表示
            OPobj.transform.position = new Vector3 (posi.x - wide, posi.y, posi_zR - size *5f);
			Instantiate(OPobj,OPobj.transform.position,Quaternion.identity);//右表示

			wide_total = OPobj.transform.position;

			OP_num += 1f;

			wide_per_this = 1f + (1f - wide_per) * (- wide_total.x) / (distance);

			wide += wide_least * wide_per_this; 

		}
	}
}
