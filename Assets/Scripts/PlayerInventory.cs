using UnityEngine;
using System.Collections;

public class PlayerInventory : MonoBehaviour {

    public int m_keyAmount = 0 ;

    public void UseKey()
    {
        m_keyAmount--;
    }

    public void AddKey()
    {
        m_keyAmount++;
    }

}
