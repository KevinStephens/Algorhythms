using UnityEngine;
using System.Collections;


//[RequireComponent(typeof(SteamVR_TrackedObject))]

public class ContactNotes : MonoBehaviour
{

    SteamVR_TrackedObject trackedObj;
    SteamVR_Controller.Device device;
    public int perfect;
    public int good;
    public int okay;
    public int bad;

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
    void OnTriggerStay(Collider col)
    {
        Debug.Log("you have stay collided with " + col.gameObject.name);

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
                perfect++;
                Debug.Log("perfect: " + perfect);
            }
            else if (percent >= 80 && percent < 90)
            {
                //gg
                good++;
                Debug.Log("good: " + good);
            }
            else if (percent >= 60 && percent < 80)
            {
                okay++;
                Debug.Log("okay: " + okay);
            }
            else
            {
                bad++;
                Debug.Log("bad: " + bad);
            }
            collidedNote.destroy();
        }
    }

}