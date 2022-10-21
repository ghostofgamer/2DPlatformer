public class Movement : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _renderer;
    [SerializeField] private float _speed;
    [SerializeField] private Animator _animation;
    [SerializeField] private Rigidbody2D _rigidbody2D;
    [SerializeField] private float _jumpForce;

    private void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(_speed * Time.deltaTime, 0, 0);
            _animation.Play("PlayerRun");
            _renderer.flipX = false;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(_speed * Time.deltaTime * -1, 0, 0);
            _animation.Play("PlayerRun");
            _renderer.flipX = true;
        }

        if (Input.GetKey(KeyCode.Space ))
        {
            _rigidbody2D.AddForce(Vector2.up * _jumpForce);
            _animation.Play("PlayerJump");
        }
    }
}
