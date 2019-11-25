using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inGameMenuController : MonoBehaviour
{
    private bool isPaused = false;
    public GameObject menu;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {

            if (menu!=null)
            {
                bool isActive = menu.activeSelf;

                if (isPaused)
                {
                    isPaused = false;
                }
                else
                {
                    isPaused = true;
                }
                pauseGame();
                menu.SetActive(!isActive);
                
            }
            else
            {
                //DEberia reload?
            }
            
        }
    }

    public void pauseGame()
    {
        if(Time.timeScale == 1)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }


}
