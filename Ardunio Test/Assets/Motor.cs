using UnityEngine;
using System.Collections;
using System.IO.Ports;

public class Motor : MonoBehaviour {
	public SerialPort serial = new SerialPort ("COM7",9600);
	//	Debug.Log("Initalized serial port");
	private bool lightState = false;
	//public GameObject light = null;
	public AudioClip clip;

	int wheel_time = 0;

	
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

	/*
	void Update()
	{
		if (lightState) 
		{
			serial.Write ("A");
		}
	}
	*/
	
	public void OnMouseDown(){
		Debug.Log ("Mouse pressed Down");
		/*
		while (true) 
		{

			if(wheel_time < 30)
			{
				Debug.Log ("Escaped");
				break;
			}
			serial.Write("A");
			wheel_time++;
			Debug.Log (wheel_time);
		}
		*/


		serial.Write ("A");

	}
}
