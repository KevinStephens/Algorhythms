using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using VRTK;

public class ButtonTest : MonoBehaviour
{
    public GameObject button;
    public GameObject controller;

    private void Start(){
        //Setup controller event listeners
        controller.GetComponent<VRTK_UIPointer>().UIPointerElementExit += ButtonOnExit;
    }

    private void ButtonOnExit(object sender, UIPointerEventArgs e)
    {
        Debug.Log("UI Pointer exited " + e.previousTarget.name + " on Controller index [" + e.controllerIndex + "]");
        Debug.Log("YEEAAAH");


        if (e.previousTarget == button)
        {
            Debug.Log("YEEAAAH!!!!!!!!!!!");
        }
    }
}
