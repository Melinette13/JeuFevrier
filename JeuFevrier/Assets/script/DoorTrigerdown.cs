using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigerdown : MonoBehaviour
{
    public GameObject door;
    public float down = -1f;
  void OnTriggerEnter(Collider collider)
    {
        door.transform.position += new Vector3(0, down , 0);
    }
}
