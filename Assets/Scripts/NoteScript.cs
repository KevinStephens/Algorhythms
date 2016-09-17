using UnityEngine;
using System.Collections;

public class NoteScript : MonoBehaviour
{
	bool alive;
	Transform note;


	//constructor 
	public NoteScript(Transform note){
	
		this.note = note;
		alive = true; 

	}

	public void setGone(){
		alive = false;
	}

	// Use this for initialization
	void Start ()
	{	
		
	}
	
	// Update is called once per frame
	void Update ()
	{
	     
	}
}

