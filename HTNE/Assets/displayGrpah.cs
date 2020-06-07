using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class displayGrpah : MonoBehaviour
{

    public GameObject graph;
    public GameObject other1;

    public bool status;
    // Start is called before the first frame update
    void Start()
    {
        graph.SetActive(false);
        other1.SetActive(false);
        status = false;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void toggleGraph()
    {
        graph.SetActive(!status);
        other1.SetActive(false);
        status = !status;

    }
}
