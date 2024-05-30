using UnityEngine;
/// <summary>
/// アイテム生成
/// </summary>
public class GenerateItem : ObjectPool
{
    [SerializeField, Tooltip("生成する距離の間隔")] float _distanceSpacing = 5f;
    [SerializeField, Tooltip("先頭の場所")] private GameObject _launchPoint = default;
    
    protected override void OnStart()
    {
        var vec = _launchPoint.transform.position;
        for (int i = 0; i < _value; i++)
        {
            var go = Launch();
            go.transform.position = vec + new Vector3(0, 0, i * _distanceSpacing);
        }
    }
}
