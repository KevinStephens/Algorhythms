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

    }

    void OnTriggerEnter(Collider col)
    {
        Debug.Log("you have collided with " + col.gameObject.name);

        //this is device is the wand. 
        NotesVer2 collidedNote = null;
        if (col.gameObject.name == "Indication Sphere")
        {
            collidedNote = col.GetComponent<NotesVer2>();
            Transform point = collidedNote.getScale();
            float percent = collidedNote.getPercent(point);

            if (percent >= 95)
            {
                perfect++;
                Debug.Log("perfect: " + perfect);
                Debug.Log("perfect Percent: " + percent);
                //Spawns the particles at the contact point, with the particles aiming upwards
                Instantiate(perfect_particles, col.transform.position, Quaternion.Euler(new Vector3(270, 0, 0)));
    
            }
            else if (percent >= 85 && percent < 95)
            {
                good++;
                Debug.Log("good: " + good);
                Debug.Log("good Percent: " + percent);
                //Spawns the particles at the contact point, with the particles aiming upwards
                Instantiate(good_particles, col.transform.position, Quaternion.Euler(new Vector3(270, 0, 0)));
            }
            else if (percent >= 65 && percent < 85)
            {
                okay++;
                Debug.Log("okay: " + okay);
                Debug.Log("okay Percent: " + percent);
                //Spawns the particles at the contact point, with the particles aiming upwards
                Instantiate(okay_particles, col.transform.position, Quaternion.Euler(new Vector3(270, 0, 0)));
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
}
