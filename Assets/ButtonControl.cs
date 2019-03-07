using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ButtonControl : MonoBehaviour, IVirtualButtonEventHandler {

 	public GameObject V_Button;
    public UnityEngine.UI.Text UI;
    public bool isPiano = false;

	// Use this for initialization
	void Start () {
		
		V_Button = GameObject.Find("PianoMode");
		attachEventHandler();
	}

	void attachEventHandler()
	{
		V_Button.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnButtonPressed(VirtualButtonAbstractBehaviour vb)
    {
		if(!isPiano)
		{
			isPiano = true;
			UI.text = "Piano ON";
			Debug.Log("ON");
		}
		else
		{
			isPiano = false;
			UI.text = "Piano OFF";
			Debug.Log("OFF");
		}
    }

    public void OnButtonReleased(VirtualButtonAbstractBehaviour vb)
    {

    }
}
