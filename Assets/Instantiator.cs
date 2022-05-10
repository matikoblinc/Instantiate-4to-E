using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instantiator : MonoBehaviour
{
    public GameObject objectToClone;
    public int CloneAmmount;
    public Text txtUserCloneAmount;
    GameObject clon;

    public void MultiInstantiate()
    {
        CloneAmmount = int.Parse(txtUserCloneAmount.text);

        for (int i = 0; i < CloneAmmount; i++)
        {
           clon = Instantiate(objectToClone);
            Destroy(clon, 1);
        }
    }
}
