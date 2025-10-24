using UnityEngine;

[RequireComponent(typeof(Rigidbody2D), typeof(Flipper))]
public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Rigidbody2D _rigidbody2D;
    private Flipper _flipper;

    private Vector2 _moveDirection = Vector2.right;

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _flipper = GetComponent<Flipper>();
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        _rigidbody2D.linearVelocity = _moveDirection * _speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Ground ground))
        {
            _flipper.Flip();
            _moveDirection = -_moveDirection;
        }
    }
}
