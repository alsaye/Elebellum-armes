using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScript : MonoBehaviour
{
    public GameObject PauseMenu;
    public bool verif = false;
    void start ()
    {
        Time.timeScale = 1;
    }
    // Update is called once per frame
    void Update()
    {
         if(Input.GetKeyDown("escape"))
         {
             if (verif == false)
                {
                    PauseMenu.SetActive(true);
                    verif = true;
                    Time.timeScale = 0;
                }
             else
                {
                    PauseMenu.SetActive(false);
                    verif = false;
                    Time.timeScale = 1;
                }
             
         }
    }
}
