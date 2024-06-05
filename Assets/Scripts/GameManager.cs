
public class GameManager : SingletonMonoBehaviour<GameManager>
{
    #region 変数
    
    private ScoreManager _scoreManager = default;
    
    #endregion
    
    #region プロパティ

    public ScoreManager ScoreManager => _scoreManager;

    #endregion
    
    protected override void OnAwake()
    {
        _scoreManager = FindObjectOfType<ScoreManager>();
    }
    
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
