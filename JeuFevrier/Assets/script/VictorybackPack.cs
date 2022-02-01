using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class VictorybackPack : MonoBehaviour
{
   
    void OnTriggerEnter(Collider collider)
    {
        
        SceneManager.LoadScene(2);

    }
}
