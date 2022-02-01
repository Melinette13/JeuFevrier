using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testdestroy : MonoBehaviour
{
    public GameObject Adetruire;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(Adetruire);
            Destroy(gameObject);
        }

    }
}
