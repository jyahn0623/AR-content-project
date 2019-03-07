using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BluetoothPlugin : MonoBehaviour {

	 public UnityEngine.UI.Text UI; // GUI 통제하기 위한 선언
	 public UnityEngine.Video.VideoPlayer v_Player; // 비디오 재생과 정지를 위한 선언
	 private int num=0; // Index를 위한 변수 선언

	// Use this for initialization
	void Start () {
		v_Player = GameObject.Find("VideoPlyer").GetComponent<UnityEngine.Video.VideoPlayer>();
	}
	
	// Update is called once per frame
	void Update () {
		var v_Player = GameObject.Find("VideoPlyer").GetComponent<UnityEngine.Video.VideoPlayer>();
		// 블루투스로 입력 되는 값에 따른 분기
		if(Input.GetKeyDown(KeyCode.O)) 
		{
			num = 1;
			UI.text = "Video ON";
			GameObject.Find("ButtonSetObject").GetComponent<ButtonControl2>().isVideo = true;
			PlayVideo();
		}else if(Input.GetKeyDown(KeyCode.F)){
			num = 0;
			UI.text = "Video OFF";
			GameObject.Find("ButtonSetObject").GetComponent<ButtonControl2>().isVideo = false;
			v_Player.Stop();
		}else if(Input.GetKeyDown(KeyCode.N)){
			
			if(num == 0 || num == 4)
			{
				UI.text = "Not Video";
			}else{
				if(num < 4)
				{
					num++;
					UI.text = "Next Video";
					PlayVideo();
				}
			}
		}else if(Input.GetKeyDown(KeyCode.P)){
			if(num == 0)
			{
				UI.text = "Not Video";
			}else
			{
				num--;
				UI.text = "Prev Video";
				PlayVideo();
			}
		}else if(Input.GetKeyDown(KeyCode.T)){
			if(GameObject.Find("ButtonSetObject").GetComponent<ButtonControl>().isPiano)
			{
				UI.text = "Piano OFF";
				GameObject.Find("ButtonSetObject").GetComponent<ButtonControl>().isPiano = false;
			}else{
				UI.text = "Piano ON";
				GameObject.Find("ButtonSetObject").GetComponent<ButtonControl>().isPiano = true;
			}
		}

		
		
	}

	// 영상 재생 함수
	void PlayVideo()
	{
		// ButtonSetObject의 오브젝트를 찾아 해당 오브젝트의 PlayVideo함수를 실행한다. 두 가지 인자를 전달한다.
		GameObject.Find("ButtonSetObject").GetComponent<ButtonControl2>().PlayVideo( 
			GameObject.Find("ButtonSetObject").GetComponent<ButtonControl2>().isVideo, num
		);
	}
}
