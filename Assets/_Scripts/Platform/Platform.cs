using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEditor;
using static UnityEditorInternal.VersionControl.ListControl;
using System;

public class Platform : MonoBehaviour
{
    public static event Action OnScoreChanged;
    [SerializeField] private float jumpForce;
    [SerializeField] private float duration = 1;
    [SerializeField] private GameObject springPrefab;
    [SerializeField] private bool isSpring;
    private IMovable movement;
    private Dictionary<int, IMovable> listState = new Dictionary<int, IMovable>();

    private void Awake()
    {
        MovingRightBehavior a = new MovingRightBehavior();
        MovingUpBehavior b = new MovingUpBehavior();
        IdleBehavior c = new IdleBehavior();
        listState.Add(0, a);
        listState.Add(1, b);
        listState.Add(2, c);
    }
    private void Start()
    {
        int randomBehavior = UnityEngine.Random.Range(0, listState.Count);
        gameObject.AddComponent(listState[randomBehavior].GetType());
        movement = GetComponent<IMovable>();
        movement?.Move(transform, duration);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("player"))
        {
            if (collision.relativeVelocity.y <= 0)
            {
                OnScoreChanged?.Invoke();
                Rigidbody2D rigid = collision.collider.GetComponent<Rigidbody2D>();
                if (rigid != null)
                {
                    Vector2 velocity = rigid.velocity;
                    velocity.y = jumpForce;
                    rigid.velocity = velocity;
                }
            }
        }
    }
}
