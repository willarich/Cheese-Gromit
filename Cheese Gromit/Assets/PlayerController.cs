using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController: MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rigidBody;
    public Camera sceneCamera;
    public Weapon weapon;

    private Vector2 moveDirection;
    private Vector2 mousePosition;



    // Update is called once per frame
    void Update()
    {
        //For inputs
        ProcessInputs();
    }

    private void FixedUpdate()
    {
        //For physics
        Move();
    }

    void ProcessInputs()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        if (Input.GetMouseButtonDown(0))
        {
            weapon.Fire();
        }

        moveDirection = new Vector2(moveX, moveY).normalized;
        mousePosition = sceneCamera.ScreenToWorldPoint(Input.mousePosition);
    }

    private void Move()
    {
        rigidBody.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
        Vector2 aimDirection = mousePosition - rigidBody.position;
        float aimAngle = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg - 90f;
        rigidBody.rotation = aimAngle;
    }
}
