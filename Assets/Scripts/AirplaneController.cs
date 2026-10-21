using UnityEngine;
using UnityEngine.InputSystem;

public class AirplaneController : MonoBehaviour
{
    [SerializeField] float moveSpeed = 12f;
    [SerializeField] float turnSpeed = 90f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current == null) return;

        float forward = 0f;
        float turn = 0f;

        if (Keyboard.current.wKey.isPressed || Keyboard.current.upArrowKey.isPressed)
            forward -= 1f;
        if (Keyboard.current.sKey.isPressed || Keyboard.current.downArrowKey.isPressed)
            forward += 1f;

        if (Keyboard.current.dKey.isPressed || Keyboard.current.rightArrowKey.isPressed)
            turn += 1f;
        if (Keyboard.current.aKey.isPressed || Keyboard.current.leftArrowKey.isPressed)
            turn -= 1f;

        transform.Rotate(Vector3.up, turn * turnSpeed * Time.deltaTime, Space.World);
        transform.position += transform.forward * (forward * moveSpeed * Time.deltaTime);
    }
}
