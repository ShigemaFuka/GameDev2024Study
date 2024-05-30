using UnityEngine;

/// <summary>
/// 前方への強制移動、左右移動の制限
/// </summary>
public class Move : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidBody;
    [SerializeField] private bool _isStop = false;
    [SerializeField] private Vector3 _forwardDirection = new Vector3(0, 0, 1.0f);
    [SerializeField] private float _speed = 5f;
    [Tooltip("左右移動範囲 0:left, 1:right")] 
    [SerializeField] private GameObject[] _rangePoints = default;
    [Tooltip("0:left, 1:right")] private float[] _rangeValues = default;
    
    private void Awake()
    {
        _rigidBody = GetComponent<Rigidbody>();
        _isStop = false;
        _rangeValues = new float[_rangePoints.Length];
        for (int i = 0; i < _rangePoints.Length; i++)
        {
            _rangeValues[i] = _rangePoints[i].transform.position.x;
        }
    }

    private void Update()
    {
        //TODO : 移動せよ
        //https://candle-stoplight-544.notion.site/4e021f226d584730b715626436ccc330
        if(!_isStop) _rigidBody.velocity = _forwardDirection * _speed;
        else _rigidBody.velocity = Vector3.zero;

        var h = Input.GetAxis("Horizontal");
        XMove(h);
        XRange();
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Goal")) _isStop = true;
    }

    /// <summary> 左右移動 </summary>
    private void XMove(float value)
    {
        if(_isStop) return;
        var velocity = _rigidBody.velocity;
        _rigidBody.velocity = new Vector3(value * 30f, velocity.y, velocity.z);
    }

    /// <summary> 左右移動範囲の制限 </summary>
    private void XRange()
    {
        var pos = transform.position;
        var x = pos.x;
        if (x < _rangeValues[0])
            transform.position = new Vector3(_rangeValues[0], pos.y, pos.z);
        else if (x > _rangeValues[1])
            transform.position = new Vector3(_rangeValues[1], pos.y, pos.z);
    }
}