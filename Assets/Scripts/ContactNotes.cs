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

    public int playerScore()
    {
        return ((perfect * 100) + (good * 75) + (okay * 25));
    }

    public int totalNotes()
    {
        return perfect + good + okay + bad;
    }

    public int maxScore()
    {
        int numNotes = totalNotes();
        return numNotes * 100;
    }

    //Takes the current score and divides it by the maximum score possible
    public string gradeGenerator(int score)
    {
        string gradeLetter = "F";
        int maximumScore = maxScore();
        
        if (score / maximumScore == 1)
        {
            gradeLetter = "S";
        }
        else if (score / maximumScore < 1)
        {
            gradeLetter = "A";
        }
        else if (score / maximumScore < 0.90)
        {
            gradeLetter = "B";
        }
        else if (score / maximumScore < 0.80)
        {
            gradeLetter = "C";
        }
        else if (score / maximumScore < 0.70 && score / maximumScore >= 0.60)
        {
            gradeLetter = "D";
        }
        return gradeLetter;
    }
}
