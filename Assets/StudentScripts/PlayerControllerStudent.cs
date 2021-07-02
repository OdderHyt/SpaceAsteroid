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
    //Indsæt de passende functioner neden under så skibet kan styres :))
    //movement.Forward() og movement.Backward() accelerere skibet frem of tilbage
    //
    //movement.TurnLeft() og movement.TurnRight() drejer på skibet.
    void Update() {
        if (Input.GetKey(KeyCode.UpArrow)) {
            //Indsæt kode her
        }

        if (Input.GetKey(KeyCode.DownArrow)) {
            //Indsæt kode her
        }

        if (Input.GetKey(KeyCode.RightArrow)) {
            //Indsæt kode her
        }

        if (Input.GetKey(KeyCode.LeftArrow)) {
            //Indsæt kode her
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        //Lection 2
        //Når skibet collidere ned et andet gameObject der har en collider hvad skal der så ske?
    }
}


