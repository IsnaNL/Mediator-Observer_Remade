using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duckling : MonoBehaviour
{
     
   // private string _symbol;
   // private Vector3 _des;
    [SerializeField]
    public List<BabyDuck> _babyDucks = new List<BabyDuck>();

    // Constructor

    /*public Duckling(string symbol, Vector3 des)
    {
        this._symbol = symbol;
        this._des = des;
    }*/

    public void Attach(BabyDuck _babyDuck)
    {
        _babyDucks.Add(_babyDuck);
        Debug.Log("Fill List With Baby Ducks- Observer");
    }

    public void Detach(BabyDuck _babyDuck)
    {
        _babyDucks.Remove(_babyDuck);
    }

    public void Notify()
    {
       
        foreach (BabyDuck _babyDuck in _babyDucks)
        {
            _babyDuck.Move(transform.position);
            Debug.Log("Notify Baby Ducks that the subject moved and that they need to move- Observer");

        }


    }

    // Gets or sets the price
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space Clicked Subject calls Observers- Observer");

            Notify();
        }
    }
   /* public Vector3 des
    {
        get { return _des; }
        set

        {
            if (_des != des)
            {
                _des = des;
             Notify());
            }
        }
    }*/

    // Gets the symbol

  /*  public string Symbol
    {
        get { return _symbol; }
    }*/
}

