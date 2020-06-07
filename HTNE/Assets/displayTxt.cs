using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class displayTxt : MonoBehaviour
{
    public string txt;
    public GameObject des;
    public GameObject BIGDES;
    // Start is called before the first frame update
    void Start()
    {
        BIGDES.SetActive(false);
    }
    private void OnMouseUp()
    {
        BIGDES.SetActive(true);
        des.GetComponent<Text>().text = txt;

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
