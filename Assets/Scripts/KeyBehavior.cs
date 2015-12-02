using UnityEngine;
using System.Collections;

public class KeyBehavior : MonoBehaviour {

    private GameObject m_player;
    private PlayerInventory m_inventory;

    void Start()
    {
        m_player = GameObject.FindGameObjectWithTag("Player");
        m_inventory = m_player.GetComponent<PlayerInventory>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            m_inventory.AddKey();
            Destroy(this.gameObject);
        }
        
    }
}
