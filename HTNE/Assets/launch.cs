using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class launch : MonoBehaviour
{
    public GameObject current;
    public GameObject next;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("CLICKME1");
        current.SetActive(true);
        next.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void IhavebeenclickeD()
    {
        Debug.Log("CLICKME");
    }
    public void StartApp()
    {
        Debug.Log("CLICKME");
        current.SetActive(false);
        next.SetActive(true);
    }
}
