using System;
using UnityEngine;
/// <summary>
/// アイテム機能
/// 消える
/// </summary>
public class Item : MonoBehaviour
{
    private GenerateItem _generateItem = default;
    [Tooltip("スコア"), SerializeField] private float _scoreValue = 5f;
    
    void Start()
    {
        _generateItem = FindObjectOfType<GenerateItem>();
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GameManager.Instance.ScoreManager.AddScore(_scoreValue);
            _generateItem.Collect(gameObject);
        }
    }
}
