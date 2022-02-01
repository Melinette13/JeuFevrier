using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenueRest2 : MonoBehaviour
{
    public Behaviour Canvasrest;
    public Button yes;
    public Button no;
    public Button quit;

    // public Button quit;//

    void Start()
    {
        yes.GetComponent<Button>().onClick.AddListener(Reload);
        no.GetComponent<Button>().onClick.AddListener(HideCanvas);
        quit.GetComponent<Button>().onClick.AddListener(QuitGame);

    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Canvasrest.enabled = !Canvasrest.enabled;
        }
    }

    public void Reload()
    {

        SceneManager.LoadScene(3);

    }

    public void HideCanvas()
    {

        Canvasrest.enabled = !Canvasrest.enabled;

    }
    public void QuitGame()
    {
        Application.Quit();

    }
}
