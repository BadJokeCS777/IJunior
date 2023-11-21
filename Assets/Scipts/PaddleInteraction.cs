using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

public class PaddleInteraction : IInputInteraction
{
    public float Duration = 0.2f;

    [InitializeOnLoadMethod]
    private static void Register()
    {
        InputSystem.RegisterInteraction<PaddleInteraction>();
    }
    
    public void Process(ref InputInteractionContext context)
    {
        if (context.timerHasExpired)
        {
            context.Canceled();
            return;
        }
        
        switch (context.phase)
        {
            case InputActionPhase.Waiting:
                if (Mathf.Approximately(context.ReadValue<float>(), 1f))
                {
                    context.Started();
                    context.SetTimeout(Duration);
                }
                break;
            case InputActionPhase.Started:
                if (Mathf.Approximately(context.ReadValue<float>(), -1f))
                {
                    context.Performed();
                }
                break;
        }
    }

    public void Reset() {}
}
