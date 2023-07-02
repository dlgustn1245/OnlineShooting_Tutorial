using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadingSceneControl : MonoBehaviour
{
    public Progress progress;
    
    void Awake()
    {
        SetupSystem();
    }

    void SetupSystem()
    {
        Application.runInBackground = true;

        int width = Screen.width;
        int height = (int)(Screen.width * 18.5f / 9);
        Screen.SetResolution(width, height, true);

        Screen.sleepTimeout = SleepTimeout.NeverSleep;
        
        progress.Play(OnAfterProgress);
    }

    void OnAfterProgress()
    {
        
    }
}
