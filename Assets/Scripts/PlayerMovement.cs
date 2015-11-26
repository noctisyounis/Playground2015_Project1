using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{

    public float m_speed = 5.0f;
    public string m_axisVString = "Vertical";
	public string m_axisHString = "Horizontal";
	public float m_axisH;
	public float m_axisV;


    void Start()
    {
        m_RB = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
		m_axisH = Input.GetAxisRaw(m_axisHString);
		m_axisV = Input.GetAxisRaw(m_axisVString);
		m_RB.velocity = new Vector2(m_axisH, m_axisV) * m_speed;

    }

    Rigidbody2D m_RB;
}

