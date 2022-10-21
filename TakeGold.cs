public class TakeGold : MonoBehaviour
{
    [SerializeField] private UnityEvent _reached;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Player>(out Player player))
        {
            gameObject.SetActive(true);
            _reached?.Invoke();
            Destroy(gameObject,0.5f);
        }
    }
}
