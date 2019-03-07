using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bluetooth : MonoBehaviour {

	public TextMesh Notify;
	public UnityEngine.UI.Text UI;
	// Use this for initialization
	void Start () {
		Notify = GameObject.Find("Text2").GetComponent<TextMesh>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.A))
		{
			Notify.text = "Aaa";
			Debug.Log("반간습니다.");
			UI.text = "반간습니다.";
		}else if(Input.GetKeyDown(KeyCode.L))
		{
			Notify.text = "Aaa";
			Debug.Log("안녕하세요.");
			UI.text = "안녕하세요.";
		}
	}
}
