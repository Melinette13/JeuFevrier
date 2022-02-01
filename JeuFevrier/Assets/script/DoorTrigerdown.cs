using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigerdown : MonoBehaviour
{
    public GameObject door;
    public float down = -1f;
    public Animator animator;
    public AudioClip Clic;
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    void OnTriggerEnter(Collider collider)
    {
        door.transform.position += new Vector3(0, down , 0);
        GetComponent<Animator>().SetBool("clicon", true);
        audioSource.PlayOneShot(Clic,1f);

    }
    void OnTriggerExit(Collider collider)
    {;
        GetComponent<Animator>().SetBool("clicon", false);
    }

}
