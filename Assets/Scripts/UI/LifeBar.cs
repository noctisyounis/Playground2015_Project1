using UnityEngine;
using System.Collections;

public class LifeBar : MonoBehaviour 

{
	#region Properties

	public Sprite[] m_lifeIcon = new Sprite[4];
    public GameObject target;

    private Stats m_playerStats;
    private int m_life;
    private SpriteRenderer m_spriteRenderer;


	#endregion
	// Use this for initialization

	#region Main Methods

	void Start()
	{
		target = GameObject.FindGameObjectWithTag("Player");
        m_spriteRenderer = GetComponent<SpriteRenderer>();
        m_playerStats = target.GetComponent<Stats> ();
        m_life = m_playerStats.m_life;
    }

	// Update is called once per frame
	void Update () 
	{
		m_life = m_playerStats.m_life;
        m_spriteRenderer.sprite = m_lifeIcon[m_life];			
	}
	#endregion

}
