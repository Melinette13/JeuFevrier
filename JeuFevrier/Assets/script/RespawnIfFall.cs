using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnIfFall : MonoBehaviour
{
    public GameObject player;
    public Transform spawn; 
    
    void OnTriggerEnter(Collider collider)
    {
        player.transform.position = spawn.position;
    }
}
