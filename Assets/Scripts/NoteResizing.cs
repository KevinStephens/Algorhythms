using UnityEngine;
using System.Collections;

public class NoteResizing : MonoBehaviour
{
    public float speed;
    public 

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale += Vector3.one * speed * Time.deltaTime;
    }
}
