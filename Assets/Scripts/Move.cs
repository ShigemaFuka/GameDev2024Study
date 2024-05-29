using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] Rigidbody _rigidBody;
    [SerializeField] bool isStop = false;
    [SerializeField] private Vector3 _direction = new Vector3(0, 0, 1.0f);
    [SerializeField] private float _speed = 5f;

    void Awake()
    {
        _rigidBody = GetComponent<Rigidbody>();
        isStop = false;
        if(GameObject.FindGameObjectsWithTag("Goal") == null)
            Debug.LogWarning("[Goal]タグが見つかりませんでした。");
    }

    void Update()
    {
        //TODO
        //移動せよ プレイヤーが自動で進み、ゴールまで向かう処理
        //https://candle-stoplight-544.notion.site/4e021f226d584730b715626436ccc330
        
        if(!isStop) _rigidBody.velocity = _direction * _speed;
        else _rigidBody.velocity = Vector3.zero;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Goal")) isStop = true;
    }
}