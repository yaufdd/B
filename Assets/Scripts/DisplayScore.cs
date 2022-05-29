using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayScore : MonoBehaviour
{
    public TextMeshProUGUI scoreMesh;

    public GameManager gameManager;




    void Start()
    {
        scoreMesh = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {   
        scoreMesh.text = $"{gameManager.result_persentage}" + "%";
    }
}
