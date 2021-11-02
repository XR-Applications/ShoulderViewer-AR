using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControl : MonoBehaviour
{
    public static AudioControl instance;
    public static AudioControl Instance
    {
        get 
        {
            if(instance == null)
            {
                instance = FindObjectOfType<AudioControl>();
                if(instance == null)
                {
                    var AControl = new GameObject("AudioControl");
                    instance = AControl.AddComponent<AudioControl>();
                }
            }
            return instance;
        }
    }

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

}
