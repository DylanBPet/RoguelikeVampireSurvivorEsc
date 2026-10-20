using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    float runSpeed;
    public Vector2 movement;

    void Start()
    {

    }

    void Update()
    {


        if (Keyboard.current.leftShiftKey.isPressed)
        {
            transform.position += (Vector3)movement * speed * 1.5f * Time.deltaTime;
        }
        else
        {
            transform.position += (Vector3)movement * speed * Time.deltaTime;
        }
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        movement = context.ReadValue<Vector2>();
    }
}
