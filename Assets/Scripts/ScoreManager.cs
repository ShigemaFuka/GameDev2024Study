using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private float _currentScore = 0f;
    
    public float CurrentScore => _currentScore;
    
    void Start()
    {
    }

    void Update()
    {
    }

    /// <summary> スコア加算 </summary>
    public void AddScore(float value)
    {
        _currentScore += value;
    }
}
