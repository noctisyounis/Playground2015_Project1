using UnityEngine;
using System.Collections;

public class Stats : MonoBehaviour 
{
	#region Properties
	public int m_lifeMax = 3;
	public int m_life;
	public bool m_isDead = false;
	public bool m_isSpectral;
	public int m_PowerDamage;
	public float m_speedVelocity;

	#endregion

	# region Main Method

	// Initialization
	void Start () 
	{
		m_life = m_lifeMax;
	}
	
	// Update
	void Update () 
	{
		LifeCheck ();
	}
	#endregion

	#region Public Method
	// USE Check the MIN and MAX LIFE stay between 0 & 3 ;
	void LifeCheck()
	{
			if (m_life <= 0) {
				m_isDead = true;
				m_life = 0;
			
			}
			if (m_life > 0) {
				m_isDead = false;
			
				if (m_life > 3) {
					m_life = 3;
				}
			}
	}
	public void isDamage (int damage)
	{
		m_life -= damage;
		LifeCheck ();

	}


	#endregion
}
