using UnityEngine;

public class CharacterMover : MonoBehaviour
{
    public CharacterController controller;
    private Vector3 movement;
    public float speed = 3f, gravity = -8f;
    void Update()
    {
        movement.y = gravity;
        movement.x = speed * Input.GetAxis("Horizontal");
        controller.Move(movement * Time.deltaTime);
    }
}