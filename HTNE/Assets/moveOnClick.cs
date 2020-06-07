using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveOnClick : MonoBehaviour
{
    private bool started;
    private Vector3 newPos;
    private Vector3 startPoint;
    private Vector3 prevPos;
    private bool zoomed;

    public GameObject confirmButton;
    // Start is called before the first frame update
    void Start()
    {
        started = false;
        startPoint = Camera.main.transform.position;
        confirmButton.SetActive(false);
    }
    private void OnMouseUp()
    {
        confirmButton.SetActive(true);
        if (!started)
        {
            Debug.Log("Touch");
            newPos = new Vector3(this.transform.position.x, this.transform.position.y, -550);
            startPoint = Camera.main.transform.position;
            started = true;
        }

    }
    // Update is called once per frame
    void Update()
    {
        if (started)
        {
            Camera.main.transform.position = Vector3.Lerp(Camera.main.transform.position, newPos, 3.5f*(Time.deltaTime));

            if (Mathf.Abs(Camera.main.transform.position.x - this.transform.position.x) < 5 && Mathf.Abs(Camera.main.transform.position.y - this.transform.position.y) < 5)
            {
                Debug.Log("STOPPED");
                started = false;
            }
        }
        if (Input.GetMouseButtonDown(1))
        {
            Vector3 tmp = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y, -951);
            Camera.main.transform.position = tmp;
        }
    }

    public void displayConfirm()
    {
        confirmButton.SetActive(true);
    }
}
