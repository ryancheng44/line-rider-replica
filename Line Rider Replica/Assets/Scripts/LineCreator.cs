using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineCreator : MonoBehaviour
{
    public GameObject linePrefab;

    Line activeLine;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject lineGameObject = Instantiate(linePrefab);
            activeLine = lineGameObject.GetComponent<Line>();
        }

        if (Input.GetMouseButtonUp(0))
        {
            activeLine = null;
        }

        if (activeLine != null)
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            activeLine.UpdateLine(mousePosition);
        }
    }
}
