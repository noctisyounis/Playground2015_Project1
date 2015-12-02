using UnityEngine;
using System.Collections;

public class BlockMove : MonoBehaviour 
{
    private Rigidbody2D m_rigidBody;

	#region Main Method

	void Start()
	{       
        m_rigidBody = GetComponent<Rigidbody2D>();
    }

    //void OnTriggerEnter2D(Collider2D other)
    //{
    //    if(other.tag == "Wall")
    //    {
    //        m_rigidBody.isKinematic = true;
    //    }
    //}
	void OnTriggerStay2D (Collider2D other) 
	{
		if(other.tag == "Player")
		{
            //ENABLE MOVE BLOCK
            m_rigidBody.isKinematic = false;
		}
	}

	void OnTriggerExit2D (Collider2D other) 
	{
		if (other.tag == "Player")
        {
            // DISABLE MOVE BLOCK
            m_rigidBody.isKinematic = true;
		}
	}

	#endregion
}
