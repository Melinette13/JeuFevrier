using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigerUp : MonoBehaviour
{
    public GameObject door;
    public float up = 2f;
    public Animator animator;
    public AudioClip Clic;
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    void OnTriggerEnter(Collider collider)
    {
        door.transform.position += new Vector3(0, up, 0);
        GetComponent<Animator>().SetBool("clicon", true);
        audioSource.PlayOneShot(Clic, 1f);

    }
    void OnTriggerExit(Collider collider)
    {
        ;
        GetComponent<Animator>().SetBool("clicon", false);
    }

}
