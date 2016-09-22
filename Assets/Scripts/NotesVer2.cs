using UnityEngine;
using System.Collections;

public class NotesVer2 : MonoBehaviour
{
    public bool alive;
    public float speed;
    public Transform note;
    public Transform maxvector;
    public GameObject acutalNote;

    void Start()
    {
        alive = true;

    }

    void Update()
    {
        Transform currentvector = note;

        if (currentvector.localScale.x >= maxvector.localScale.x * 0.8)
        {
            currentvector.localScale -= Vector3.one * speed * Time.deltaTime;
        }
        else if (currentvector.localScale.x < (maxvector.localScale.x * 0.9f))
        { //player was too slow
            Debug.Log("Missed a note");
            destroy();
        }

    }

    void setGone()
    {
        alive = false;
    }

    public void destroy()
    {
        setGone();
        //if you miss it'll be gone, show code that it's gone.
        if (gameObject != null)
        {
            Destroy(gameObject);
        }
        Destroy(acutalNote);
    }

    public Transform getScale()
    {
        return note;
    }

    public float getPercent(Transform vector)
    {
        float answer;
        if (vector.localScale.x < maxvector.localScale.x)
        {
            answer = (vector.localScale.x / maxvector.localScale.x) * 100.0f;
        }
        else if (maxvector.localScale.x < vector.localScale.x)
        {
            answer = (maxvector.localScale.x / vector.localScale.x) * 100.0f;
        }
        else
        { // they are equal aka absolute perfect
            answer = 100.0f;
        }
        return answer;
    }

}
