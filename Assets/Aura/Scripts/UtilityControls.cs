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
        AudioControl.Instance.PlayButtonFX();
        SceneManager.LoadSceneAsync(0);
    }

    public void FlipFlash()
    {
        AudioControl.Instance.PlayButtonFX();

        if (flashIsOn == false)
        {
            VuforiaBehaviour.Instance.CameraDevice.SetFlashTorchMode(true);
            flashIsOn = true;
        }
        if (flashIsOn == true)
        {
            VuforiaBehaviour.Instance.CameraDevice.SetFlashTorchMode(false);
            flashIsOn = false;
        }
    }

    public void ExitApp()
    {
        AudioControl.Instance.PlayButtonFX();

        Application.Quit();
    }
}
