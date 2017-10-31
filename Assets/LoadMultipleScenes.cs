using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadMultipleScenes : MonoBehaviour 
{
    [SerializeField]
    private int numberOfExtraScenesToLoad = 3;

    private void Start () 
	{
        for (int i = 1; i <= numberOfExtraScenesToLoad; i++)
        {
            SceneManager.LoadSceneAsync(i, LoadSceneMode.Additive);
        }
	}
}