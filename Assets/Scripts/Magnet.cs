using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magnet : MonoBehaviour
{
    public GameObject panel;

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
        if (collision.gameObject.TryGetComponent<B_Star>(out B_Star bs))
        {
            if ((GameObject.FindGameObjectWithTag("MagnetCollider").transform.localScale.x + 1.5f > GameObject.FindGameObjectWithTag("b_starColl").transform.localScale.x
                && GameObject.FindGameObjectWithTag("MagnetCollider").transform.localScale.y + 1.5f > GameObject.FindGameObjectWithTag("b_starColl").transform.localScale.y))
            {
                // ��Ȧ�� �÷��̾������� �����̵���
                bs.SetTarget(transform.parent.position);
                Destroy(collision.gameObject);

                GameObject.FindGameObjectWithTag("MagnetCollider").transform.localScale += new Vector3(0.1f, 0.1f, 0);
                if (Camera.main.orthographicSize < 20.0f &&
                    (Camera.main.transform.position.x > -4.5 && Camera.main.transform.position.x < 4.5))
                {
                    Camera.main.orthographicSize += 0.5f;

                }
                /*
                // �÷��̾�(��Ȧ) ���� �Ѱ�ġ ����
                if (moveSpeed > 0.4f)
                {
                    moveSpeed -= 0.2f;
                    //pushForce -= 0.2f;
                }
                */
}

    /*
    // OnTriggerEnter = ������� ����
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "b_starColl")
        {
            if ((GameObject.FindGameObjectWithTag("MagnetCollider").transform.localScale.x + 1.5f > GameObject.FindGameObjectWithTag("b_star").transform.localScale.x
                && GameObject.FindGameObjectWithTag("MagnetCollider").transform.localScale.y + 1.5f > GameObject.FindGameObjectWithTag("b_star").transform.localScale.y))
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
                }
            }
        }

        else if ((GameObject.FindGameObjectWithTag("MagnetCollider").transform.localScale.x + 1.5f < GameObject.FindGameObjectWithTag("b_star").transform.localScale.x
            && GameObject.FindGameObjectWithTag("MagnetCollider").transform.localScale.y + 1.5f < GameObject.FindGameObjectWithTag("b_star").transform.localScale.y))
        {
            panel.SetActive(true); // ����� �г� Ȱ��ȭ
            Time.timeScale = 0.0f; // Unity ��� �ð� Stop
                                    // gameManager.I.retry();
        }
    }
    */
