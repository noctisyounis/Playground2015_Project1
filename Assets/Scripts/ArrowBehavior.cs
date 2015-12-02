using UnityEngine;
using System.Collections;

public class ArrowBehavior : MonoBehaviour {

    public float m_arrowSpeed = 10.0f;
	
	// Update is called once per frame
	void Update ()
    {
            MoveArrow();   
    }

   
    void MoveArrow()
    {
        transform.position += transform.forward * m_arrowSpeed;
    }
}
