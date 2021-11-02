using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vuforia;

public class UtilityControls : MonoBehaviour
{
    private bool flashIsOn = false;

    public void LoadHome()
    {
        SceneManager.LoadSceneAsync(0);
    }

    public void FlipFlash()
    {
        if (flashIsOn == false)
        {
            VuforiaBehaviour.Instance.CameraDevice.SetFlash(true);
            flashIsOn = true;
        }
        if (flashIsOn == true)
        {
            VuforiaBehaviour.Instance.CameraDevice.SetFlash(false);
            flashIsOn = false;
        }
    }

    public void ExitApp()
    {
        Application.Quit();
    }
}
