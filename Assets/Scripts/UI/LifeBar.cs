using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Stats))]
public class LifeBar : MonoBehaviour 

{
	#region Properties

	public Sprite[] m_lifeIcon = new Sprite[4];
	public int m_life;
	public GameObject target;


	#endregion
	// Use this for initialization

	#region Main Methods

	void Start()
	{
		target = GameObject.FindGameObjectWithTag("Player");

		m_life = target.GetComponent<Stats> ().m_life;
	}

	// Update is called once per frame
	void Update () 
	{
		m_life = target.GetComponent<Stats> ().m_life;
		GetComponent<SpriteRenderer>().sprite = m_lifeIcon[m_life];

	}
	#endregion

	#region Private Properties
	#endregion
}
