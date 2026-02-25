using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private PlayerINput input;
    public Vector2 move;
    public Rigidbody2D rb;
    public float Speed;

    private void Awake()
    {
        input = new PlayerINput();
    }

    private void OnEnable()
    {
        input.Enable();
    }

    private void OnDestroy()
    {
        input.Disable();
    }

    private void OnDisable()
    {
        input.Disable();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         move = input.Player.Move.ReadValue<Vector2>();
        Debug.Log(move);
       
    }
    private void FixedUpdate()
    {
        rb.velocity = move * Speed;
    }
}
