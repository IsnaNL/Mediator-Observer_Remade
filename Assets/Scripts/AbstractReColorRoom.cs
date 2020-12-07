using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractReColorRoom : MonoBehaviour
{
    // Start is called before the first frame update
    public abstract void sendColor(Color color, BabyDuck d);
    public abstract void Register(List<BabyDuck> ducks);
    
}
