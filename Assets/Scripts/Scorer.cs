using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    private int hits = 0;

    private void OnCollisionEnter(Collision other) {

        if( other.gameObject.tag != "Hit" && other.gameObject.tag != "Ground" ) {
            Debug.Log("You've bumped into a thing this many times: " + ++hits );    
        }
    }
}
