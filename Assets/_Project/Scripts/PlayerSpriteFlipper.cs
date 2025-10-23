using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class PlayerSpriteFlipper : MonoBehaviour
{
    private SpriteRenderer _spriteRenderer;

    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void Flip(float horizontInput)
    {
        if(horizontInput != 0)
        {
            _spriteRenderer.flipX = horizontInput < 0;
        }
    }
}
