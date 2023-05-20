using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    Vector3 statPos;//���s�[�g�̊J�n�ʒu

    // Start is called before the first frame update
    void Start()
    {
        statPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(statPos.x - transform.position.x > 10.0f)
        {
            transform.position = statPos;
        }
    }
}
