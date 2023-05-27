using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    [SerializeField] float jumpForce; //privateは省略可能 //ジャンプ力
    [SerializeField] float gravityModifier;//重力値微調整
    [SerializeField] bool isOnGround = true;//地面についているか
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
        if(Input.GetKeyDown(KeyCode.Space) && isOnGround)//スペースキーが押されて、かつ、地面にいたら
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);//上へ力を加える
            isOnGround = false;//ジャンプした＝地面にいない
        }
    }
    private void OnCollisionEnter(Collision collision)//衝突が起きたら実行
    {
        if(collision.gameObject.CompareTag("Ground"))//ぶつかった相手(collision)のタグがGroundなら
        {
            isOnGround = true;//地面についている状態に変更
        }
        if (collision.gameObject.CompareTag("Obstacle"))//ぶつかった相手(collision)のタグがGroundなら
        {
            gameOver = true;//地面についている状態に変更
        }
    }
}
