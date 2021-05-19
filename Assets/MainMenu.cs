using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public void StartGame() {
        Application.LoadLevel ("track1");
    }

    public void QuitGame() {
        Application.Quit();
    }

    public void setting()
    {
        Application.LoadLevel ("s");
    }
}
