using UnityEngine;
using System.Collections;
using System.IO.Ports;

public class led : MonoBehaviour {
	public SerialPort serial = new SerialPort ("COM7",9600);
//	Debug.Log("Initalized serial port");
	private bool lightState = false;
	//public GameObject light = null;
	public AudioClip clip;
	/*
	void Start()
	{
		serial.Open ();
		//serial.Write ("Testing");
		if (serial.IsOpen == false) {
			//serial.Write ("Force Open");
			Debug.Log ("Force Open");
			//	serial.Open ();
		} else {
			//serial.Write ("Port already opened");
			Debug.Log ("Port already opened");
		}
	}
	*/
	/*
	public void OnMouseDown(){
		//serial.Open ();
		Debug.Log ("Mouse Clicked");
		if (lightState == false){
			serial.Write ("A");
			lightState = true;
			Debug.Log ("LightState true");


		} else {
			serial.Write ("a");
			lightState = false;
			Debug.Log ("LightState false");

		}
	}
	*/
}
