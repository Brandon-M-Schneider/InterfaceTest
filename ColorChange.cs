using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Interface contract requires a property for a random RGB color
// and a method that changes the object color.
public interface ColorChange
{

    Color RandomColors { get; set; }

    void ChangeColor(Color rColor);
  
}
