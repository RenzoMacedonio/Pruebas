using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class EditorTest
{
    [Test]
    public void ableToInteract()
    {
        bool isable = false;
        if(PuedeInteractuar.interactuable == true){
            isable = true;

        }
    }
    [Test]
    public void SpawnedTurbo()
    {
        bool IsSpawned = false;
        if (GameObject.FindGameObjectWithTag("Turbo") == true)
        {
            IsSpawned = true;
        }
    }
    [Test]
    public void ExistsEnemy()
    {
        bool exists = false;
        if (GameObject.FindGameObjectWithTag("Enemy") == true)
        {
            exists = true;
        }
    }
    [Test]
    public void ExistsPlayer()
    {
        bool exists = false;
        if (GameObject.FindGameObjectWithTag("Player") == true)
        {
            exists = true;
        }
    }  
   
}  

