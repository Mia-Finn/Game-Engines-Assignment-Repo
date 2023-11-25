using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    //Char move that allows player to mave relative to where the camera is looking
    Rigidbody rb;
    [SerializeField] float moveSpeed = 10;
    [SerializeField] Transform cam;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //move code!
        float horInput = Input.GetAxisRaw("Horizontal") * moveSpeed;
        float verInput = Input.GetAxisRaw("Vertical") * moveSpeed;

        //camera direction
        Vector3 camForward = cam.forward;
        Vector3 camRight = cam.right;

        camForward.y = 0;
        camRight.y = 0;

        //move relative to cam direction
        Vector3 forwardRelative = verInput * camForward;
        Vector3 rightRelative = horInput * camRight;

        Vector3 moveDir = forwardRelative + rightRelative;

        //movement
        rb.velocity = new Vector3(moveDir.x, rb.velocity.y, moveDir.z);
    }
}
