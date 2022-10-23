public class GoldActivate : MonoBehaviour
{
    [SerializeField] private UnityEvent _reached;

    private float _destroyGold = 0.5f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Player>(out Player player))
        {
            gameObject.SetActive(true);
            _reached?.Invoke();
            Destroy(gameObject, _destroyGold);
        }
    }
}
