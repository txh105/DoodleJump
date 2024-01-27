using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerReturnScreen : MonoBehaviour
{
    [SerializeField] private float minX;
    [SerializeField] private float maxX;

    void Update()
    {
        if (transform.position.x < minX)
        {
            transform.position = new Vector2(maxX, transform.position.y);
        }
        else if (transform.position.x > maxX)
        {
            transform.position = new Vector2(minX, transform.position.y);
        }
    }
}
