using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{

    public float m_speed = 5.0f;
    public string m_axisV = "Vertical";
    public string m_axisH = "Horizontal";

    void Start()
    {
        m_RB = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float axisH = Input.GetAxisRaw(m_axisH);
        float axisV = Input.GetAxisRaw(m_axisV);
        m_RB.velocity = new Vector2(axisH, axisV) * m_speed;

    }

    private Rigidbody2D m_RB;
}
