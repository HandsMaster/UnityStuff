using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation_animation : MonoBehaviour
{

    public AnimationCurve curve;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localRotation = Quaternion.Euler(0, 0, -25 * curve.Evaluate(Time.time % 1));
    }
}
