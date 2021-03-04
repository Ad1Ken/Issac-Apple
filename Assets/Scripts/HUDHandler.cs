using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HUDHandler : MonoBehaviour
{
    public GameObject Maingame;
    public GameObject MenuPanel;
    public GameObject GameOverPanel;
    public Text scoreEn;





    private void Start()
    {
        ActiveGameState(HUDstate.Menu);
    }

    public void ActiveGameState(HUDstate state)
    {
        if (state == HUDstate.Menu)
        {
            MenuPanel.SetActive(true);
           
            GameOverPanel.SetActive(false);
            

        }
        
        else if (state == HUDstate.Game)
        {
            
            Maingame.SetActive(true);
            MenuPanel.SetActive(false);
            scoreEn.gameObject.SetActive(true);
            
        }
        else if(state==HUDstate.GameOver)
        {
            GameOverPanel.SetActive(true);
            Maingame.SetActive(false);
        }


    }




    public void OnClickPlay()
    {
        ActiveGameState(HUDstate.Game);
    }

    public void OnClickExit()
    {
        Application.Quit();
    }

    public void OnClickReturn()
    {
        ActiveGameState(HUDstate.Menu);
        Clean();
    }
    
    public void Clean()
    {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene("Game");

    }

    
}
