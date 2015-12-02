using UnityEngine;
using System.Collections;

public class CameraBehavior : MonoBehaviour {

    public GameObject m_player;
    public Camera m_camera;

    public Transform m_roomA1;
    public Transform m_roomA2;
    public Transform m_roomA3;
    public Transform m_roomA4;
    public Transform m_roomA5;
    public Transform m_roomA6;
    public Transform m_roomA7;

    private Transform m_startRoom;

    private Vector3 m_playerStartPosition;
    // Use this for initialization
    void Start ()
    {
        m_startRoom = m_roomA1;

        //Placer le joueur.
        m_playerStartPosition = m_startRoom.transform.position;
        m_playerStartPosition.z = 0;

        //Changer la taille de la camera
        m_camera.orthographicSize = 15;

        //Positioner la camera 
        m_camera.transform.position = m_startRoom.transform.position;

        GameObject player = (GameObject)GameObject.Instantiate(m_player, m_playerStartPosition, m_player.transform.rotation);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
