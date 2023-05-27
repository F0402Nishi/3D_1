using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    Vector3 statPos;//リピートの開始位置
    float repeatWidth;

    // Start is called before the first frame update
    void Start()
    {
        statPos = transform.position;
        repeatWidth = GetComponent<BoxCollider>().size.x / 2;
    }

    // Update is called once per frame
    void Update()
    {
        if(statPos.x - transform.position.x > repeatWidth)
        {
            transform.position = statPos;
        }
    }
}
