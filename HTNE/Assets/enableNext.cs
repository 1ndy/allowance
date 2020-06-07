using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enableNext : MonoBehaviour
{
    public GameObject next;
    public GameObject greenline;
    public GameObject current;
    public Material green;
    public Material red;
    public GameObject redline1;
    public GameObject redline2;
    public GameObject redline3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void advancegraph()
    {
        SpriteRenderer m_SpriteRenderer;
        m_SpriteRenderer = current.GetComponent<SpriteRenderer>();
        m_SpriteRenderer.color = new Color(0.89803921568f, 0.87058823529f, 0.15686274509f, 100);

        SpriteRenderer m_SpriteRenderer2;
        m_SpriteRenderer2 = next.GetComponent<SpriteRenderer>();
        m_SpriteRenderer2.color = new Color(255/255, 255/255, 255/255, 100);

        Material newRender;
        newRender = greenline.GetComponent<Renderer>().material;
        newRender.color = Color.green;

        newRender = redline1.GetComponent<Renderer>().material;
        newRender.color = Color.red;
        newRender = redline2.GetComponent<Renderer>().material;
        newRender.color = Color.red;
        newRender = redline3.GetComponent<Renderer>().material;
        newRender.color = Color.red;
    }
}
