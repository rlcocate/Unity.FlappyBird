using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlappyBird : MonoBehaviour {

    public float _impulso;
    Rigidbody2D _rb;

	// Use this for initialization
	void Start () {
        
        // Instancia component RigidBody 2D.
        _rb = GetComponent<Rigidbody2D>();

    }
	
	// Update is called once per frame
	void Update () {

        // Aplica uma força linear no eixo Y quando a barra de espaço for pressionada.
	    if (Input.GetButtonDown("Jump"))
        {
            _rb.velocity = new Vector2(0.0f, _impulso);
        }	
	}
}
