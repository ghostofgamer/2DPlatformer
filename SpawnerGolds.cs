public class SpawnerGolds : MonoBehaviour
{
    [SerializeField] private Gold _template;
    [SerializeField] private Transform _path;

    private Transform[] _points;
    private float _timeRespawn = 3f;

    private void Start()
    {
        _points = new Transform[_path.childCount];

        for (int i = 0; i < _path.childCount; i++)
        {
            _points[i] = _path.GetChild(i);
        }
        StartCoroutine(Create());
    }

    private IEnumerator Create()
    {
        var WaitForSeconds = new WaitForSeconds(_timeRespawn);

        for (int i = 0; i < _points.Length; i++)
        {
            var newGameObject = Instantiate(_template, _points[i].position, Quaternion.identity);
            yield return WaitForSeconds;
        }
    }
}
