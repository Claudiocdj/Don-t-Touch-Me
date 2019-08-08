using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerDestroy : OnTrigger
{
    protected override void Trigger(GameObject other)
    {
        Destroy( gameObject );
    }
}