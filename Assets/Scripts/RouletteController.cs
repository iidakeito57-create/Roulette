using UnityEngine;
using UnityEngine.InputSystem;

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 0f;
    public float speed = 10f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            this.rotSpeed = speed;
        }
        transform.Rotate(0, 0, this.rotSpeed);

        this.rotSpeed *= 0.98f;
    }
}
