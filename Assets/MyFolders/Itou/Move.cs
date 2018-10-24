using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField]
    float speed;
    [SerializeField]
    float jumpPower;
    Rigidbody rigid;
	// Use this for initialization
	void Start ()
    {
        rigid = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        //左右移動
        if (Input.GetAxis("Horizontal") != 0)
        {
            transform.position += new Vector3(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0, 0);
        }
        //ジャンプ
        if (Input.GetButtonDown("Jump"))
        {
            rigid.AddForce(transform.up * jumpPower);
        }
	}
}
