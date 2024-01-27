using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Springs : MonoBehaviour
{
    [SerializeField] private Platform platform;
    private void Start()
    {
        platform = GetComponentInParent<Platform>();
        transform.position = new Vector2(Random.Range(-0.4f, 0.4f), 0.22f);
    }
}
