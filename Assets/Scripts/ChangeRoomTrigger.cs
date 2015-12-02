using UnityEngine;
using System.Collections;

public class ChangeRoomTrigger : MonoBehaviour {

    #region Public Variables

    //Les transform sont initialiser quand on cree le trigger dans le generateur de level.
    public Transform m_firstRoom;
    public Transform m_secondRoom;
    public GameObject m_player;

    #endregion

    #region Main Methods

    void Start()
    {
        //Mettre la Camera dans une variable.
        m_camera = (Camera)FindObjectOfType(typeof(Camera));

        //Mettre le Player dans une variable.
        m_player = GameObject.FindGameObjectWithTag("Player");

        //Mettre la ,position de la camera dans une variable.  
        m_cameraStartPosition = m_camera.transform.position;
    }

    void FixedUpdate()
    {
        //Tester si la camera peut bouger ET dans quelle direction elle peut bouger. (voir methodes plus bas)
        if (m_cameraCanMoveAtoB)
        {
            MoveCameraAtoB();
        }

        if (m_cameraCanMoveBtoA)
        {
            MoveCameraBtoA();
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        //Si le player touche le trigger, on passe les bool a true pour dire que la camera peut bouger.
        if (other.CompareTag("Player"))
        {

            if (m_camera.transform.position == m_firstRoom.position)
            {
                m_cameraCanMoveAtoB = true;
            }

            else
            {
                m_cameraCanMoveBtoA = true;
            }
        }

    }

    void MoveCameraAtoB() // Changement de salle: Gauche --> Droite    et     Haut -->Bas
    {
        //Faire bouger la camera.
        m_camera.transform.position = Vector3.Lerp(m_camera.transform.position, m_secondRoom.position, 0.2f);

        //Placer le player plus loin que le trigger
        if(m_firstRoom.position.x < m_secondRoom.position.x)
        {
            m_player.transform.position = new Vector3(m_secondRoom.position.x - 17, m_player.transform.position.y, 0);
        }

        if(m_firstRoom.position.y > m_secondRoom.position.y)
        {
            m_player.transform.position = new Vector3(m_player.transform.position.x, m_secondRoom.position.y + 12, 0);
        }

        // Recentrer la camera au milieu de l'ecran.
        if (m_camera.transform.position.x - m_secondRoom.transform.position.x > -0.1f && m_camera.transform.position.x - m_secondRoom.transform.position.x < 0)
        {
            m_camera.transform.position = m_secondRoom.transform.position;         
        }

        if (m_camera.transform.position.y * -1 - m_secondRoom.transform.position.y * -1 > -0.1f && m_camera.transform.position.y * -1 - m_secondRoom.transform.position.y * -1 < 0)
        {
            m_camera.transform.position = m_secondRoom.transform.position;
        }

        //Mettre le bool a false pour arreter de bouger la camera.
        if (m_camera.transform.position == m_secondRoom.position)
        {
            m_cameraCanMoveAtoB = false;
        }

    }

    void MoveCameraBtoA() // Droite --> Gauche et Bas --> Haut
    {
        m_camera.transform.position = Vector3.Lerp(m_camera.transform.position, m_firstRoom.position, 0.2f);

        if(m_secondRoom.position.x > m_firstRoom.position.x)
        {
            m_player.transform.position = new Vector3(m_firstRoom.position.x + 17, m_player.transform.position.y, 0);
        }

        if (m_secondRoom.position.y < m_firstRoom.position.y)
        {
            m_player.transform.position = new Vector3(m_player.transform.position.x, m_firstRoom.position.y - 12, 0);
        }

        if (m_camera.transform.position.x - m_firstRoom.transform.position.x < 0.1f && m_camera.transform.position.x - m_firstRoom.transform.position.x > 0)
        {
            m_camera.transform.position = m_firstRoom.transform.position;
        }

        if (m_camera.transform.position.y * -1 - m_firstRoom.transform.position.y * -1 < 0.1f && m_camera.transform.position.y * -1 - m_firstRoom.transform.position.y * -1 > 0)
        {
            m_camera.transform.position = m_firstRoom.transform.position;
        }

        if (m_camera.transform.position == m_firstRoom.position)
        {
            m_cameraCanMoveBtoA = false;
        }
    }


    #endregion

    #region Private & Protected Variables

    private Camera m_camera;

    private bool m_cameraCanMoveAtoB = false;
    private bool m_cameraCanMoveBtoA = false;

    private Vector3 m_cameraStartPosition;
    #endregion
}
