using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float playerSpeed;

    private bool upKey;
    private bool downKey;
    private bool leftKey;
    private bool rightKey;

    private Transform playerTransform;

    // Start is called before the first frame update
    void Start()
    {
        playerSpeed = 5.0f;
        upKey = false;
        downKey = false;
        leftKey = false;
        rightKey = false;

        playerTransform = this.gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        getKeyboard();
        movePlayer();
        flushKeyboard();
    }

    void getKeyboard()
    {
        if(Input.GetKey(KeyCode.W))
        {
            upKey = true;
        }
        if(Input.GetKey(KeyCode.S))
        {
            downKey = true;
        }
        if(Input.GetKey(KeyCode.A)) 
        { 
            leftKey = true;
        }
        if(Input.GetKey(KeyCode.D))
        {
            rightKey = true;
        }
    }

    void movePlayer()
    {
        if(upKey)
        {
            playerTransform.position += new Vector3(0f, 0f, playerSpeed * Time.deltaTime);
        }
        if(downKey)
        {
            playerTransform.position += new Vector3(0f, 0f, -playerSpeed * Time.deltaTime);
        }
        if(leftKey)
        {
            playerTransform.position += new Vector3(-playerSpeed * Time.deltaTime, 0f, 0f);
        }
        if(rightKey)
        {
            playerTransform.position += new Vector3(playerSpeed * Time.deltaTime, 0f, 0f);
        }
    }

    void flushKeyboard()
    {
        upKey = false;
        downKey = false;
        leftKey = false;
        rightKey = false;
    }
}
