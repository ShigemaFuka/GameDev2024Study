using System;
using UnityEngine;
/// <summary>
/// アイテム機能
/// 消える
/// </summary>
public class Item : MonoBehaviour
{
    private GenerateItem _generateItem = default;
    
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
            _generateItem.Collect(gameObject);
        }
    }
}
