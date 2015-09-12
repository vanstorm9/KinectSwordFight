using UnityEngine;
using System.Collections;
using System.IO.Ports;

public class led : MonoBehaviour {
	public SerialPort serial = new SerialPort ("COM5",9600);
	private bool lightState = false;
	public GameObject light = null;
	public AudioClip clip;
	public void OnMouseDown(){
		if (serial.IsOpen == false)
			serial.Open();
		if (lightState == false){
			serial.Write ("A");
			lightState = true;

			// If statement below is useless, you can remove it
			if (lightState != null && light.light != null){
				light.light.enabled = lightState;
				light.audio.PlayOneShot(clop)
			}
		} else {
			serial.Write ("a");
			lightState = false;

			// If statement below is useless, you can remove it
			if (light != null && light.lights != null){
				light.lights.enabled = lightState;
				light.audio.PlayOneShot(clip);
			}
		}
	}
}
