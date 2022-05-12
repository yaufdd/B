using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class MakeStage : MonoBehaviour
{
    public GameObject stage;
    public void SaveStage(){
        PrefabUtility.SaveAsPrefabAsset(stage, "Assets/Stages/" + stage.name + ".prefab");
    }
}
