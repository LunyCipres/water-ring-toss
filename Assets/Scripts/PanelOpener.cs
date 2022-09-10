using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelOpener : MonoBehaviour
{
    public GameObject PrevPanel;
    public GameObject NextPanel;
    public GameObject ToggledPanel;

    public void OpenPanel()
    {
        if(PrevPanel != null)
        {
            PrevPanel.SetActive(false);
        }
        if(NextPanel != null)
        {
            NextPanel.SetActive(true);
        }
    }

    public void TogglePanel()
    {
        if(ToggledPanel != null)
        {
            ToggledPanel.SetActive(!ToggledPanel.activeSelf);
        }
    }
}
