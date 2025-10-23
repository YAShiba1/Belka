using UnityEngine;

[RequireComponent(typeof(AudioSource), typeof(SpriteRenderer), typeof(BoxCollider2D))]
public class Crystal : MonoBehaviour
{
    private AudioSource _audioSource;
    private SpriteRenderer _spriteRenderer;
    private BoxCollider2D _boxCollider2D;

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _boxCollider2D = GetComponent<BoxCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Player player))
        {
            _audioSource.Play();

            _spriteRenderer.enabled = false;
            _boxCollider2D.enabled = false;
        }
    }
}
