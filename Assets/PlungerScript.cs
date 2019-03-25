using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlungerScript : MonoBehaviour
{
    float power = 0;
    float minPower = 0;
    float maxPower = 100;
    Rigidbody ball;
    public Slider powerSlider;

    // Start is called before the first frame update
    void Start() {
        powerSlider.minValue = 0;
        powerSlider.maxValue = maxPower;
        // ball = new <Rigidbody>();
    }

    // Update is called once per frame
    void Update() {
        Debug.Log("Log 1");
        powerSlider.value = power;
        if (Input.GetKeyDown("s")) {
            
                

                Debug.Log("Log 4");
                if (power <= maxPower)
                {
                    power += 50 * Time.deltaTime;
                }
            
        }
        if (Input.GetKeyUp("s")) {
                

            
        }
    }

    void OnTriggerEnter(Collider other) {
        
        if (other.gameObject.CompareTag("TheBall")) {
            
            ball = other.gameObject.GetComponent<Rigidbody>();
            ball.AddForce(1000 * Vector3.forward, ForceMode.Impulse);
        }
    }

    void OnTriggerExit(Collider other) {
        
    }
}
