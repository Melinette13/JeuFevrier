using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuDemarage : MonoBehaviour
{
    public Button start;
   // public Button quit;//

    void Start()
    {
        start.GetComponent<Button>().onClick.AddListener(StartGame);
        
    }
    public void StartGame()
    {

        SceneManager.LoadScene(1);

    }
    
}
