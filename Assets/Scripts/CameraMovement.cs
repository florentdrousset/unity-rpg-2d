using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    // Every object in a Scene has a Transform. It's used to store and manipulate the position, rotation and scale of the object.
    // Every Transform can have a parent, which allows you to apply position, rotation and scale hierarchically. 
    public Transform target;
    public float smoothing;
    public Vector2 maxPosition;
    public Vector2 minPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    // LateUpdate happens whatever the physic system is set to tick
    void LateUpdate()
    {
       if (transform.position != target.position)
        {
            Vector3 targetPosition = new Vector3(target.position.x, target.position.y, transform.position.z);
            targetPosition.x = Mathf.Clamp(targetPosition.x, minPosition.x, maxPosition.x);
            targetPosition.y = Mathf.Clamp(targetPosition.y, minPosition.y, maxPosition.y);

            //Lerp = Linear Interpolation. finds the distance between it and the target, and moves to that position at a certain rate
            // 1st argument : position you're currently at
            // 2nd argument : position we want to go to
            // 3rd argument : the amount we want to cover
            transform.position = Vector3.Lerp(transform.position, targetPosition, smoothing);
        } 
    }
}
