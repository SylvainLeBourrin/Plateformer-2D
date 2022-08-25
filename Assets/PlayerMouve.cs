using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMouve : MonoBehaviour
{
    private Rigidbody2D _rb2d;
    private Vector2 _direction;
    public float _movespeed = 20f;
    private float mytime;
    //public bool jumpInput;
    public float m_Thrust = 400f;
    private Vector2 moveDirection = Vector2.zero;
    public float HauteurSaut = 4.5f; // hauteur général d'un saut


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
        //_direction.y = _rb2d.velocity.y;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            moveDirection.y = new Vector2 (_direction,HauteurSaut);
            Debug.Log("appuis sur espace");
           
        }
    }
    // is called after heach frame update
    void FixedUpdate()
    {
        _rb2d.velocity = _direction;
        // Ne pas permetre le multi saut -
        // ligne de code , détecter si _rb2d est en contact avec le sol
        // Si en contacte , permetre le saut
        // si pas en contacte , ne pas permetre le saut.
      



    }
}

