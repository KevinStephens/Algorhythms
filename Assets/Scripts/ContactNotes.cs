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

		//this is device for controller
		SteamVR_Controller.Device device = SteamVR_Controller.Input((int)trackedObj.index);

		//if we touch the trigger
		if (device.GetTouch(SteamVR_Controller.ButtonMask.Trigger))
		{
			//small debug
			Debug.Log("The controller is being held down"); 

		}
			
}
