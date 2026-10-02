using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    [SerializeField] float JumpPower = 16;
    [SerializeField] float Speed = 8f;
    private int direzione;

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.rightArrowKey.isPressed)
        {
            direzione = 1;
        } else if (Keyboard.current.leftArrowKey.isPressed)
        {
            direzione = -1;
        } else
        {
            direzione = 0;
        }

        if (direzione != 0)
        {
            transform.localScale = new Vector3(direzione, 1, 1);
        }
    }

    private void FixedUpdate()
    {
        rb.linearVelocity = new UnityEngine.Vector2(direzione * Speed, rb.linearVelocity.y);
    }
}
