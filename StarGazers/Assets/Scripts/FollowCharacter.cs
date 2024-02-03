using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCharacter : MonoBehaviour
{
    public Transform character;
    public Vector3 offset;
    public float dampen;

    private Vector3 velocity = Vector3.zero;

    void FixedUpdate()
    {
        Vector3 movePosition = character.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position, movePosition, ref velocity, dampen);
    }
}
