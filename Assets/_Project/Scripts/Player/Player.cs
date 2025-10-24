using UnityEngine;

[RequireComponent(typeof(PlayerMovement), typeof(PlayerAnimation), typeof(Flipper))]
public class Player : MonoBehaviour
{
    [SerializeField] private JumpChecker _jumpChecker;

    private PlayerMovement _playerMovement;
    private PlayerAnimation _playerAnimation;
    private Flipper _flipper;

    private void Awake()
    {
        _playerAnimation = GetComponent<PlayerAnimation>();
        _playerMovement = GetComponent<PlayerMovement>();
        _flipper = GetComponent<Flipper>();
    }

    private void Update()
    {
        //_playerSpriteFlipper.Flip(_playerMovement.GetHorizontalInput());
        _flipper.FlipToDirection(_playerMovement.GetHorizontalInput());
        _playerAnimation.SetSpeed(_playerMovement.Rigidbody2D.linearVelocityX);
        _playerAnimation.SetIsJumping(_jumpChecker.CanJump == false && _playerMovement.Rigidbody2D.linearVelocityY > 0);
        _playerAnimation.SetIsFalling(_jumpChecker.CanJump == false && _playerMovement.Rigidbody2D.linearVelocityY < 0);
    }
}
