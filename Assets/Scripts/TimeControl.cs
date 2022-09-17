using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;

        //limiting framerate for correct simulation according to mobile
        // Application.targetFrameRate = 60;
    }

    public void FreezeTime() {
        Time.timeScale = 0;
    }
    public void NormalTime() {
        Time.timeScale = 1;
    }

    public void ToggleTime() {
        if (Time.timeScale == 0) {
            Time.timeScale = 1;
        } else {
            Time.timeScale = 0;
        }
    }
}
