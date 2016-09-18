using UnityEngine;
using System.Collections;

public class NoteScript : MonoBehaviour
{
	public bool alive;
	public float speed;
	//public Vector3 maxvector;
	public Transform note;
	public Transform maxvector;
	public GameObject indication;

	// Use this for initialization
	void Start (){	
		alive = true;

	}
	public void destroy()
	{
		setGone();
        //if you miss it'll be gone, show code that it's gone.
        if (gameObject != null)
        {
            Destroy(gameObject);
        }
		Destroy (indication);
	}

	// Update is called once per frame
	void Update ()
	{
		//Transform maxvector = new Vector3(1.0f, 1.0f, 1.0f);
		Transform currentvector = note;
		//float distance = Vector3.Distance(currentvector, maxvector);

		if (currentvector.localScale.x <= maxvector.localScale.x * 1.2) {
			currentvector.localScale += Vector3.one * speed * Time.deltaTime;

		}
		else if (currentvector.localScale.x > (maxvector.localScale.x * 1.2f))  { //player was too slow
            Debug.Log("Missed a note");
            destroy();
		}

	}



	void setGone(){
		alive = false;
	}

	public Transform getScale(){
		return note;
	}

	 public float getPercent(Transform vector){
		float percent;
		float answer;
        if (vector.localScale.x < maxvector.localScale.x)
        {
            answer = (vector.localScale.x / maxvector.localScale.x) * 100.0f;
        } else if (maxvector.localScale.x < vector.localScale.x)
        {
            answer = (maxvector.localScale.x / vector.localScale.x) * 100.0f;
        } else
        { // they are equal aka absolute perfect
            answer = 100.0f;
        }
		/*percent = Mathf.Abs(vector.localScale.x - maxvector.localScale.x);
		if (vector.localScale.x <= 1.0f) {
			answer = percent * 100.0f;
		} else { //the note bubble is bigger than the outline bubble
			answer = (maxvector.localScale.x / vector.localScale.x) * 100.0f;
		}
        */
		return answer;
	}

}

