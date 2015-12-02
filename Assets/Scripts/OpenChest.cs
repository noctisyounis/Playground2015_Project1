using UnityEngine;
using System.Collections;

public class OpenChest : MonoBehaviour {


    public GameObject _objectToDrop;
    public bool IsTouchingChest = false;
    public bool IsChestOpen = false;
    private Transform PositionDrop;
    private SpriteRenderer _spriteRenderer;
    public Sprite OpenedChest;

    void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        PositionDrop = transform;    
    }

    void Update()
    {
        if (IsTouchingChest )
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                if (!IsChestOpen)
                {
                    GameObject Item = (GameObject)Instantiate(_objectToDrop, transform.position + new Vector3(0.5f, 2, 0) , PositionDrop.rotation); // Instancie l'objet rentrer dans l'inspecteur, "modulaire". 
                    IsChestOpen = true;
                }
            }
        }      
    }

    void OnTriggerEnter2D()
    {
        IsTouchingChest = true;
    }  
}
