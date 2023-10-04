using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBehaviourScript : MonoBehaviour
{
    void Update()
    {
        float rota = 360.0f * Time.deltaTime / 10.0f;
        this.transform.Rotate(0f, rota, 0f);
    }
}
