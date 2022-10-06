using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class B_StarCollector : MonoBehaviour
{
    // private -> public ���� (2022-09-29 13:41)
    public void OnTriggerEnter2D(Collider2D collision)
    {
        ICollectible collectible = collision.GetComponent<ICollectible>();
        if (collectible != null)
        {
            collectible.Collect();

        }

        // Collector�� �ݴ��� ���� �ޱ�
        if (collision.gameObject.tag == "star")
        {
            Destroy(collision.gameObject);

            // '�� ��Ȧ ������' ����
            GameObject.FindGameObjectWithTag("b_star").transform.localScale += new Vector3(0.02f, 0.02f, 0);
        }
    }
}