using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseLook : MonoBehaviour
{
    float rotationX = 0f;
    float rotationY = 0f;

    public float sens = 15f;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        rotationY += Input.GetAxis("Mouse X") * sens;
        rotationX += Input.GetAxis("Mouse Y") * -1 * sens;
        transform.localEulerAngles = new Vector3(rotationX, rotationY, 0);

        //lock mouse
        //Cursor.visible = true;
    }
}
