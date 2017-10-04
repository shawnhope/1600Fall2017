using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Whale : Mammal {

    public override void Start() {
        base.Start();
        Beaches();
    }

    void Beaches () {
        print(this.name + " Beaches");
        furColor = Color.black;
        BeardColor = Color.white;
    }

}
