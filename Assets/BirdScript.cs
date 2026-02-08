using UnityEngine;
using UnityEngine.InputSystem;


public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicScript logic;
    public bool birdIsAlive = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            Debug.Log("SPACE ALGILANDI");
        }

        if (Keyboard.current.spaceKey.wasPressedThisFrame && birdIsAlive==true)
        {
            myRigidbody.linearVelocity = Vector2.up * flapStrength;
         }
            
        }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("collision");
        logic.gameOver();
        birdIsAlive = false;
    }
}
