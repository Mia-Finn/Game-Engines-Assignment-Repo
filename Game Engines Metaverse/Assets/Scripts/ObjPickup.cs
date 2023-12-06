using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjPickup : MonoBehaviour
{
    public Transform objTransform, holdTransform;
    public bool interactable, pickedUp;
    public Rigidbody rb;
    public float throwAmount;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            interactable = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            if (pickedUp == false)
            {
                interactable = false;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (interactable == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                objTransform.parent = holdTransform;
                rb.useGravity = false;
                pickedUp = true;

                GetComponent<Rigidbody>().isKinematic = true;
            }
            if (Input.GetMouseButtonUp(0))
            {
                objTransform.parent = null;
                rb.useGravity = true;
                pickedUp = false;

                GetComponent<Rigidbody>().isKinematic = false;
            }
            if (pickedUp == true)
            {
                if (Input.GetMouseButtonDown(1))
                {
                    GetComponent<Rigidbody>().isKinematic = false;

                    objTransform.parent = null;
                    rb.useGravity = true;
                    rb.velocity = holdTransform.forward * throwAmount * Time.deltaTime;
                    pickedUp = false;
                }
            }
        }
    }
}
