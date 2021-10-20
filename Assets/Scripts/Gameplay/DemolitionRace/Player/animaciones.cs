using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animaciones : MonoBehaviour
{
    [SerializeField] DemolitionRacePlayer player;

    [SerializeField] Transform ai;
    [SerializeField] Transform ad;
    [SerializeField] Transform ti;
    [SerializeField] Transform td;

    float actual;
    float b;

    private void Start()
    {
    }

    private void Update()
    {
    }
    public void direccion(float direccion)
    {
        ai.RotateAround(player.playerTransform.up, (direccion) - actual);
        ad.RotateAround(player.playerTransform.up, (direccion) - actual);

        actual = direccion;
    }
    public void rotacion(float rpm)
    {
        b = rpm * 6 * Time.deltaTime;

        ai.Rotate(Vector3.forward, b);
        ad.Rotate(Vector3.forward, b);
        ti.Rotate(Vector3.forward, b);
        td.Rotate(Vector3.forward, b);
    }
}

