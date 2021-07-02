using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Movement movement;
    private void Start() {
         movement = GetComponent<Movement>();
    }
    void Update() {
        if (Input.GetKey(KeyCode.UpArrow)) {
            movement.Forward();
        }

        if (Input.GetKey(KeyCode.DownArrow)) {
            movement.Backward();
        }

        if (Input.GetKey(KeyCode.RightArrow)) {
            movement.TurnRight();
        }

        if (Input.GetKey(KeyCode.LeftArrow)) {
            movement.TurnLeft();
        }
    }
}
