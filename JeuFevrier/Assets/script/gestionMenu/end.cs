using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class end : MonoBehaviour
{
    public Button quit;
   
    void Start()
    {
        quit.GetComponent<Button>().onClick.AddListener(QuitGame);
    }

    public void QuitGame()
    {
        Application.Quit();

    }
}
