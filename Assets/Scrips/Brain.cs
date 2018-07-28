using System.Collections;
using UnityEngine;

public class Brain : MonoBehaviour
{

    public float speed, tilt;
    private Vector3 target = new Vector3(-0.5297083f, -5.195733f, 0);

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * speed);
        if (transform.position == target && target.y != -3.71f)
            target.y = -3.71f;
        else if (transform.position == target && target.y == -3.71f)
            target.y = -5.195733f;

        //-3.71
    }

}