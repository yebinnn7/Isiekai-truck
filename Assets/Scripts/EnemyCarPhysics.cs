using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyCarPhysics : MonoBehaviour
{
    public Rigidbody rb;
    public float minimum_speed; // �����ӵ�
    public float maximum_speed; // �ְ��ӵ�
    // Start is called before the first frame update
    void Start()
    {
        float carSpeed = Random.Range(minimum_speed, maximum_speed);
        rb.velocity = new Vector3(0, 0, carSpeed );
        if (carSpeed < 0)
        {
            transform.forward = new Vector3(0, 0, -1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}