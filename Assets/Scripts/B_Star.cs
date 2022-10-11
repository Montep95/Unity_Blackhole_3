using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

using Random = UnityEngine.Random; // Random ��ȣ�� ���� �ذ�

public class B_Star : MonoBehaviour
{
    public GameObject panel;
    public GameObject gameManager;

    //test
    [HideInInspector] public CircleCollider2D col;
    [HideInInspector]
    public Vector3 pos
    {
        get
        {
            return transform.position;
        }
    }
    // test
    public Transform b_star;
    Rigidbody2D b_starBody;
    public float influenceRange;
    public float intensity;
    public float distanceToPlayer;
    // Vector2 pullForce;

    //Not used
    //public static event Action OnStarCollected;

    Rigidbody2D rb;

    public bool hasTarget;
    Vector3 targetPosition;
    float moveSpeed = 0.5f;

    // ũ�� ����
    public int type; // ũ�� ����
    float size;

    // star ��� ���� (�̱���)
    #region Singleton class: B_Star

    public static B_Star bs;
    //public static gameManager Instance;


    #endregion

    // Start is called before the first frame update
    void Start()
    {
        panel = GameObject.FindGameObjectWithTag("panel");
        gameManager = GameObject.FindGameObjectWithTag("gameManager");

        // test - �� �߷���
        b_starBody = b_star.GetComponent<Rigidbody2D>();
        //

        float x = Random.Range(-31.0f, 31.0f);
        float y = Random.Range(13.0f, 47.0f);

        transform.position = new Vector3(x, y, 0);

        // ���� UI
        type = Random.Range(1, 4);
        if (type == 1)
        {
            size = 1.5f;

        }
        else if (type == 2)
        {
            size = 2.5f;
        }
        else
        {
            size = 4.0f;
        }
        transform.localScale = new Vector3(size, size, 0);
    }
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        bs = this;
    }

    private void FixedUpdate()
    {
        if (hasTarget)
        {
            Vector2 targetDirection = (targetPosition - transform.position).normalized;
            rb.velocity = new Vector2(targetDirection.x, targetDirection.y) * moveSpeed;
        }

    }

    public void SetTarget(Vector3 position)
    {
        targetPosition = position;
        hasTarget = true;
    }

    public void Update()
    {

    }
}
