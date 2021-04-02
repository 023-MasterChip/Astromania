using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Screen Shake script 
//!!!!!!!!Dont change this script or add anything to it!!!!!!!!!!!!!!!!!!!!
public class screenShake : MonoBehaviour
{
    // Transform of the GameObject you want to shake
    private Transform initial;

    // Desired duration of the shake effect
    private float shakeDuration = 0f;

    // A measure of magnitude for the shake. Tweak based on your preference
    private float shakeMagnitude = 0.4f;

    // A measure of how quickly the shake effect should evaporate
    private float dampingSpeed = 2.0f;

    // The initial position of the GameObject
    Vector3 initialPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (shakeDuration > 0)
        {
            transform.localPosition = initialPosition + Random.insideUnitSphere * shakeMagnitude;

            shakeDuration -= Time.deltaTime * dampingSpeed;
        }
        else
        {
            shakeDuration = 0f;
            transform.localPosition = initialPosition;
        }
    }
    void Awake()
    {
        if (transform == null)
        {
            initial = GetComponent(typeof(Transform)) as Transform;
        }
    }
    void OnEnable()
    {
        initialPosition = transform.localPosition;
    }
    public void TriggerShake()
    {
        shakeDuration = 0.3f;
    }
}
