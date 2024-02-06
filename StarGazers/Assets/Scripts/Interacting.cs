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

	//Check if BoxCollider2D collided with another collider that is set to Trigger
	public void OnTriggerEnter2D(Collider2D collidedObject)
    {
		//If Object is labeled Interactable
		if (collidedObject.gameObject.tag == "Interactable")
        {
			//CanInteract becomes true and the object is taken for other code
			canInteract = true;
			interactable = collidedObject.gameObject;
			//Prompt is changed to the object's message and prompt text becomes active
			textObj.GetComponent<TextMeshPro>().text = interactable.GetComponent<Interact>().message;
			text.SetActive(true);
        }
    }

	//Check if BoxCollider2D stopped colliding with another collider that is set to Trigger
	public void OnTriggerExit2D(Collider2D collidedObject)
	{
		if (collidedObject.gameObject.tag == "Interactable")
		{
			//CantInteract becomes false
			canInteract = false;
			//Text prompt is turned off and the current object variable is reset
			text.SetActive(false);
			interactable = null;
		}
	}

}
