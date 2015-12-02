using UnityEngine;
using System.Collections;

public class InterruptorBehavior : MonoBehaviour {

    private SpriteRenderer m_interruptorSprite;
    public bool m_isActive = false;

    public Sprite m_inactiveState;
    public Sprite m_activeState;

    public bool m_stayActive = true;

    // Use this for initialization
    void Start()
    {
        m_interruptorSprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        //Pour éviter que les ennemis activent l'interupteur.
        if (other.tag == "Player" || other.tag == "Block")
        {
            m_interruptorSprite.sprite = m_activeState;
            m_isActive = true;
        }
    }

    void OnTriggerExit2D()
    {
        //Si l'interupteur n'est PAS de type ("reste activé") on le désactive quand il ny a plus rien dessus.
        if (!m_stayActive)
        {
            m_interruptorSprite.sprite = m_inactiveState;
            m_isActive = false;
        }
    }
}
