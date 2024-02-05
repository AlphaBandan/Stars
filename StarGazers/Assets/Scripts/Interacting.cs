using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Interacting : MonoBehaviour
{
	public GameObject interactable;
	public bool canInteract;
	public GameObject current;
	public GameObject text;
	public GameObject textObj;

	public string textmessage;

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
			textObj.GetComponent<TextMeshPro>().text = interactable.GetComponent<Interact>().message;
			text.SetActive(true);
        }
    }

	public void OnTriggerExit2D(Collider2D collidedObject)
	{
		if (collidedObject.gameObject.tag == "Interactable")
		{
			canInteract = false;
			text.SetActive(false);
			interactable = null;
		}
	}

}
