using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    [SerializeField] private String _sceneName = default;
    
    public void ChangeByButton()
    {
        SceneManager.LoadScene(_sceneName);
    }
}
