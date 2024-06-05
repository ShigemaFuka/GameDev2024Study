using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// スコア　表示
/// </summary>
public class ShowUI : MonoBehaviour
{
    [SerializeField] private Text _scoreText = default;
    
    void Start()
    {
        
    }

    void Update()
    {
        if(_scoreText) _scoreText.text = 
            GameManager.Instance.ScoreManager.CurrentScore.ToString("00");
    }
}
