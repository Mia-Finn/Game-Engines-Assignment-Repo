using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cursorSelect_script : MonoBehaviour
{
    public GameObject Menu, textCanvas, radioMenu;

    private void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

    }

    // Update is called once per frame
    void Update()
    {
        //open main menu
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Menu.SetActive(true);
            textCanvas.SetActive(false);
            cursorON();
        }
        else if (radioMenu.activeInHierarchy == true)
        {
            textCanvas.SetActive(false);
            cursorON();
        }
        /*
        else if(Input.GetKeyDown(KeyCode.Tab))
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = true;
        }
        */
    }

    public void cursorON()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    public void cursorOFF()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}
