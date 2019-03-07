using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Do : MonoBehaviour, IVirtualButtonEventHandler  {

	public GameObject Do_Button;

	// Use this for initialization
	void Start () {
		Do_Button = GameObject.Find("Do");
		attachEventHandler();
	}
	
	
	void attachEventHandler()
	{
		Do_Button.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnButtonPressed(VirtualButtonAbstractBehaviour vb)
    {
		Debug.Log("도");
    }

    public void OnButtonReleased(VirtualButtonAbstractBehaviour vb)
    {

    }
}
