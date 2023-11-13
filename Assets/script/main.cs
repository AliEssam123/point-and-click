using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class main : MonoBehaviour

{
    public standManger stand;
    public salfhManger salfh;

    public Material[] materials;
    public int currentMaterial = 0;

    void Start()
    {

        stand = FindAnyObjectByType<standManger>();
    }

    public void ChangeMaterial(int direction)
    {

        currentMaterial += direction;

        if (currentMaterial + direction < 0)
        {
            currentMaterial = materials.Length - 1;
        }
        else if (currentMaterial + direction > materials.Length - 1)
        {
            currentMaterial = 0;
        }
        else
        {
            currentMaterial = currentMaterial + direction;
        }


        //stand.stand[stand.currentStand].transform.GetChild(0).GetComponent<MeshRenderer>().material = materials[currentMaterial];

        stand.ChangeMaterial(materials[currentMaterial]);
    }



}