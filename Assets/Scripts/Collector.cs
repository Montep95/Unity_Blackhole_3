using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collector : MonoBehaviour
{

    //test (2022-09-29 20:57)
    public GameObject Player;
    public GameObject gameManager;
    public GameObject g_field; // �߷���(���ü�) Ű���
    public GameObject MagnetCollider; // �� �߷��� Ű���
    //private vector3 originscale; // �߷��� �׷��� ���� ũ��
    //private vector3 originscale2; // �߷��� ���� ũ��
    public float x;
    public float y;
    public float z;

    //test
    public GameObject panel;
    public GameObject star;
    public GameObject b_star;
    public GameObject b_starCollider;
    float cameraSize;

    //test - Orbit
    public int HasOrbit;
    public int MaxHasOrbit;
    public GameObject[] Orbits;
    public float pushForce;
    public float moveSpeed;


    [HideInInspector] public Rigidbody2D rb;
    [HideInInspector] public CircleCollider2D col;

    // test (2022-10-01 15:12)
    private Vector3 gf;
    // Star.cs ���� type(���� ũ������)�� ������
    //public int g_type = GameObject.FindGameObjectWithTag("star").GetComponent<Star>().type;

    [HideInInspector]
    public Vector3 pos
    {
        get
        {
            return transform.position;
        }
    }

    private void Start()
    {
        cameraSize = Camera.main.orthographicSize;

        //test - Orbit
        HasOrbit = Player.GetComponent<Player>().HasOrbit;
        MaxHasOrbit = Player.GetComponent<Player>().maxHasOrbit;
        Orbits = Player.GetComponent<Player>().Orbits;
        //float pushForce1 = gameManager.GetComponent<gameManager>().pushForce;
        //pushForce = pushForce1;
        moveSpeed = Player.GetComponent<Player>().moveSpeed;
    }



    private void Awake()
    {

    }


    /*
    // Awake(), Start()�� �޸� Ȱ��ȭ �ɶ����� ȣ��
    private void OnEnable()
    {

    }
    */

    // private -> public ���� (2022-09-29 13:41)
    public void OnTriggerEnter2D(Collider2D collision)
    {
        ICollectible collectible = collision.GetComponent<ICollectible>();
        if (collectible != null)
        {
            collectible.Collect();
        }
    }
}

        /*
        if (collision.gameObject.tag == "star")
        {
            Debug.Log("���� �����");
            Destroy(collision.gameObject);

            // test - Orbit (Ÿ�� �� ��� ����)
            Star star = collision.GetComponent<Star>();
            Orbits[HasOrbit].SetActive(true);
            HasOrbit += 1;
            if (HasOrbit == MaxHasOrbit)
            {
                HasOrbit = 0; // �ε��� ���� �ذ�
            }
            Destroy(collision.gameObject);
            GameObject.FindGameObjectWithTag("MagnetCollider").transform.localScale += new Vector3(0.02f, 0.02f, 0);

            // ī�޶� �� �ƿ� �Ѱ�ġ ����
            if (Camera.main.orthographicSize < 20.0f &&
                (Camera.main.transform.position.x > -4.5 && Camera.main.transform.position.x < 4.5))
            {
                Camera.main.orthographicSize += 0.25f;
            }

            // �÷��̾�(��Ȧ) ���� �Ѱ�ġ ����
            if (moveSpeed > 0.4f)

                if (Player.GetComponent<Player>().moveSpeed > 0.4f)
                {
                    moveSpeed -= 0.2f;
                    //pushForce -= 0.2f;
                }

            /* ���� ũ�⺰ ������ �� 
            if (g_type == 1)
            {
                Debug.Log("ū ���� ���");
                GameObject.FindGameObjectWithTag("MagnetCollider").transform.localScale += new Vector3(0.1f, 0.1f, 0);
                Camera.main.orthographicSize += 0.7f;
            }
            if (g_type == 2)
            {
                Debug.Log("�߰� ���� ���");
                GameObject.FindGameObjectWithTag("MagnetCollider").transform.localScale += new Vector3(0.05f, 0.05f, 0);
                Camera.main.orthographicSize += 0.4f;
            }
            else
            {
                Debug.Log("�Ϲ� ���� ���");
                GameObject.FindGameObjectWithTag("MagnetCollider").transform.localScale += new Vector3(0.02f, 0.02f, 0);
                Camera.main.orthographicSize += 0.15f;
            }
            */


/*
        // test - ��Ȧ ��� ����
        if (collision.gameObject.tag == "b_starColl")
        {
            if ((GameObject.FindGameObjectWithTag("MagnetCollider").transform.localScale.x + 1.5f > GameObject.FindGameObjectWithTag("b_starColl").transform.localScale.x
                && GameObject.FindGameObjectWithTag("MagnetCollider").transform.localScale.y + 1.5f > GameObject.FindGameObjectWithTag("b_starColl").transform.localScale.y))
            {
                Debug.Log("��Ȧ�� �����");

                // Destroy(GameObject.FindGameObjectWithTag("b_star"));
                Destroy(collision.gameObject);

                GameObject.FindGameObjectWithTag("MagnetCollider").transform.localScale += new Vector3(0.1f, 0.1f, 0);

                if (Camera.main.orthographicSize < 20.0f &&
                    (Camera.main.transform.position.x > -4.5 && Camera.main.transform.position.x < 4.5))
                {
                    Camera.main.orthographicSize += 0.5f;

                }
                // �÷��̾�(��Ȧ) ���� �Ѱ�ġ ����
                if (moveSpeed > 0.4f)
                {
                    moveSpeed -= 0.2f;
                    //pushForce -= 0.2f;
                    Player.GetComponent<Player>().moveSpeed -= 0.4f;
                    
                    // ��������
                    // gameManager.GetComponent<gameManager>().pushForce -= 0.2f;
                }
            }
        }
    }
}
*/
