using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Victorybackpack2 : MonoBehaviour
{
    void OnTriggerEnter(Collider collider)
    {

        SceneManager.LoadScene(4);

    }
}
