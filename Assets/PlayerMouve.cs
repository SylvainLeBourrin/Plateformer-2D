using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMouve : MonoBehaviour
{
    private Rigidbody2D _rb2d;
    private Vector2 _direction;
    public float _movespeed = 20f;
    private float mytime;
    public bool jumpInput;
    public float m_Thrust = 400f;

    // Start is called at the begening of everything
    void Awake()
    {
        _rb2d = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        _direction.x = Input.GetAxis("Horizontal") * _movespeed;
        _direction.y = _rb2d.velocity.y;
        mytime = Time.deltaTime * 1000f;
        jumpInput = Input.GetButtonDown("Jump"); 
    }
    // is called after heach frame update
    void FixedUpdate()
    {
        _rb2d.velocity = _direction;
        // Ne pas permetre le multi saut -
        // ligne de code , détecter si _rb2d est en contact avec le sol
        // Si en contacte , permetre le saut
        // si pas en contacte , ne pas permetre le saut.
        if (jumpInput)
        {
            Vector2 jump = (new Vector2(0, m_Thrust) * mytime);
            //Apply a force to this Rigidbody in direction of this GameObjects up axis
            _rb2d.AddForce(jump);
            Debug.Log(jump);
        }
    }
}

