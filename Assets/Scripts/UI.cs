using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class UI : MonoBehaviour
{

    public int Score = 0;

    public Text ScoreText;

    public int Vidas = 3;

    public Text VidasT;

    public GameObject _ball;
    private Ball ball;

    public GameObject _player;

    public GameObject Ganar;
    public GameObject Perder;


    // Start is called before the first frame update
    void Start()
    {
        ball = GameObject.FindWithTag("Ball").GetComponent<Ball>();

    }

    // Update is called once per frame
    void Update()
    {
        GanarPartida();
        PerderPartida();
    }

    public void UpdateScore()
    {
        Score += 10;
        ScoreText.text = "Score: " + Score;
    }

    public void UpdateVidas()
    {
        Vidas--;
        VidasT.text = "Vidas: " + Vidas;
        _ball.SetActive(false);
        _player.transform.position = new Vector3(0, -3.5f, 0);
        _ball.transform.position = new Vector3(0, -3.13f, 0);

        _ball.SetActive(true);
        ball.Empezo = false;
        _ball.transform.parent = _player.transform;

    }

    public void GanarPartida()
    {
        if (Score == 100)
        {
            Ganar.SetActive(true);
        }
    }

    public void PerderPartida()
    {
        if (Vidas == 0)
        {
            Perder.SetActive(true);
        }
    }
    
}
