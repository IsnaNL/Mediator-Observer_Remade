using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReColorRoom : AbstractReColorRoom
{
    public Duckling duckling;
    public Color selectedColor;
    public bool buttonClicked;


    public override void Register(List<BabyDuck> ducks)
    {
        Debug.Log("Register Ducks To Recoloring" + "- Mediator");
        //ducks = duckling._babyDucks;
        foreach (BabyDuck d in ducks)
        {
          
            if(d.CoinFlip() == 1)
            {
                Debug.Log("Duck Has Been Sent To Color Room" + " /" + this.gameObject.name + "- Mediator");
                sendColor(selectedColor, d);
            }
            else
            {
                Debug.Log("Duck Declined Color Room" + " /" + this.gameObject.name + "- Mediator");
                sendColor(Color.yellow, d);

            }

            //sendColor(selectedColor, d);

        }
    }
    public void ButtonClicked()
    {
        Debug.Log("Player Pressed recolor" + " /" +"- Mediator");
        buttonClicked = true;
    }
    private void Update()
    {
        if (buttonClicked)
        {
            buttonClicked = false;
            Register(duckling._babyDucks);

        }
    }

    /* public override void Register(BabyDuck babyDuck)
{
    throw new System.NotImplementedException();
}*/

    public override void sendColor(Color color, BabyDuck d)
    {
        d.GetComponent<MeshRenderer>().material.color = color;
        Debug.Log("ColorChanged" + " / " + " End Of Loop" + "- Mediator");
    }

   
    
}
