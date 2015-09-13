using UnityEngine;
using System.Collections;
using System.IO.Ports;

public class SwordCollision : MonoBehaviour {
	public MasterSerial serialcall;
	public GameObject SerialObject;

	void Start()
	{
		GameObject SerialObject = GameObject.Find ("SerialObject");
		serialcall = SerialObject.GetComponent <MasterSerial> ();
	}



	void OnCollisionEnter (Collision target) {
		Debug.Log ("Successful collision with sword");


		serialcall.ActivateFeedback ();
	}
}
