using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class B_StarCollector : MonoBehaviour
{
    public GameObject b_star;
    public GameObject panel;
    public GameObject gameManager;

    private void Start()
    {
        panel = GameObject.FindGameObjectWithTag("panel");
        gameManager = GameObject.FindGameObjectWithTag("gameManager");
    }

    // private -> public ���� (2022-09-29 13:41)
    public void OnTriggerEnter2D(Collider2D collision)
    {
        ICollectible collectible = collision.GetComponent<ICollectible>();
        if (collectible != null)
        {
            collectible.Collect();

        }

        // Collector�� �ݴ��� ���� �ޱ�
        if (collision.gameObject.tag == "planet")
        {
            Debug.Log("B_StarCollector�� OnTriggerEnter ����");
            Destroy(collision.gameObject);

            // '�� ��Ȧ ������' ����
            GameObject.FindGameObjectWithTag("b_star").transform.localScale += new Vector3(0.02f, 0.02f, 0);
        }

        
        // OnTriggerEnter = ������� ����
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("�÷��̾ ��Ȧ�� ����� - END");
            Destroy(collision);

            GameObject.FindGameObjectWithTag("b_star").transform.localScale += new Vector3(0.5f, 0.5f, 0);

            panel.SetActive(true); // ����� �г� Ȱ��ȭ
            Time.timeScale = 0.0f; // Unity ��� �ð� Stop
                                   // gameManager.I.retry();

            //if ((GameObject.FindGameObjectWithTag("MagnetCollider").transform.localScale.x + 1.5f < GameObject.FindGameObjectWithTag("b_star").transform.localScale.x
            //    && GameObject.FindGameObjectWithTag("MagnetCollider").transform.localScale.y + 1.5f < GameObject.FindGameObjectWithTag("b_star").transform.localScale.y))
            //{

            //}
        }
    }
}