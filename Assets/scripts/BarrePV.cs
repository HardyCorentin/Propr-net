using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Alexis{
public class BarrePV : MonoBehaviour
{
    public VictoryorDefeat vd;
    public Image fillbarre;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        fillbarre.fillAmount = vd.hp;
    }
}
}
