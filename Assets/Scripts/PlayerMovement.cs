using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D _rb2d;
    private Vector2 _direction;
    public float _movespeed = 20f;
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
        _direction.x = Input.GetAxisRaw("Horizontal") * _movespeed;   
    }
    // is called after heach frame update
    void FixedUpdate()
    {
        _rb2d.velocity = _direction;
    }
}
