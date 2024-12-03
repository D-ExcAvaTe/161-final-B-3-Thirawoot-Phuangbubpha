using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : Animal
{
    [SerializeField] private float dailyFoodConsumption;
    [SerializeField] private float weight = 0.5f;

    public override void Start()
    {
        Init("Bird");
        base.Start();
    }

    public override void CalculateFoodRequirement()
    {
        float foodRequirement = dailyFoodConsumption * weight * 7;
        Debug.Log($"{animalName} eats {foodRequirement} kg of food daily and weights {weight}.");
    }

    public override void MakeSound()
    {
        base.MakeSound();
        Debug.Log("Jib Jib!");
    }
}
