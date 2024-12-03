using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{
    [SerializeField] private float dailyFoodConsumption;
    [SerializeField] private int activityLevel = 3;

    public override void Start()
    {
        Init("Dog");
        base.Start();
    }

    public override void CalculateFoodRequirement()
    {
        float foodRequirement = dailyFoodConsumption * activityLevel * 7;
        Debug.Log($"{animalName} eats {foodRequirement} kg of food daily with activity level {activityLevel}.");
    }

    public override void MakeSound()
    {
        base.MakeSound();
        Debug.Log("Honk Honk!");
    }

}
