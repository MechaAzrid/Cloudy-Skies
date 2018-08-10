using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Pause_Menu : MonoBehaviour
{
    [Header("Scene Management")]
    public string scene;

    [Header("Player Settings")]

    [Header("User-Interface Canvas'")]
    public Transform pauseMenu;
    public Transform pauseItemsMenu;
    public Transform pauseEquipMenu;
    public Transform pauseSkillsMenu;
    public Transform pauseStatusMenu;
    public Transform pauseOptionsMenu;


    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Pause();
        }

        else if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();
        }
    }

    public void Pause()
    {
        //if (pauseMenu.gameObject.activeInHierarchy == false && Input.GetKeyDown(KeyCode.P))
        if (pauseMenu.gameObject.activeInHierarchy == false)
        {
            Time.timeScale = 0;
            pauseMenu.gameObject.SetActive(true);
            //Set the time to 0 - No run time && set Pause_Menu to true

            UnityEngine.Cursor.visible = true;

            pauseItemsMenu.gameObject.SetActive(false);
            pauseEquipMenu.gameObject.SetActive(false);
            pauseSkillsMenu.gameObject.SetActive(false);
            pauseStatusMenu.gameObject.SetActive(false);
            pauseOptionsMenu.gameObject.SetActive(false);
        }

        //else if (pauseMenu.gameObject.activeInHierarchy == true && Input.GetKeyDown(KeyCode.Escape))
        else if (pauseMenu.gameObject.activeInHierarchy == true)
        {
            pauseMenu.gameObject.SetActive(false);
            Time.timeScale = 1;

            UnityEngine.Cursor.visible = false;
        }
    }

    public void ToggleItemsMenu()
    {
        if (pauseItemsMenu.gameObject.activeInHierarchy == false)
        {
            pauseItemsMenu.gameObject.SetActive(true);
            //Set the time to 0 - No run time && set Pause_Menu to true

            UnityEngine.Cursor.visible = true;

            pauseMenu.gameObject.SetActive(false);
            pauseEquipMenu.gameObject.SetActive(false);
            pauseSkillsMenu.gameObject.SetActive(false);
            pauseStatusMenu.gameObject.SetActive(false);
            pauseOptionsMenu.gameObject.SetActive(false);
        }

        else
        {
            pauseItemsMenu.gameObject.SetActive(false);

            UnityEngine.Cursor.visible = true;
        }
    }

    public void ToggleEquipMenu()
    {
        if (pauseEquipMenu.gameObject.activeInHierarchy == false)
        {
            pauseEquipMenu.gameObject.SetActive(true);
            //Set the time to 0 - No run time && set Pause_Menu to true

            UnityEngine.Cursor.visible = true;

            pauseMenu.gameObject.SetActive(false);
            pauseItemsMenu.gameObject.SetActive(false);
            pauseSkillsMenu.gameObject.SetActive(false);
            pauseStatusMenu.gameObject.SetActive(false);
            pauseOptionsMenu.gameObject.SetActive(false);
        }

        else
        {
            pauseEquipMenu.gameObject.SetActive(false);

            UnityEngine.Cursor.visible = true;
        }
    }

    public void ToggleSkillsMenu()
    {
        if (pauseSkillsMenu.gameObject.activeInHierarchy == false)
        {
            pauseSkillsMenu.gameObject.SetActive(true);
            //Set the time to 0 - No run time && set Pause_Menu to true

            UnityEngine.Cursor.visible = true;

            pauseMenu.gameObject.SetActive(false);
            pauseItemsMenu.gameObject.SetActive(false);
            pauseEquipMenu.gameObject.SetActive(false);
            pauseStatusMenu.gameObject.SetActive(false);
            pauseOptionsMenu.gameObject.SetActive(false);
        }

        else
        {
            pauseSkillsMenu.gameObject.SetActive(false);

            UnityEngine.Cursor.visible = true;
        }
    }

    public void ToggleStatusMenu()
    {
        if (pauseStatusMenu.gameObject.activeInHierarchy == false)
        {
            pauseStatusMenu.gameObject.SetActive(true);
            //Set the time to 0 - No run time && set Pause_Menu to true

            UnityEngine.Cursor.visible = true;

            pauseMenu.gameObject.SetActive(false);
            pauseItemsMenu.gameObject.SetActive(false);
            pauseEquipMenu.gameObject.SetActive(false);
            pauseSkillsMenu.gameObject.SetActive(false);
            pauseOptionsMenu.gameObject.SetActive(false);
        }

        else
        {
            pauseStatusMenu.gameObject.SetActive(false);

            UnityEngine.Cursor.visible = true;
        }
    }

    public void ToggleOptionsMenu()
    {
        if (pauseOptionsMenu.gameObject.activeInHierarchy == false)
        {
            pauseOptionsMenu.gameObject.SetActive(true);
            //Set the time to 0 - No run time && set Pause_Menu to true

            UnityEngine.Cursor.visible = true;

            pauseMenu.gameObject.SetActive(false);
            pauseItemsMenu.gameObject.SetActive(false);
            pauseEquipMenu.gameObject.SetActive(false);
            pauseSkillsMenu.gameObject.SetActive(false);
            pauseStatusMenu.gameObject.SetActive(false);
        }

        else
        {
            pauseOptionsMenu.gameObject.SetActive(false);

            UnityEngine.Cursor.visible = true;
        }
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene(scene);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
