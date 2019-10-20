using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QUIT : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	void Quit() {
		#if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
		#elif UNITY_STANDALONE
		UnityEngine.Application.Quit();
		#endif
	}
	private void OnTriggerEnter(Collider collision)// 物体がトリガーに接触しとき、１度だけ呼ばれる
	{
		Quit();
	}


	// Update is called once per frame
	void Update () {
		
	}
}
