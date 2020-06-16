using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    private Rigidbody2D myRigidbody;
    private Vector3 change;
    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        change = Vector3.zero;
        //change.x = Input.GetAxis("Horizontal");
        // Le pb avec GetAxis, c'est qu'il ne passe pas directement de 0 à 1. Il passe par des valeurs intermédiaires.
        change.x = Input.GetAxisRaw("Horizontal");
        //change.y = Input.GetAxis("Vertical");
        change.y = Input.GetAxisRaw("Vertical");
        //Debug ! Très utile.
       // Debug.Log(change);

        if(change != Vector3.zero)
        {
            MoveCharacter();
        }
    }

    void MoveCharacter()
    {
        myRigidbody.MovePosition(
            transform.position + change * speed * Time.deltaTime
            );
    }
}
