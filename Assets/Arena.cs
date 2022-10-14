using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arena : MonoBehaviour
{
    public GameObject player;
    public Transform elevator;
    private Animator arenaAnimator;
    private SphereCollider sphereCollider;

    // Start is called before the first frame update
    void Start()
    {
        arenaAnimator = GetComponent<Animator>();
        sphereCollider = GetComponent<SphereCollider>();
    }

    void OnTriggerEnter(Collider other)
    {
        Camera.main.transform.parent.gameObject.        //Camera
        GetComponent<CameraMovement>().enabled = false; //disable movement
        player.transform.parent = elevator.transform;
        player.GetComponent<PlayerController>().enabled = false; //disable the player's ability to control the marine
        SoundManager.Instance.PlayOneShot(SoundManager.Instance.elevatorArrived);
        arenaAnimator.SetBool("OnElevator", true);  //Kick off the animation
    }

    public void ActivatePlatform()
    {
        sphereCollider.enabled = true;
    }
}
