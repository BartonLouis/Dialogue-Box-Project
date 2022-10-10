using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressKeyGoal : Goal
{
    public KeyCode expectedKey;
    public PressKeyGoal(string keyName, KeyCode keyCode) {
        Completed = false;
        RequiredAmount = 1;
        CurrentAmount = 0;
        Description = "Press the " + keyName + " key.";
    }

    public override void Init() {
        base.Init();
        GameEvents.current.UserPressedKey += KeyPressed;
    }

    public void KeyPressed(KeyCode keyCode) {
        if (keyCode == expectedKey) {
            CurrentAmount++;
            Evaluate();
        }
    }
}
