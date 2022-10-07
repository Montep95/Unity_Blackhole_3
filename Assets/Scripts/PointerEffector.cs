using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointerEffector : MonoBehaviour
{
    public Transform target;
    public GameObject Player;
    public float orbitSpeed;
    Vector3 offSet; // �÷��̾�� �´��� ��ü���� �Ÿ�

    // Start is called before the first frame update
    void Start()
    {
        float x = Random.Range(-18.0f, 18.0f);
        float y = Random.Range(-23.0f, 23.0f);

        transform.position = new Vector3(x, y, 0);
        //offSet = transform.position - target.position;    
        target = GameObject.FindGameObjectWithTag("Absorber").transform;
    }

    // Update is called once per frame
    void Update()
    {
        /*
        transform.position = target.position + offSet; // ���� �Ÿ���ŭ ����
                                                       // transform.Rotate(new Vector3(-0.2f, -0.2f, 0) * 2);
                                                       // transform.RotateAround(target.position, Vector3.back, orbitSpeed * Time.deltaTime * 5); // ȸ���� �ϴ� ����
        offSet = transform.position - target.position; // ���� �Ÿ���ŭ �̵�
    */
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            other.transform.position = target.position;
        }
    }

    void Orbit()
    {

    }
}
