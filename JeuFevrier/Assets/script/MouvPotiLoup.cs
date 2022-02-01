using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouvPotiLoup : MonoBehaviour
{
    public float speed = 5f;

    private Rigidbody rigid;
    public Animator animator;

    

    void FixedUpdate()
    {
       
            GetComponent<Animator>().SetBool("loupwalk", false);
            
    }
    void Update()
    {

        float xDirection = Input.GetAxis("Horizontal");
        float zDirection = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(xDirection, 0.0f, zDirection);

        transform.position += moveDirection * speed * Time.deltaTime;

        GetComponent<Animator>().SetBool("loupwalk", true);
    }
}
