using UnityEngine;

public class Flipper : MonoBehaviour
{
    [SerializeField] private bool _isFacingRight = true;

    public void FlipToDirection(float horizontalInput)
    {
        if (horizontalInput > 0 && !_isFacingRight)
        {
            Flip();
        }
        else if (horizontalInput < 0 && _isFacingRight)
        {
            Flip();
        }
    }

    public void Flip()
    {
        _isFacingRight = !_isFacingRight;
        Vector3 localScale = transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
    }
}
