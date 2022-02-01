using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Victorybackpack3 : MonoBehaviour
{
    
    void OnTriggerEnter(Collider collider)
    {

        SceneManager.LoadScene(6);

    }
}
