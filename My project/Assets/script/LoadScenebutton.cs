using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadScenebutton : MonoBehaviour
{
    public string SceneName;

    public void LoadScene()
    {
        gamemanager.Instance.LoadScene(SceneName);
    }
}
