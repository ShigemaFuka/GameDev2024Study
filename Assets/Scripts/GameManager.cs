using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region 変数
    
    public static GameManager Instance = default;
    private ScoreManager _scoreManager = default;
    
    #endregion
    
    #region プロパティ

    public ScoreManager ScoreManager => _scoreManager;

    #endregion
    
    void Awake()
    {
        if (!Instance) Instance = this;
        _scoreManager = FindObjectOfType<ScoreManager>();
    }
    
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
