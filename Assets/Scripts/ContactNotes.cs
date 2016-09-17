using UnityEngine;
using System.Collections;

[RequireComponent(typeof(SteamVR_TrackedObject))]

public class ContactNotes : MonoBehaviour {

    SteamVR_TrackedObject trackedObj;

	void Start () {
        trackedObj = GetComponent<SteamVR_TrackedObject>();
	}
	
	void Update () {
	
	}

	void FixedUpdate(){

		//this is device is the wand. 
		SteamVR_Controller.Device device = SteamVR_Controller.Input ((int)trackedObj.index);

		//if we touch the trigger
		if (device.GetTouch (SteamVR_Controller.ButtonMask.Trigger)) {
			//small debug
			Debug.Log ("The controller is being held down"); 

			//if the 'device' = wand is touching 90% is perfect
			//show visual.... 

			//if the wand is touching 80% is good

			//if the wand is touching 70% is okay

			//anything < 70 is bad!

		}
	}
			
}
