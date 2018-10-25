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
            transform.position += new Vector3(Input.GetAxis("Horizontal") * speed * Time.deltaTime,
                Vector3.zero.y, Vector3.zero.z);
        }
        //ジャンプ
        if (Input.GetButtonDown("Jump"))
        {
            //rigid.AddForce(transform.up * jumpPower);
            rigid.AddForce(new Vector3(Vector3.zero.x, jumpPower, Vector3.zero.z));
        }
	}
}
