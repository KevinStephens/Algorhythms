using UnityEngine;
using System.Collections;


[RequireComponent(typeof(SteamVR_TrackedObject))]

public class ContactNotes : MonoBehaviour
{

    SteamVR_TrackedObject trackedObj;
    SteamVR_Controller.Device device;
    private int perfect;
    private int good;
    private int okay;
    private int bad;
    public Transform perfect_particles;
    public Transform good_particles;
    public Transform okay_particles;
    void Awake()
    {
        trackedObj = GetComponent<SteamVR_TrackedObject>();
     
    }


    void Update()
    {
        //device = SteamVR_Controller.Input((int)trackedObj.index);
        //Debug.Log("Update");
        //ParticleSystem test = gameObject.GetComponent<ParticleSystem>();
        //test.Play();
    }

    void OnTriggerEnter(Collider col)
    {
        Debug.Log("you have collided with " + col.gameObject.name);

        //this is device is the wand. 
        NoteScript collidedNote = null;
        if (col.gameObject.name == "Note sphere")
        {
            collidedNote = col.GetComponent<NoteScript>();


            //small debug

            Transform point = collidedNote.getScale();
            float percent = collidedNote.getPercent(point);

            if (percent >= 95)
            {
                perfect++;
                Debug.Log("perfect: " + perfect);
                Debug.Log("perfect Percent: " + percent);
                Instantiate(perfect_particles, col.transform.position, Quaternion.identity);
    
            }
            else if (percent >= 85 && percent < 95)
            {
                good++;
                Debug.Log("good: " + good);
                Debug.Log("good Percent: " + percent);
                Instantiate(good_particles, col.transform.position, Quaternion.identity);
            }
            else if (percent >= 65 && percent < 85)
            {
                okay++;
                Debug.Log("okay: " + okay);
                Debug.Log("okay Percent: " + percent);
                Instantiate(okay_particles, col.transform.position, Quaternion.identity);
            }
            else if (percent >= 0 && percent < 65)
            {
                bad++;
                Debug.Log("bad: " + bad);
                Debug.Log("Bad Percent: " + percent);
            }
            else
            {
                Debug.Log("N/A, reached else statement");
            }

            collidedNote.destroy();
        }
       
    }

    public int totalScore()
    {
        return ((perfect * 10) + (good * 6) + (okay * 2));
    }

    //grade based on the perfect hits only.
    public string gradeGenerator(int score)
    {
        string gradeLetter = "F";
        
        if ( perfect >= 15)
        {
            gradeLetter = "A";
        }
        else if (perfect >= 10 && perfect < 15)
        {
            gradeLetter = "B";
        }
        else if (perfect >= 5 && perfect < 10)
        {
            gradeLetter = "C";
        }

        return gradeLetter;
    }
    /*
    void OnTriggerStay(Collider col)
    {
        Debug.Log("you have stay collided with " + col.gameObject.name);

        //this is device is the wand. 


        NoteScript collidedNote = col.GetComponent<NoteScript>();
        //if we touch the trigger with the wand.....
       // if (device.GetTouch(SteamVR_Controller.ButtonMask.Trigger))
       // {
            //small debug
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
    */
}
