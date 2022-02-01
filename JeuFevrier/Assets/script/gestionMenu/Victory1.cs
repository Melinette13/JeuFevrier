using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Victory1 : MonoBehaviour
{
    public Button start;
    public Button quit;

    void Start()
    {
        start.GetComponent<Button>().onClick.AddListener(StartGame);
        quit.GetComponent<Button>().onClick.AddListener(QuitGame);
    }
    public void StartGame()
    {

        SceneManager.LoadScene(3);

    }
    public void QuitGame()
    {
    Application.Quit();

    }
}
