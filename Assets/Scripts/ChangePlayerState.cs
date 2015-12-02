using UnityEngine;
using System.Collections;

public class ChangePlayerState : MonoBehaviour {

    private SpriteRenderer m_playerSprite;
    public bool m_isTouchingTotem = false;
    public Sprite m_normalState;
    public Sprite m_specterState;
    public bool m_isNormal = true;

	// Use this for initialization
	void Start ()
    {
        m_playerSprite = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        //Changer le sprite du joueur selon l'etat dans lequel is est.
        if (m_isTouchingTotem)
        {           
            if (Input.GetKeyDown(KeyCode.W))
            {
                if (m_isNormal)
                {
                    m_playerSprite.sprite = m_specterState;
                    m_isNormal = false;
                }

                else
                {
                    m_playerSprite.sprite = m_normalState;
                    m_isNormal = true;
                }
            }
        }
        
	}
}
