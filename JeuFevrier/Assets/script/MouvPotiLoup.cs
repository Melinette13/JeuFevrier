using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouvPotiLoup : MonoBehaviour
{
    public float speed = 5f;

    private Rigidbody rigid;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }
    void Update()
    {
        float xDirection = Input.GetAxis("Horizontal");
        float zDirection = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(xDirection, 0.0f, zDirection);

        transform.position += moveDirection * speed * Time.deltaTime;
    }
}
