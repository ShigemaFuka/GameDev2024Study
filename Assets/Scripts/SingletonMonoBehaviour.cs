using UnityEngine;
using System;

/// <summary>
/// https://islingtonsystem.hatenablog.jp/entry/2022/06/02/042736
/// </summary>
/// <typeparam name="T"></typeparam>
public abstract class SingletonMonoBehaviour<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T _instance = default;

    public static T Instance
    {
        get
        {
            if (_instance) return _instance;
            Type t = typeof(T);
            // 継承先のスクリプトをアタッチしているオブジェクトを検索
            _instance = (T)FindObjectOfType(t);
            if (!_instance)
                Debug.LogError(t + " がアタッチされているオブジェクトがありません");
            return _instance;
        }
    }

    private void Awake()
    {
        if (this != Instance)
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);
        OnAwake();
    }
    
    protected virtual void OnAwake(){}

    protected virtual void OnDestroy()
    {
        // 破棄された場合は実体の削除を行う
        if (this == Instance)
        {
            _instance = null;
        }
    }
}