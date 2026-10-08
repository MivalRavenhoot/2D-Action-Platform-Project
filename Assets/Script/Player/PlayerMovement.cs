using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements.Experimental;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public PlayerInput playerInput;
    public Vector2 moveInput;
    public int facingDirection = 1;
    [SerializeField] float Speed = 8f;
    [SerializeField] float JumpPower = 16;

    void Update()
    {
        Flip();
    }
    
    private void FixedUpdate()
    {
        float targetSpeed = moveInput.x * Speed;
        rb.linearVelocity = new Vector2(targetSpeed, rb.linearVelocity.y);
    }

    public void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }

    void Flip()
    {
        if(moveInput.x > 0.1f)
        {
            facingDirection = 1;
        }
        else if(moveInput.x < -0.1f)
        {
            facingDirection = -1;
        }

        transform.localScale = new Vector3(facingDirection, 1, 1);
    }
}
