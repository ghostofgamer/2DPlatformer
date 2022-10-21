public class WaypointMovement : MonoBehaviour
{
    [SerializeField] private Transform _path;
    [SerializeField] private float _speed;
    [SerializeField] private SpriteRenderer _renderer;

    private Transform[] _points;
    private int _currentPoint;

    private void Start()
    {
        _points = new Transform[_path.childCount];

        for (int i = 0; i < _path.childCount; i++)
        {
            _points[i] = _path.GetChild(i);
        }
    }

    private void Update()
    {
        if (_currentPoint == 0)
        {
            bool flip = false;
            GetPosition(flip);
        }

        else
        {
            bool flip = true;
            GetPosition(flip);
        }
    }

    private void GetPosition(bool flip)
    {
        Transform target = _points[_currentPoint];
        var direction = (target.position - transform.position).normalized;
        transform.position = Vector3.MoveTowards(transform.position, target.position, _speed * Time.deltaTime);

        _renderer.flipX = flip;

        if (transform.position == target.position)
        {
            _currentPoint++;

            if (_currentPoint >= _points.Length)
            {
                _currentPoint = 0;
            }
        }
    }
}
