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
}
