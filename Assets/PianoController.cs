using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class PianoController : MonoBehaviour, IVirtualButtonEventHandler {

	public GameObject[] V_Button3; 
	public AudioSource[] Audio;
	public TextMesh Notify;
	private bool PianoMode;

	// Use this for initialization
	void Start () {
		Notify = GameObject.Find("Notify").GetComponent<TextMesh>();
		for(int i=0; i<V_Button3.Length; i++)
		{
			V_Button3[i].GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
		}
	}
	// Update is called once per frame
	void Update () {
		
	}
	public void OnButtonPressed(VirtualButtonAbstractBehaviour vb)
  {
		PianoMode = GameObject.Find("ButtonSetObject").GetComponent<ButtonControl>().isPiano;
		var s_buttonName= vb.VirtualButtonName;
		Debug.Log(s_buttonName + "Click" + PianoMode);

		if(PianoMode)
		{
			if(s_buttonName == "Do")
		  {
				Audio[0].Play();
				Notify.text = "도";
			}
			else if(s_buttonName == "Re")
			{
				Audio[1].Play();
				Notify.text = "레";
			}
			else if(s_buttonName == "Me"){
				Audio[2].Play();
				Notify.text = "미";
		}

		}
		
	}

  public void OnButtonReleased(VirtualButtonAbstractBehaviour vb)
  {
	
  }
}
