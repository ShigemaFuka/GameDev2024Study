using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private float _currentScore = 0f;
    [SerializeField] private Text _text = default; 
    
    void Start()
    {
        
    }

    void Update()
    {
        _text.text = _currentScore.ToString("00");
    }

    /// <summary> スコア加算 </summary>
    public void AddScore(float value)
    {
        _currentScore += value;
    }
}
