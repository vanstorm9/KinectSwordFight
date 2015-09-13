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
<<<<<<< HEAD

=======
>>>>>>> eb4bf46ec81805d7679099ccfa7b4c88b46e2163
		OpenCheck ();
	}
	
	void OpenCheck()
	{
		if (serial.IsOpen == false) {
			//serial.Write ("Force Open");
			Debug.Log ("Force Open");
			serial.Open ();
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
<<<<<<< HEAD

	/*
	void OnCollisionEnter(Collision col)
	{
		if(col.gameObject.name == "Cube_Col")
		{
			Destroy (col.gameObject);
		}
	}
	 * */

	void OnCollisionEnter(Collision collision) 
	{
		Debug.Log ("Collision Detected");

		Debug.Log (collision.gameObject.name);



=======
	void OnCollisionEnter(Collision collision) 
	{
>>>>>>> eb4bf46ec81805d7679099ccfa7b4c88b46e2163
		FingerModel finger = collision.gameObject.GetComponentInParent<FingerModel>();
		/*
		if(finger){
			Debug.Log ("Finger " + finger.fingerType);

		}
		*/
<<<<<<< HEAD

		OpenCheck ();
		Debug.Log ("Serial sent to Arduino");
		serial.Write ("A");



=======
		Debug.Log ("Serial sent to Arduino");
		serial.Write ("A");
		/*
		Debug.Log ("Commence sleep");
		int i = 0;
		while (true) 
		{
			if(i > 9000)
			{
				break;
			}
			i++;
		}

		Debug.Log ("End sleep");
		*/
>>>>>>> eb4bf46ec81805d7679099ccfa7b4c88b46e2163
	}
	
	public void OnMouseDown(){
		Debug.Log ("Mouse pressed Down");
		OpenCheck ();
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
