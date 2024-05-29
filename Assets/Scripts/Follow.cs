using System;
using UnityEngine;
/// <summary>
/// 追従機能
/// </summary>
public class Follow : MonoBehaviour
{
    [SerializeField, Tooltip("追従対象")] GameObject _target = null;
    [SerializeField, Tooltip("距離")] float _offset = 0f;
    private Vector3 _offsetPos = default;

    void Update()
    {
        _offsetPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, _target.transform.position.z + _offset);
        gameObject.transform.position = _offsetPos;
    }
}
