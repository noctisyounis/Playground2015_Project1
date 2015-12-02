using UnityEngine;
using System.Collections;

public class ArrowStopTrigger : MonoBehaviour {

    void OnTriggerEnter2D()
    {
        // Arreter TOUT les arrowshooters de la map.
        GameObject[] ArrowShooters = GameObject.FindGameObjectsWithTag("ArrowShooter");

        foreach (GameObject ArrowShooter in ArrowShooters)
        {
            ShootArrowBehavior b = ArrowShooter.GetComponent<ShootArrowBehavior>();
            b.m_canShoot = false;
        }
    }
}
