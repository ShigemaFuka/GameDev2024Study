using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    [SerializeField, Tooltip("生成したいプレハブ")] private GameObject _prefab = default;
    [Tooltip("生成したプレハブを格納するQueue")] protected Queue<GameObject> PrefabQueue = default;
    [SerializeField, Tooltip("生成しておく数")] protected int _value = 10;
    [SerializeField, Tooltip("親オブジェクト(空)")] private GameObject _spawnsParent = default;
    
    void Start()
    {
        PrefabQueue = new Queue<GameObject>();
        for (int i = 0; i < _value; i++)
        {
            GameObject go = Instantiate(_prefab, _spawnsParent.transform);
            PrefabQueue.Enqueue(go); //Queueに追加 
            go.SetActive(false);
        }

        OnStart();
    }
    protected virtual void OnStart(){}
    
    /// <summary>
    /// queueへ格納する
    /// 格納時に非アクティブにする
    /// </summary>
    /// <param name="go">対象のオブジェクト</param>
    public void Collect(GameObject go)
    {
        go.gameObject.SetActive(false);
        PrefabQueue.Enqueue(go); //Queueに格納
    }
    
    /// <summary>
    /// Nullでなければqueueから取り出す
    /// </summary>
    /// <returns>取り出したオブジェクトかNull</returns>
    protected GameObject Launch()
    {
        if (PrefabQueue.Count <= 0) return null; //Queueが空ならnull
        //Queueからオブジェクトを一つ取り出す
        GameObject go = PrefabQueue.Dequeue();
        go.gameObject.SetActive(true);
        return go; //呼び出し元に渡す
    }
}
