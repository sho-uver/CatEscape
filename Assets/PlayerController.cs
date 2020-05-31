using System.Collections;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    // Start is called before the first frame update
    void Start () {

    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown (KeyCode.LeftArrow)) {
            transform.Translate (-3, 0, 0); //move to left
        }
        if (Input.GetKeyDown (KeyCode.RightArrow)) {
            transform.Translate (3, 0, 0); //move to right
        }
    }
}