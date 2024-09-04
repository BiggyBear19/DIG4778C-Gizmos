using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class board_Gizmo : MonoBehaviour
{
    private void OnDrawGizmos()
    {
        Vector3 grid_length = Vector3.right * 8;
        Vector3 grid_height = Vector3.forward * 8;
        
        Color square_color = Color.black;
        Color square_color1 = Color.white;
        bool is_color = true;
        
        for(int i = 0; i < 9; i++)
        {
            Vector3 start_Point = Vector3.forward * i;
            Debug.DrawLine(start_Point, start_Point + grid_length);
            
            for(int j = 0; j < 9; j++)
            {
                start_Point = Vector3.right * j;
                Debug.DrawLine(start_Point, start_Point + grid_height);
                is_color = !is_color;
                
                if (i >= 8 || j >= 8)
                    continue;
                
                if (is_color)
                {
                    Gizmos.color = square_color;
                    Gizmos.DrawCube(Vector3.forward * (i + 0.5f) + Vector3.right * (j + 0.5f), new Vector3(1, 0.01f, 1));
                }
                else
                {
                    Gizmos.color = square_color1;
                    Gizmos.DrawCube(Vector3.forward * (i + 0.5f) + Vector3.right * (j + 0.5f), new Vector3(1, 0.01f, 1));
                }
            }
        }
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
