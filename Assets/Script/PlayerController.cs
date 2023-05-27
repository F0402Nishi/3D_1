using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    [SerializeField] float jumpForce; //private�͏ȗ��\ //�W�����v��
    [SerializeField] float gravityModifier;//�d�͒l������
    [SerializeField] bool isOnGround = true;//�n�ʂɂ��Ă��邩
    bool gameOver;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isOnGround)//�X�y�[�X�L�[��������āA���A�n�ʂɂ�����
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);//��֗͂�������
            isOnGround = false;//�W�����v�������n�ʂɂ��Ȃ�
        }
    }
    private void OnCollisionEnter(Collision collision)//�Փ˂��N��������s
    {
        if(collision.gameObject.CompareTag("Ground"))//�Ԃ���������(collision)�̃^�O��Ground�Ȃ�
        {
            isOnGround = true;//�n�ʂɂ��Ă����ԂɕύX
        }
        if (collision.gameObject.CompareTag("Obstacle"))//�Ԃ���������(collision)�̃^�O��Ground�Ȃ�
        {
            gameOver = true;//�n�ʂɂ��Ă����ԂɕύX
        }
    }
}
