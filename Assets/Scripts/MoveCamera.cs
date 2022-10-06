using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public Transform target; // �÷��̾��� ��ġ�� ���� ����
    public float speed;

    // ī�޶��̵�, ȭ��ũ�� ����
    public Vector2 center;
    public Vector2 size;
    float height;
    float width;
    
    void Start()
    {
        // ī�޶��̵�, ȭ��ũ�� ����
        height = Camera.main.orthographicSize;
        width = height * Screen.width / Screen.height;
    }

    // ī�޶��̵�, ȭ��ũ�� ����
    private void OnDrawGizmos() // ���� ���� �ð������� ���̰� �ϱ� ���� �Լ�
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(center, size); // center�� �߽����� sizeũ���� ť�긦 ǥ��
    }

    void LateUpdate() // �÷��̾ ������ �Ŀ� ī�޶� ���󰡴� �Լ�
    { // LateUpdate�� Update�Լ��� ȣ��� �Ŀ� ȣ��˴ϴ�.

        // transform.position = new Vector3(target.position.x, target.position.y, -10f);
        
        transform.position = Vector3.Lerp(transform.position, target.position, Time.deltaTime * speed);
        // ī�޶� ��ġ�� �� �����Ӹ��� ���ݾ� �÷��̾�� �ٰ����Ե�
        // Time.deltaTime�� speed ������ �����ؼ� ������

        transform.position = new Vector3(transform.position.x, transform.position.y, -10f);
        // ī�޶��� Z���� -10f�� �������������
        // �� Ÿ�ٺ����� Unity���� Ÿ���� ����� ��� �ֱ�

        // ī�޶��̵�, ȭ��ũ�� ����
        float lx = size.x * 0.5f - width;
        float clampX = Mathf.Clamp(transform.position.x, -lx + center.x, lx + center.x);
        float ly = size.x * 0.5f - width;
        float clampY = Mathf.Clamp(transform.position.y, -ly + center.y, ly + center.y);

        transform.position = new Vector3(clampX, clampY, -10f);
    
        //if((target.transform.localScale.x > 7) && (target.transform.localScale.y > 7))
        //{
        //    size.x += 1;
        //    size.y += 1;
        //}
    }
}
