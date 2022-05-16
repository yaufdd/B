using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Cube", menuName = "cube")]
public class Cube : ScriptableObject
{
    public float songPosInBeats;
    public float beatOfThisNote;

    public Conductor conductor;

}
