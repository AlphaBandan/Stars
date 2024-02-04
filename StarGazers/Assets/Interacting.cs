using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interacting : MonoBehaviour
{
	public GameObject interactable;
	public bool canInteract;
	public GameObject current;
	public GameObject text;

	public Collider2D collides;
	public ContactFilter2D filter;
	public List<Collider2D> collidedObjects;

	public void Start()
    {
		collides = GetComponent<Collider2D>();
    }

	public void Update()
    {
    }

	public void OnTriggerEnter2D(Collider2D collidedObject)
    {
		if (collidedObject.gameObject.tag == "Interactable")
        {
			canInteract = true;
			interactable = collidedObject.gameObject;
			text.SetActive(true);
        }
    }

	public void OnTriggerExit2D(Collider2D collidedObject)
	{
		if (collidedObject.gameObject.tag == "Interactable")
		{
			canInteract = false;
			interactable = null;
			text.SetActive(false);
		}
	}

}
