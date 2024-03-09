using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activable : MonoBehaviour
{

    public virtual bool IsActive()
    {
        return true;
    }
}
