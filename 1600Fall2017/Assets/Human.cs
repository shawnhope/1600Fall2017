using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human : Mammal {
public override void Start() {
        base.Start();
        FaceBook();
    }

    void FaceBook () {
        print(this.name + " booked their face");
    }
}
