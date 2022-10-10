using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal
{
    public string Description;
    public bool Completed;
    public int RequiredAmount;
    public int CurrentAmount;

    public virtual void Init() {
    }

    public void Evaluate() {
        if (CurrentAmount >= RequiredAmount) {
            Complete();
        }
    }

    public void Complete() {
        Completed = true;
    }


}
