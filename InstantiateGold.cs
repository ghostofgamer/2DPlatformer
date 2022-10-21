public class InstantiateGold : MonoBehaviour
{
    [SerializeField] private GameObject _template;
    [SerializeField] private Transform _path;

    private Transform[] _points;

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
        var WaitForSeconds = new WaitForSeconds(2f);

        for (int i = 0; i < _points.Length; i++)
        {
            GameObject newGameObject = Instantiate(_template, _points[i].position, Quaternion.identity);
            yield return WaitForSeconds;
        }
    }
}
