﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Car Property")]
public class CarProperties : ScriptableObject
{
    public string name;
    public Material carMaterial;
    public Material TyreMaterial;
    public Material rimMaterial;

    [Header("Spoilers")]
    public Spoilers[] spoilers;

    [Header("Bumpers")]
    public FrontBumpers[] frontBumpers;

}

[System.Serializable]
public struct Spoilers
{
    public GameObject spoiler;
    public Vector3 position;
    public Vector3 rotation;
}

[System.Serializable]
public struct FrontBumpers {

    public GameObject bumper;
    public Vector3 position;
    public Vector3 rotation;

}
