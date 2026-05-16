using UnityEngine;
using UnityEngine.InputSystem;

public class playerMovement : MonoBehaviour
{
    Vector2 vec = Vector2.zero;
    float speed = 10;
    void Update()
    {
        if (Keyboard.current.aKey.isPressed && Keyboard.current.dKey.isPressed)
        {
            vec.x = 0;
        }
        else if (Keyboard.current.aKey.isPressed)
        {
            vec.x = -1;
        }
        else if (Keyboard.current.dKey.isPressed)
        {
            vec.x = 1;
        }
        else
        {
            vec.x = 0;
        }

        if (Keyboard.current.wKey.isPressed && Keyboard.current.sKey.isPressed)
        {
            vec.y = 0;
        }
        else if (Keyboard.current.wKey.isPressed)
        {
            vec.y = 1;
        }
        else if (Keyboard.current.sKey.isPressed)
        {
            vec.y = -1;
        }
        else
        {
            vec.y = 0;
        }

        vec = vec.normalized; //Keeps the movement speed constant even on diagonal movement
        transform.position += new Vector3(vec.x, vec.y, 0) * speed * Time.deltaTime;
    }
}
