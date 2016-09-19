using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using System.Collections;
using VRTK;

public class ButtonScript : MonoBehaviour
{
    public GameObject button;
    public GameObject controller;

    private void Start(){
        //Setup controller event listeners
        controller.GetComponent<VRTK_UIPointer>().UIPointerElementEnter += ButtonOnEnter;
        controller.GetComponent<VRTK_UIPointer>().UIPointerElementExit += ButtonOnExit;
    }

    private void ButtonOnExit(object sender, UIPointerEventArgs e)
    {
        Debug.Log("UI Pointer exited " + e.previousTarget.name + " on Controller index [" + e.controllerIndex + "]");

        if (e.previousTarget == button)
        {
            SceneManager.LoadScene("Main", LoadSceneMode.Single);
        }
    }

    private void ButtonOnEnter(object sender, UIPointerEventArgs e)
    {
        Debug.Log("UI Pointer entered " + e.currentTarget.name + " on Controller index [" + e.controllerIndex + "]");

        if (e.currentTarget.GetType() == typeof(Button))
        {
            Button target = e.currentTarget.GetComponent<Button>();
            target.Select();
        }
    }
}
