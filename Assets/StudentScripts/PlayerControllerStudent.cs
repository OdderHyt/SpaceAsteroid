using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerStudent : MonoBehaviour
{
    Movement movement;
    private void Start() {
         movement = GetComponent<Movement>();
    }

    //Lection 1
    //Inds�t de passende functioner neden under s� skibet kan styres :))
    //movement.Forward() og movement.Backward() accelerere skibet frem of tilbage
    //
    //movement.TurnLeft() og movement.TurnRight() drejer p� skibet.
    void Update() {
        if (Input.GetKey(KeyCode.UpArrow)) {
            //Inds�t kode her
        }

        if (Input.GetKey(KeyCode.DownArrow)) {
            //Inds�t kode her
        }

        if (Input.GetKey(KeyCode.RightArrow)) {
            //Inds�t kode her
        }

        if (Input.GetKey(KeyCode.LeftArrow)) {
            //Inds�t kode her
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        //Lection 2
        //N�r skibet collidere ned et andet gameObject der har en collider hvad skal der s� ske?
    }
}


