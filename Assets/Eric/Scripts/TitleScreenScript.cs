using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class TitleScreenScript : MonoBehaviour
{

    public GameObject MainButtonPanel;
    public GameObject OptionsButtonPanel;
    public bool OptionsOpened = false;

    // Start is called before the first frame update
    void Start()
    {
        MainButtonPanel.SetActive(true);
        OptionsButtonPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /// <summary>
    /// Loads the next scene in the build index
    /// </summary>
    public void Play()
    {
        //Play animation
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    /// <summary>
    /// Displays game options menu
    /// </summary>
    public void Options()
    {
        if (OptionsOpened)
        {
            MainButtonPanel.SetActive(true);
            OptionsButtonPanel.SetActive(false);
            OptionsOpened = false;
            return;
        }
        MainButtonPanel.SetActive(false);
        OptionsButtonPanel.SetActive(true);
        OptionsOpened = true;
    }
    /// <summary>
    /// Loads credits scene
    /// </summary>
    public void Credits()
    {
        //Play animation
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Exit()
    {
        Debug.Log("Application Quitting!");
        Application.Quit();
    }
}
