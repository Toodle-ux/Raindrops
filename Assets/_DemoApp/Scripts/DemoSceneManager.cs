using System.Collections.Generic;
using UnityEngine;
using dreamcube.unity.Core.Scripts.AssetLoading;
using dreamcube.unity.Core.Scripts.Configuration.GeneralConfig;
using System.Collections;

public class DemoSceneManager : BaseSceneManager
{
    //should I do a check to see if the scene exists?
    public List<string> ContentScenesNames;
    private int _currentDemoSceneIndex = 0;
    // public Animator PostProcessVolume; //
    public int SceneIndicator = 1;
    
    
    protected override void Start()
    {
        base.Start();
        StartCoroutine(SceneLoader.LoadSceneAsyncNamed(ContentScenesNames[_currentDemoSceneIndex]));
        
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Alpha1))
        {
            Debug.Log("TD Scene Manager 1 Pressed");
            LoadSceneWithIndex(0);
        }
        else if(Input.GetKeyUp(KeyCode.Alpha2))
        {
            Debug.Log("TD Scene Manager 2 Pressed");
            LoadSceneWithIndex(1);
        }
              else if(Input.GetKeyUp(KeyCode.Alpha3))
        {
            Debug.Log("TD Scene Manager 2 Pressed");
            LoadSceneWithIndex(2);
        }
  
        else if (Input.GetKeyDown(KeyCode.Z))
        {
            ConfigManager.Instance.generalSettings.Debug = !ConfigManager.Instance.generalSettings.Debug;
        }
        else if (Input.GetKeyDown(KeyCode.Q))
        {
            Application.Quit();
        }

    }

    public void UpdateScene(int SceneInd)
    {
        SceneIndicator = SceneInd;
        
    }

    private void LoadSceneWithIndex(int newDemoSceneIndex)
    {
        if(newDemoSceneIndex >= ContentScenesNames.Count)
        {
            return;
        }

        if(newDemoSceneIndex != _currentDemoSceneIndex)
        {
            _ = SceneLoader.SwitchScenes(ContentScenesNames[_currentDemoSceneIndex], ContentScenesNames[newDemoSceneIndex]);
            _currentDemoSceneIndex = newDemoSceneIndex;
        }
    }
}
