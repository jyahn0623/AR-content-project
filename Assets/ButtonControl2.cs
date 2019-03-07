using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ButtonControl2 : MonoBehaviour, IVirtualButtonEventHandler {

 	public GameObject V_Button2;
    public UnityEngine.UI.Text UI;
    public bool isVideo = false;

	public UnityEngine.Video.VideoClip[] Vd_List;

	private int num=0;
	//public GameObject[] V_ButtonList;

	// Use this for initialization
	void Start () {
		V_Button2 = GameObject.Find("VideoMode");
		//V_Button2.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
		attachEventHandler();
	}

	void attachEventHandler()
	{
		V_Button2.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
		//for(int i=0; i<V_ButtonList.Length; i++){
		//	V_ButtonList[i].GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
		//}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnButtonPressed(VirtualButtonAbstractBehaviour vb)
    {
		var s_buttonName= vb.VirtualButtonName;
		/*
		if(s_buttonName == "Girls" && isVideo==true)
		{
			Debug.Log("Girls");
			num = 1;
		}else if(s_buttonName == "Animation" && isVideo==true){
			Debug.Log("Movie");
			num = 2;
		}else if(s_buttonName == "Grils" && isVideo==true){
			num = 3;
		}
		*/

		if(!isVideo && s_buttonName == "VideoMode")
		{
			isVideo = true;
			UI.text = "Video ON";
			Debug.Log("ON");

		}
		else if(isVideo && s_buttonName == "VideoMode")
		{
			isVideo = false;
			UI.text = "Video OFF";
			Debug.Log("OFF");
		}
		 

		//PlayVideo(isVideo, num);
    }

    public void OnButtonReleased(VirtualButtonAbstractBehaviour vb)
    {

    }

	public void PlayVideo(bool isVideo, int num)
	{
		var v_Player = GameObject.Find("VideoPlyer").GetComponent<UnityEngine.Video.VideoPlayer>();
		Debug.Log(num);
		if(num == 1){
			v_Player.clip = Vd_List[0];
		}else if(num == 2)
		{
			v_Player.clip = Vd_List[1];
		}else if(num == 3)
		{
			v_Player.clip = Vd_List[2];
		}

		if(isVideo)
		{
			Debug.Log("비디오 모드 실행");
			//attachEventHandlerDynamic();
			v_Player.Play();
		}else{
			v_Player.Stop();
		}
	}
}
