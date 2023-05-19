using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private GameObject player;
    private Rigidbody rd;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        speed = 0.005f;
        player = GameObject.Find("Player");
        rd = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player.transform);
        transform.position += transform.forward * speed;
        rd.AddForce(player.transform.position - transform.position);
        //���t���[���͂�������
        //�������ĂȂ�transform.position�́A�A�^�b�`����Ă�
        //���̂̍��W�ɂȂ�
    }
}
