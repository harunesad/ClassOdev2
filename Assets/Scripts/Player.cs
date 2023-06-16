using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Player : MonoBehaviour
{
    PhotonView photonView;
    public int health = 100;
    public GameObject[] checkPoints;
    private void Awake()
    {
        photonView = GetComponent<PhotonView>();
    }
    private void Start()
    {
        if (photonView.IsMine)
        {
            GetComponent<Renderer>().material.color = Color.blue;
        }
        if (PhotonNetwork.IsMasterClient)
        {
            transform.position = checkPoints[0].transform.position;
        }
        else
        {
            transform.position = checkPoints[1].transform.position;
        }
    }
    private void FixedUpdate()
    {
        if (photonView.IsMine)
        {
            Move();
            Jump();
            Fire();
        }
    }
    void Move()
    {
        float h = Input.GetAxis("Horizontal") * 20 * Time.deltaTime;
        float v = Input.GetAxis("Vertical") * 20 * Time.deltaTime;
        transform.Translate(h, 0, v);
    }
    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, 10, 0);
        }
    }
    void Fire()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit, 100))
            {
                hit.collider.gameObject.GetComponent<PhotonView>().RPC("Hit", RpcTarget.All, 20);
            }
        }
    }
    [PunRPC]
    void Hit(int attack)
    {
        health -= attack;
        Debug.Log(health);
        if (health == 0)
        {
            PhotonNetwork.Destroy(gameObject);
        }
    }
}
