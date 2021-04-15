using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    public Vector3 m_SpinSpeed;

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.Rotate(m_SpinSpeed * Time.deltaTime);
    }
}
