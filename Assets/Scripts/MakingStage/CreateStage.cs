using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;

public class CreateStage : MonoBehaviour
{


    public GameObject stage;
    public void SaveStage(){
        PrefabUtility.SaveAsPrefabAsset(stage, "Assets/Stages/" + stage.name + ".prefab");
    }

    public void SwitchScene(){
        SceneManager.LoadScene("PlayScene");
        
    }
}
