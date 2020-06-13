using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Interface requires upward and downward movement be set for the
// interhited object.
public interface Movement
{
    void UpwardMovement();

    void DownwardMovement();
}
