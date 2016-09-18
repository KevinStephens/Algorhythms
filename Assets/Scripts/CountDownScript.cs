using UnityEngine;
using System.Collections;

public class CountDownScript : MonoBehaviour{
	public float speed = 8f;
	public float countdown = 3.0f;

	void Update(){
		SteamVR_Controller.Device device = SteamVR_Controller.Input(0);

		//if we touch the trigger the count down will start.....
		if (device.GetTouch (SteamVR_Controller.ButtonMask.Trigger)) {
			//start the countdown 
			countdown -= Time.deltaTime;
			//small debug
			Debug.Log("Trigger for start was pressed countdown initiating...");

			//change the position of the curtain object. 
			transform.position += new Vector3 (speed * Time.deltaTime, 0.0f, 0.0f);

			//open the curtain or whatever
		}
	}
}

