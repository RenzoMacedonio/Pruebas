using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaMovimientoVehiculo : MonoBehaviour
{
    [SerializeField] DemolitionRacePlayer player;
    [SerializeField] float directionSpeed = 30f;
    [SerializeField] float aceleration = 30f;
    [SerializeField] float speedLimit = 70f;
    [SerializeField] float drag = 1f; 
   
    float speed = 0f;

    public animaciones animaciones;
    public animaciones animaciones2;

    private void Start()
    {
        player = GetComponent<DemolitionRacePlayer>();
    }

    public void PlayerDemolitionRaceMovement()
    {
        speed = Mathf.Clamp(speed, -speedLimit * 0.4f, speedLimit);
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    public void SetSpeedAndRotation(float direccionInputHorizontal, float direccionInputVertical)
    {
        animaciones.direccion(direccionInputHorizontal);
        animaciones2.direccion(direccionInputHorizontal);

        if (direccionInputVertical != 0)
        {
            speed += Time.deltaTime * aceleration * direccionInputVertical;
        }
        else
        {
            speed = Mathf.Lerp(speed, 0, drag * Time.deltaTime);
        }

        float anguloDeRotacion = direccionInputHorizontal * Time.deltaTime * directionSpeed * speed;
        transform.Rotate(Vector3.right, anguloDeRotacion);
        
    }
    public void PlayerDemolitionRaceHandBrake()
    {

    }

    public void PlayerDemolitionRaceTurbo()
    {
        



    }

    public void FixedUpdate()
    {
        PlayerDemolitionRaceMovement();    
    }

}
