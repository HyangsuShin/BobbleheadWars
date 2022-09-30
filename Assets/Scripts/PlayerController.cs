using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 50.0f;
    private CharacterController characterController;
    public Rigidbody head;

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        /*Vector3 pos = transform.position;
        pos.x += moveSpeed * Input.GetAxis("Horizontal") * Time.deltaTime;
        pos.z += moveSpeed * Input.GetAxis("Vertical") * Time.deltaTime;
        transform.position = pos;  */
        Vector3 moveDirection = new Vector3(Input.GetAxis("Horizontal"),
        0, Input.GetAxis("Vertical"));
        characterController.SimpleMove(moveDirection * moveSpeed);
    }

    void FixedUpdate()
    {
        Vector3 moveDirection = new Vector3(Input.GetAxis("Horizontal"),
0, Input.GetAxis("Vertical"));
        if (moveDirection == Vector3.zero)
        {
            // TODO
        }
        else
        {
            head.AddForce(transform.right * 150, ForceMode.Acceleration);
        }
    }
}