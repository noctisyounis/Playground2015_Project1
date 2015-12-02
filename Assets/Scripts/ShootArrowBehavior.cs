using UnityEngine;
using System.Collections;

public class ShootArrowBehavior : MonoBehaviour
{
    public bool m_canShoot = false;
    public GameObject m_arrow;

    private int m_timer = 1;
    private float m_arrowPositionX;
    private float m_arrowPositionY;
    private bool m_spawnerActive = false;

    

    // Use this for initialization
    void Start ()
    {
        //Définir la position de départ de la fleche (ArrowShooter).
        m_arrowPositionX = transform.position.x;
        m_arrowPositionY = transform.position.y;
    }
	
	// Update is called once per frame
	void Update ()
    {
        //Si il peut tirer (trigger activé) ET qu'il n'est pas deja en train de tirer
        if (m_canShoot && !m_spawnerActive)
        {
            //On lance la coroutine (Methode qui se rappelle elle meme toutes les X secondes)
            StartCoroutine(SpawnArrow());

            m_spawnerActive = true;
        }

        if(!m_canShoot)
        {
            //Pour arreter TOUTES les coroutines.
            StopAllCoroutines();
            //StopCoroutine("nomdelacoroutine")
            m_spawnerActive = false;
        }
    }

    //La methode appellé dans la coroutine
    IEnumerator SpawnArrow()
    {
        while (m_canShoot)
        {
            GameObject arrow = (GameObject)GameObject.Instantiate(m_arrow, new Vector3(m_arrowPositionX, m_arrowPositionY, 0), transform.rotation);
            arrow.transform.parent = this.transform;

            //Pour que la methode attende X secondes avant de se repeller elle meme.
            yield return new WaitForSeconds(m_timer);
        }
    }

}
