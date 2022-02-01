using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inviblewall : MonoBehaviour
{

    public GameObject Adetruire;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            print("touche");
            Destroy(Adetruire);
        }

    }

}
