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

	// Update is called once per frame
	void Update ()
	{
		//Transform maxvector = new Vector3(1.0f, 1.0f, 1.0f);
		Transform currentvector = note;
		//float distance = Vector3.Distance(currentvector, maxvector);

		if (currentvector.localScale.x <= maxvector.localScale.x * 1.2) {
			currentvector.localScale += Vector3.one * speed * Time.deltaTime;
		}
		else if (currentvector.localScale.x > (maxvector.localScale.x * 1.2f))  {
			setGone();
			Debug.Log ("ITS GONE YO" + alive);
			//if you miss it'll be gone, show code that it's gone.
			Destroy(gameObject);
			Destroy (indication);
		}

	}



	void setGone(){
		alive = false;
	}

}

