using UnityEngine;
using System.Collections;

public class ArrowTrigger : MonoBehaviour
{
    private GameObject m_camera;
    private Transform m_cameraPosition;

    void Start()
    {
        m_camera = GameObject.FindGameObjectWithTag("MainCamera");
        m_cameraPosition = m_camera.transform;
    }
    void OnTriggerStay2D()
    {
        //Récuperer TOUT les arrow shooters.
        GameObject[] ArrowShooters = GameObject.FindGameObjectsWithTag("ArrowShooter");

        foreach(GameObject ArrowShooter in ArrowShooters)
        {
            //Activer le ArrowShooter UNIQUEMENT si il se trouve dans le champ de vision de la camera.
            if(ArrowShooter.transform.position.x < m_cameraPosition.position.x + 15 &&
               ArrowShooter.transform.position.x > m_cameraPosition.position.x - 15 &&
               ArrowShooter.transform.position.y < m_cameraPosition.position.y + 10 &&
               ArrowShooter.transform.position.y > m_cameraPosition.position.y - 10)
            {
                ShootArrowBehavior b = ArrowShooter.GetComponent<ShootArrowBehavior>();
                b.m_canShoot = true;
            }
           
        }
    }
}
