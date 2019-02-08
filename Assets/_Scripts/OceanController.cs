using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OceanController : MonoBehaviour
{
    public float verticalSpeed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        Reset();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        CheckBounds();
    }

    void Move() {
        float currentY = transform.position.y;
        transform.position = new Vector2(0.0f, currentY - verticalSpeed);
    }

    void Reset() {
        transform.position = new Vector2(0.0f, 2.2f);
    }

    void CheckBounds() {
        if(transform.position.y < -2.2) {
            Reset();
        }
    }
}
