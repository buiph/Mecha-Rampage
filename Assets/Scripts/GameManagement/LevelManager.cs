using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    //NOTE
    //THIS SCRIPT MIGHT BECOME MANAGER FOR BOTH LEVEL AND MENU
    //CHANGE NAME IN FUTURE
    [SerializeField] public GameObject pauseMenu;
    [SerializeField] public GameObject slotPannel;

    PlayerInputAction inputAction;
    internal bool pause;
    internal Scene currScene;

    private void Awake()
    {
        inputAction = new PlayerInputAction();
        inputAction.GameControls.Pause.performed += _ => Pause();
    }

    void Start()
    {
        pause = false;
        if (pauseMenu != null)
        {
            pauseMenu.gameObject.SetActive(false);
        }
    }

    void Update()
    {
        currScene = SceneManager.GetActiveScene();
    }

    /// <summary>
    /// Pauses the game
    /// </summary>
    public void Pause()
    {
        if (pauseMenu != null && !slotPannel.activeSelf)
        {
            if (pause)
            {
                Time.timeScale = 1;
                pause = false;
                pauseMenu.gameObject.SetActive(false);
            }
            else
            {
                Time.timeScale = 0;
                pause = true;
                pauseMenu.gameObject.SetActive(true);
            }
        }
    }

    /// <summary>
    /// Loads a game scene given a build index
    /// </summary>
    /// <param name="sceneIndex"></param>
    public void LoadSceneByIndex(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
        if (sceneIndex == 0)
        {
            pause = true;
            Time.timeScale = 0;
        }
        else
        {
            pause = false;
            Time.timeScale = 1;
        }
    }

    /// <summary>
    /// Quits the game
    /// </summary>
    public void Quit()
    {
        Application.Quit();
    }
    
    /// <summary>
    /// Enable and disables input action
    /// </summary>
    private void OnEnable()
    {
        inputAction.Enable();
    }

    private void OnDisable()
    {
        inputAction.Disable();
    }
}
