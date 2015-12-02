using UnityEngine;
using System.Collections;

public class InvisibleFloorBehavior : MonoBehaviour {

    private SpriteRenderer m_spriteRenderer;
    private Sprite m_sprite;
    private int m_showTimer = 1;
    private int m_timer = 10;

	// Use this for initialization
	void Start ()
    {
        m_spriteRenderer = GetComponent<SpriteRenderer>();
        m_sprite = m_spriteRenderer.sprite;
        m_spriteRenderer.enabled = false;
        StartCoroutine(ShowTiles());

    }

    IEnumerator ShowTiles()
    {
        while (true)
        {
            m_spriteRenderer.enabled = true;

            yield return new WaitForSeconds(1);

            m_spriteRenderer.enabled = false;

            yield return new WaitForSeconds(10);
        }     
    }
}
