using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeControl : MonoBehaviour
{
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
