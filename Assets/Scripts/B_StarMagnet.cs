using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_StarMagnet : MonoBehaviour
{
    public GameObject b_star;
    public GameObject panel;
    public GameObject gameManager;

    //test
    [HideInInspector] public Rigidbody2D rb;
    Vector2 force;
}
    /*
    // OnTriggerStay = ����Ǵ� ����
    private void OnTriggerStay2D(Collider2D collision)
    {
        // ���� ���� �ε����ٸ�
        if (collision.gameObject.TryGetComponent<Star>(out Star star))
        {
            // ���� �÷��̾������� �����̵���
            star.SetTarget(transform.parent.position);

        }

        // test - ���� ��Ȧ�� �ε����ٸ�
        if (collision.gameObject.TryGetComponent<Player>(out Player player))
        {
            if ((GameObject.FindGameObjectWithTag("MagnetCollider").transform.localScale.x + 1.5f < GameObject.FindGameObjectWithTag("b_starColl").transform.localScale.x
                && GameObject.FindGameObjectWithTag("MagnetCollider").transform.localScale.y + 1.5f < GameObject.FindGameObjectWithTag("b_starColl").transform.localScale.y))
            {
                Debug.Log("�÷��̾ ��Ȧ�� ����Ǵ� ��");

                player.SetTarget(transform.parent.position);

                // test - �÷��̾ ����ɶ� ���콺 Ŭ���� �߻��ϸ� Ÿ���� �����ϴ� ���� 
                // (2022-10-05 22:51) - XXX
                if (Input.GetMouseButtonDown(0))
                {
                    b_star.GetComponent<B_Star>().hasTarget = false;
                }
            }
        }
    }


    /*
    // OnTriggerEnter = ������� ����
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent<Player>(out Player player))
        {

            if ((GameObject.FindGameObjectWithTag("MagnetCollider").transform.localScale.x + 1.5f < GameObject.FindGameObjectWithTag("b_star").transform.localScale.x
                && GameObject.FindGameObjectWithTag("MagnetCollider").transform.localScale.y + 1.5f < GameObject.FindGameObjectWithTag("b_star").transform.localScale.y))
            {
                panel.SetActive(true); // ����� �г� Ȱ��ȭ
                Time.timeScale = 0.0f; // Unity ��� �ð� Stop
                                       // gameManager.I.retry();
            }
        }
    }
    */


    /*
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // '��' ���� ��Ȧ�� Magnet ���� �ȿ� ������,
        if (collision.gameObject.TryGetComponent<Star>(out Star star))
        {
            // ���� ���� ��Ȧ�� ����ǵ���
            star.SetTarget(transform.parent.position);

            //test
            GameObject.FindGameObjectWithTag("b_star").transform.localScale += new Vector3(0.03f, 0.03f, 0);
            Destroy(GameObject.FindGameObjectWithTag("star")); //star ����


        }
    }
    */