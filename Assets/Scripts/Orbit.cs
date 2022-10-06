using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour
{
    public Transform target;
    public float orbitSpeed;
    Vector3 offSet; // �÷��̾�� ������ü���� �Ÿ�

    // Start is called before the first frame update
    void Start()
    {
        // ������ü���� �÷��̾��� ��ġ�� ���� �� ������ �Ÿ�
        offSet = transform.position - target.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = target.position + offSet; // ���� �Ÿ���ŭ ����
        // transform.Rotate(new Vector3(-0.2f, -0.2f, 0) * 2);
        transform.RotateAround(target.position, Vector3.back, orbitSpeed * Time.deltaTime * 5); // ȸ���� �ϴ� ����
        offSet = transform.position - target.position; // ���� �Ÿ���ŭ �̵�
    }
}
