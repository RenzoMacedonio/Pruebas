using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animaciones : MonoBehaviour
{
    Transform ai,ad,ti,td;
    Rigidbody rb;
    [SerializeField] float rodamiento = 50;
    [SerializeField] float rotacionDireccion = 30;

    float actual;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        ai = transform.Find("Rueda ad");
        ad = transform.Find("Rueda ai");
        ti = transform.Find("Rueda td");
        td = transform.Find("Rueda ti");
    }
    public void direccion(float direccion)
    {
        ai.Rotate(Vector3.up, Mathf.Clamp(direccion * rotacionDireccion, -45f, 45f) - actual, Space.World);
        ad.Rotate(Vector3.up, (direccion * rotacionDireccion) - actual, Space.World);
        actual = Mathf.Clamp(direccion * rotacionDireccion, -45f, 45f);


    }
    public void road(float speed)
    {
        float i = speed * rodamiento * Time.deltaTime;

        ai.Rotate(Vector3.up, i);
        ad.Rotate(Vector3.up, i);
        ti.Rotate(Vector3.up, i);
        td.Rotate(Vector3.up, i);
    }
}

