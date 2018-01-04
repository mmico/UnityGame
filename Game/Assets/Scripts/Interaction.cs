using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour {

    bool showText;
    bool openWindow;

    // Use this for initialization
    void Start () {
        showText = false;
        openWindow = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "MainCamera")
        {
            showText = true;
        }

    }

    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "MainCamera")
        {
            if (Input.GetKey(KeyCode.E))
            {
                openWindow = true;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "MainCamera")
        {
            showText = false;
        }

    }

    private void OnGUI()
    {
        if (openWindow)
        {
            GUI.Window(0, new Rect(Screen.width / 2 - 250, 100, 500, 300), DoMyWindow, "My Window");
        }
        else
        {
            if (showText)
            {
                GUI.contentColor = Color.black;
                GUI.Label(new Rect(Screen.width/2-50, Screen.width/2-50, 200, 100), "Press 'E' to interact");
            }
        }

    }

    void DoMyWindow(int windowID)
    {
        if (GUI.Button(new Rect(10, 20, 100, 20), "Hello World"))
            print("Got a click");

    }
}
