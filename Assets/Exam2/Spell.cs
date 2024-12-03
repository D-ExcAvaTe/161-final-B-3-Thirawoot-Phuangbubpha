using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spell : MonoBehaviour
{
    private void Start()
    {
        Debug.Log("[base] --------------------------- Spell-Casting Simulation Started! ---------------------------");
        Cast();
    }
    public virtual void Cast()
    {
        Debug.Log("[base] Casting spell...");
    }
    public void Cast(string target)
    {
        Debug.Log($"[base] Casting a spell on target: {target}");

    }
    public void Cast(string target,int powerLevel)
    {
        Debug.Log($"[base] Casting a spell on target: {target} with power level: {powerLevel}");

    }
}
