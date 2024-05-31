using UnityEngine;
/// <summary>
/// アイテム生成、配置
/// </summary>
public class GenerateItem : ObjectPool
{
    [Header("生成するZ距離の間隔"), Tooltip("生成するZ距離の間隔")] 
    [SerializeField] float _distanceSpacing = 5f;
    [Header("先頭の場所"), Tooltip("先頭の場所")] 
    [SerializeField] private GameObject _launchPoint = default;
    [Header("振幅"), Tooltip("振幅")] 
    [SerializeField] private float _amplitude = 2f;
    
    protected override void OnStart()
    {
        var vec = _launchPoint.transform.position;
        for (int i = 0; i < _value; i++)
        {
            var go = Launch();
            var x = Mathf.Sin(Time.time + i);
            go.transform.position = vec + new Vector3(x * _amplitude, 0, i * _distanceSpacing);
        }
    }
}
