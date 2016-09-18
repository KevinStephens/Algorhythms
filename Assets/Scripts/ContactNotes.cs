using UnityEngine;
using System.Collections;


<<<<<<< HEAD
[RequireComponent(typeof(SteamVR_TrackedObject))]

public class ContactNotes : MonoBehaviour {

	SteamVR_TrackedObject trackedObj;
	SteamVR_Controller.Device device;


	void Awake () {
		trackedObj = GetComponent<SteamVR_TrackedObject>();
		device =  SteamVR_Controller.Input ((int)trackedObj.index);

	}


	void Update(){

	//update device track object....
	 device = SteamVR_Controller.Input ((int)trackedObj.index);
		Debug.Log ("device update");
	}

	void onTriggerEnter(Collider col) {
	
		Debug.Log ("you have collided with " + col.name);

		//this is device is the wand. 
		//SteamVR_Controller.Device device = SteamVR_Controller.Input ((int)trackedObj.index);

		//if collision happens, grab that NoteScript info, delete that one note script.
		NoteScript collidedNote = col.GetComponent<NoteScript>(); 
		//if we touch the trigger with the wand.....
		if (device.GetTouch (SteamVR_Controller.ButtonMask.Trigger)) {
			//small debug
			Debug.Log ("The controller is being held down and touching something...."); 
			Transform point = collidedNote.getScale();
			float percent = collidedNote.getPercent (point);

			if (percent >= 90) {
				//perfect
				Debug.Log("perfect");
			} else if (percent >= 80 && percent < 90) {
				//gg
				Debug.Log("gg");

			} else if (percent >= 60 && percent < 80) {
				//ok
				Debug.Log("okay");

			} else {
				//bad
				Debug.Log("bad");

			}

		}

		collidedNote.destroy ();
	}
		
			
}
=======
//[RequireComponent(typeof(SteamVR_TrackedObject))]

public class ContactNotes : MonoBehaviour
{

    SteamVR_TrackedObject trackedObj;
    SteamVR_Controller.Device device;


    void Awake()
    {
        trackedObj = GetComponent<SteamVR_TrackedObject>();
    }


    void Update()
    {
        //device = SteamVR_Controller.Input((int)trackedObj.index);
        //Debug.Log("Update");

    }

    void OnTriggerEnter(Collider col)
    {
        Debug.Log("you have collided with " + col.gameObject.name);
        
        //this is device is the wand. 
        

        NoteScript collidedNote = col.GetComponent<NoteScript>();
        //if we touch the trigger with the wand.....
        if (device.GetTouch(SteamVR_Controller.ButtonMask.Trigger))
        {
            //small debug
            Debug.Log("The controller is being held down and touching something....");
            Transform point = collidedNote.getScale();
            float percent = collidedNote.getPercent(point);

            if (percent >= 90)
            {
                //perfect
                Debug.Log("perfect");
            }
            else if (percent >= 80 && percent < 90)
            {
                //gg
                Debug.Log("good");
            }
            else if (percent >= 60 && percent < 80)
            {
                Debug.Log("okay");
            }
            else
            {
                Debug.Log("ur so bad");
            }

        }

        collidedNote.destroy();
    }


}
>>>>>>> 2c99c4be56a547656c2dbd086557ceaa9256ff07
