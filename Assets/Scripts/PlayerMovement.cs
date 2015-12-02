using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{

    public float m_speed = 5.0f;
    public string m_axisVString = "Vertical";
	public string m_axisHString = "Horizontal";
	public float m_axisH;
	public float m_axisV;

    private bool m_isLookingUp = false;
    private bool m_isLookingLeft = false;
    private bool m_isLookingRight = false;
    private bool m_isLookingDown = false;

    void Start()
    {
        m_RB = GetComponent<Rigidbody2D>();
        m_animator = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
		m_axisH = Input.GetAxisRaw(m_axisHString);
		m_axisV = Input.GetAxisRaw(m_axisVString);
		m_RB.velocity = new Vector2(m_axisH, m_axisV) * m_speed;



        if(m_axisH > 0 && m_axisV == 0)
        {
            m_animator.SetBool("isWalking", true);
            m_animator.CrossFade("HeroWalkRight", 0);
            m_isLookingUp = false;
            m_isLookingLeft = false;
            m_isLookingRight = true;
            m_isLookingDown = false;
            //m_RB.velocity = new Vector2(m_axisH, m_axisV) * m_speed;
        }

        if (m_axisH < 0 && m_axisV == 0)
        {
            m_animator.SetBool("isWalking", true);
            m_animator.CrossFade("HeroWalkLeft", 0);
            m_isLookingUp = false;
            m_isLookingLeft = true;
            m_isLookingRight = false;
            m_isLookingDown = false;
            //m_RB.velocity = new Vector2(m_axisH, m_axisV) * m_speed;
        }

        if (m_axisV > 0 && m_axisH == 0)
        {
            m_animator.SetBool("isWalking", true);
            m_animator.CrossFade("HeroWalkTop", 0);
            m_isLookingUp = true;
            m_isLookingLeft = false;
            m_isLookingRight = false;
            m_isLookingDown = false;
            //m_RB.velocity = new Vector2(m_axisH, m_axisV) * m_speed;
        }

        if (m_axisV < 0 && m_axisH == 0)
        {
            m_animator.SetBool("isWalking", true);
            m_animator.CrossFade("HeroWalkForward", 0);
            m_isLookingUp = false;
            m_isLookingLeft = false;
            m_isLookingRight = false;
            m_isLookingDown = true;
            //m_RB.velocity = new Vector2(m_axisH, m_axisV) * m_speed;
        }

        if (m_axisV == 0 && m_axisH == 0)
        {
            m_animator.SetBool("isWalking", false);

            if (m_isLookingUp)
            {
                m_animator.CrossFade("HeroIdleTop", 0);
            }

            if (m_isLookingLeft)
            {
                m_animator.CrossFade("HeroIdleLeft", 0);
            }

            if (m_isLookingRight)
            {
                m_animator.CrossFade("HeroIdleRight", 0);
            }

            if (m_isLookingDown)
            {
                m_animator.CrossFade("HeroIdleForward", 0);
            }

        }

    }

    Rigidbody2D m_RB;
    Animator m_animator;
}

