using UnityEngine;
using System.Collections;

public class SkeletonMove : MonoBehaviour 
{
	#region Public Variable
	public Transform m_target;// Cible à définir dans unity (Héros de la scene)
	public float m_speed;
    public float m_actionRadius = 8.0f;
    public Animator m_animator;

    private bool m_isLookingUp = false;
    private bool m_isLookingLeft = false;
    private bool m_isLookingRight = false;
    private bool m_isLookingDown = false;
    #endregion

    //-----------------------------------------------------------

    #region Methods
    //TODO Ne doit pas changer de salle
    void Start()
	{
		m_target = GameObject.FindWithTag("Player").transform;
        m_animator = GetComponent<Animator>();
		SkeletonRB = GetComponent<Rigidbody2D> ();
    }

	void Update()
	{

        Vector3 dir = m_target.transform.position - transform.position;
        dir = m_target.transform.InverseTransformDirection(dir);
        angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        angle = angle + 180;

        //Déplacement vers le Player
        if (Vector2.Distance(transform.position,m_target.position) < m_actionRadius)
		{
            m_isMoving = true;
            m_animator.SetBool("IsWalking", true);

			SkeletonRB.velocity = (m_target.transform.position - transform.position).normalized * m_speed * Time.deltaTime;
			print(m_speed);
			print(m_target.transform.position - transform.position);
            //transform.position = Vector2.MoveTowards(transform.position,m_target.position,m_speed * Time.deltaTime);

            if(angle > 225 && angle < 315 && m_isMoving)
            {              
                m_animator.CrossFade("SkeletonWalkingUp", 0);
                m_isLookingUp = true;
                m_isLookingLeft = false;
                m_isLookingRight = false;
                m_isLookingDown = false;
            }
            
            if(angle > 135 && angle < 225 && m_isMoving)
            {
                m_animator.CrossFade("SkeletonWalkingRight", 0);
                m_isLookingUp = false;
                m_isLookingLeft = false;
                m_isLookingRight = true;
                m_isLookingDown = false;
            }

            if(angle > 45 && angle < 135 && m_isMoving)
            {
                m_animator.CrossFade("SkeletonWalkingDown", 0);
                m_isLookingUp = false;
                m_isLookingLeft = false;
                m_isLookingRight = false;
                m_isLookingDown = true;
            }

            if((angle >= 0 && angle < 45 || angle > 315 && angle <= 360) && m_isMoving)
            {
                m_animator.CrossFade("SkeletonWalkingLeft", 0);
                m_isLookingUp = false;
                m_isLookingLeft = true;
                m_isLookingRight = false;
                m_isLookingDown = false;
            }
        }

        else if(Vector2.Distance(transform.position, m_target.position) > m_actionRadius)
        {
            m_animator.SetBool("IsWalking", false);
            m_isMoving = false;
			SkeletonRB.isKinematic = true;
			SkeletonRB.isKinematic = false;

            if (m_isLookingUp)
            {
                m_animator.CrossFade("SkeletonIdleUp", 0);
            }

            if (m_isLookingLeft)
            {
                m_animator.CrossFade("SkeletonIdleLeft", 0);
            }

            if (m_isLookingRight)
            {
                m_animator.CrossFade("SkeletonIdleRight", 0);
            }

            if (m_isLookingDown)
            {
                m_animator.CrossFade("SkeletonIdleDown", 0);
            }
        }        
    }

    void StopSkeleton()
    {

    }

    void OnGUI()
    {
        GUILayout.Button("Angle: " + angle);
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(m_target.position, transform.position);
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, 8);
    }

    string m_debug;
    float angle;
    bool m_isMoving = false;
	Rigidbody2D SkeletonRB;
    #endregion
}
