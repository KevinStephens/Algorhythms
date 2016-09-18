using UnityEngine;
using System.Collections;

public class ParticleFeedback : MonoBehaviour {
    public Transform particles;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

    }

    void OnTriggerEnter(Collider col)
    {
       // Instantiate(particles, col.transform.position, Quaternion.identity);
        Debug.Log(col.transform.position);

            //var sparks = new GameObject(particle, particle.position, Quaternion.identity);

    }

}
