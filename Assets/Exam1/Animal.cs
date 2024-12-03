using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    protected string animalName;

    public virtual void Start()
    {
        DisplayName();
        MakeSound();
        CalculateFoodRequirement();
    }

    public void Init(string _newAnimalName)
    {
        animalName = _newAnimalName;
    }

    public abstract void CalculateFoodRequirement();

    public virtual void MakeSound()
    {
        Debug.Log($"The animal makes a sound.");
    }

    public void DisplayName()
    {
        Debug.Log($"This is {animalName}.");
    }
}
