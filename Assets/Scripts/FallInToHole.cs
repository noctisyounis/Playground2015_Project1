using UnityEngine;
using System.Collections;

public class FallInToHole : MonoBehaviour {

    private Vector2 StartPoint;
    private GameObject Trigger;
    private GameObject Player;
    private Sprite PlayerTomber; // Joue Hero qui Tombe
    private Sprite PlayerDefaut; // Réactive sprite du joueur.
    private bool PlayerFell = false;
    private bool EstToucher = false;

    private Color CubeColorOn;
    private Color CubeColorOff;
    private bool fadingIn;
    float Timer;
    float tmpDeltaTime;
    //private float StartpointX = 24.7f;
    //private float StartpointY = -16.3f;

    void Start()
    {
        //Player = GameObject.FindGameObjectWithTag("Player");
        
        Trigger = GameObject.FindGameObjectWithTag("Trigger");
       

        //  _InitialPositionTrigger = GetComponent<Vector2>();
    }

    void FixedUpdate()
    {
        
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.tag == "Hole")
        {




        }
    }

}
