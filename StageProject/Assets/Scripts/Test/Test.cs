using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Test : MonoBehaviour
{
    CubeInputs controls;

    Vector2 move;
    Vector2 rotate;


    private void Awake()
    {
        controls = new CubeInputs();

        controls.cube.Grow.performed += ctx => Grow();

        controls.cube.shrink.performed += ctx => Shrink();

        controls.cube.Move.performed += ctx => move = ctx.ReadValue<Vector2>();
        controls.cube.Move.canceled += ctx => move = Vector2.zero;

        controls.cube.Rotation.performed += ctx => rotate = ctx.ReadValue<Vector2>();
        controls.cube.Rotation.canceled += ctx => rotate = Vector2.zero;
    }

    private void Grow()
    {
        transform.localScale *= 1.1f;
    }
    private void Shrink()
    {
        transform.localScale *= 0.9f;
    }
    private void Update()
    {
        Vector2 m = new Vector2(move.x, move.y) * Time.deltaTime;
        transform.Translate(m, Space.World);

        Vector2 r = new Vector2(rotate.y, -rotate.x) * 100f * Time.deltaTime;
        transform.Rotate(r, Space.World);
    }

    private void OnEnable()
    {
        controls.cube.Enable();
    }
    private void OnDisable()
    {
        controls.cube.Disable();
    }
}
