using UnityEngine;
using System.Collections;

public class CountDownScript : MonoBehaviour{
	public float speed = 8f;
	public float countdown = 3.0f;

	void Update(){
		SteamVR_Controller.Device device = SteamVR_Controller.Input();

		//if we touch the trigger
		if (device.GetTouch (SteamVR_Controller.ButtonMask.Trigger)) {
			//start the countdown 
			countdown -= Time.deltaTime;
			//small debug
			Debug.Log("Trigger for start was pressed");

			//change the position of the curtain object. 
			transform.position += new Vector3 (speed * Time.deltaTime, 0.0f, 0.0f);

			//open the curtain or whatever
		}
	}
}

