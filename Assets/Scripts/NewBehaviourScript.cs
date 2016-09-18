﻿using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision collisionInfo)
    {
        Debug.Log("Detected collision between " + gameObject.name + " and " + collisionInfo.collider.name);
        Debug.Log("There are " + collisionInfo.contacts.Length + " point(s) of contacts");
        Debug.Log("Their relative velocity is " + collisionInfo.relativeVelocity);
    }

    void OnCollisionStay(Collision collisionInfo)
    {
        Debug.Log(gameObject.name + " and " + collisionInfo.collider.name + " are still colliding");
    }

    void OnCollisionExit(Collision collisionInfo)
    {
        Debug.Log(gameObject.name + " and " + collisionInfo.collider.name + " are no longer colliding");
    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision detected with trigger object " + other.name);
    }

    void OnTriggerStay(Collider other)
    {
        Debug.Log("Still colliding with trigger object " + other.name);
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log(gameObject.name + " and trigger object " + other.name + " are no longer colliding");
    }
}
