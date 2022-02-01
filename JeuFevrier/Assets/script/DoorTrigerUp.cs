using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigerUp : MonoBehaviour
{
    public GameObject door;
    public float up = 2f;
    void OnTriggerEnter(Collider collider)
    {
        door.transform.position += new Vector3(0, up, 0);
    }
}
