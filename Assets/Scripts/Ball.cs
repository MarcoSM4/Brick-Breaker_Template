using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public float BallR;
    public bool Empezo = false;
    public UI ui;

    // Start is called before the first frame update
    void Start()
    {
        ui = GameObject.FindWithTag("ui").GetComponent<UI>();

    }

    // Update is called once per framew
    void Update()
    {
        Empezar();
    }
    public void Empezar()
    {
        if (Input.GetKeyDown(KeyCode.Space) && Empezo == false)
        {
            transform.SetParent(null);
            rb2d.isKinematic = false;
            rb2d.AddForce(new Vector2(BallR, BallR));
            Empezo = true;

        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Caida")
        {
            ui.UpdateVidas();
            
        }
    }


}

