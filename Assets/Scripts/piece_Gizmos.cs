using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
[ExecuteInEditMode]

public class piece_Gizmos : MonoBehaviour
{
  
       public enum PieceType
        {
           Pawn,
           Rook,
           Knight,
           Bishop,
           Queen,
           King
        }
        
       [SerializeField] 
       private PieceType pieceType;
       public void OnDrawGizmos()
       {
           switch (pieceType)
           {
               case PieceType.Pawn:
                   Gizmos.color = Color.red;
                   Gizmos.DrawLine(this.gameObject.transform.position, this.gameObject.transform.position + Vector3.forward * 2);
                   //access the sprite
                   if(this.gameObject.GetComponent<SpriteRenderer>() == null)
                   {
                       this.gameObject.AddComponent<SpriteRenderer>();
                       this.gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Pieces/pawn");
                   }
                   else
                   {
                       Debug.Log("Sprite is not null");
                       this.gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Pieces/pawn");
                   }
                   break;
               case PieceType.Rook:
                   Gizmos.color = Color.blue;
                   Gizmos.DrawLine(this.gameObject.transform.position,
                       this.gameObject.transform.position + Vector3.forward * 2);
                   Gizmos.DrawLine(this.gameObject.transform.position,
                       this.gameObject.transform.position + Vector3.right * 2);
                   Gizmos.DrawLine(this.gameObject.transform.position,
                       this.gameObject.transform.position + Vector3.back * 2);
                   Gizmos.DrawLine(this.gameObject.transform.position,
                       this.gameObject.transform.position + Vector3.left * 2);
                   //access the sprite
                    if(this.gameObject.GetComponent<SpriteRenderer>() == null)
                    {
                       this.gameObject.AddComponent<SpriteRenderer>();
                       this.gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Pieces/rook");
                    }
                    else
                    {
                        Debug.Log("Sprite is not null");
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Pieces/rook");
                    }
                   break;
               case PieceType.Knight:
                   
                   Gizmos.color = Color.green;
                   //forward
                   Gizmos.DrawLine(this.gameObject.transform.position, this.gameObject.transform.position + Vector3.forward * 2);
                   Gizmos.DrawLine(this.gameObject.transform.position + Vector3.forward * 2, this.gameObject.transform.position + Vector3.forward * 2 + Vector3.right * 1);
                   Gizmos.DrawLine(this.gameObject.transform.position + Vector3.forward * 2, this.gameObject.transform.position + Vector3.forward * 2 + Vector3.left * 1);
                   //right
                   Gizmos.DrawLine(this.gameObject.transform.position, this.gameObject.transform.position + Vector3.right * 2);
                   Gizmos.DrawLine(this.gameObject.transform.position + Vector3.right * 2, this.gameObject.transform.position + Vector3.right * 2 + Vector3.forward * 1);
                   Gizmos.DrawLine(this.gameObject.transform.position + Vector3.right * 2, this.gameObject.transform.position + Vector3.right * 2 + Vector3.back * 1);
                   //back
                   Gizmos.DrawLine(this.gameObject.transform.position, this.gameObject.transform.position + Vector3.back * 2);
                   Gizmos.DrawLine(this.gameObject.transform.position + Vector3.back * 2, this.gameObject.transform.position + Vector3.back * 2 + Vector3.right * 1);
                   Gizmos.DrawLine(this.gameObject.transform.position + Vector3.back * 2, this.gameObject.transform.position + Vector3.back * 2 + Vector3.left * 1);
                   //left
                   Gizmos.DrawLine(this.gameObject.transform.position, this.gameObject.transform.position + Vector3.left * 2);
                   Gizmos.DrawLine(this.gameObject.transform.position + Vector3.left * 2, this.gameObject.transform.position + Vector3.left * 2 + Vector3.forward * 1);
                   Gizmos.DrawLine(this.gameObject.transform.position + Vector3.left * 2, this.gameObject.transform.position + Vector3.left * 2 + Vector3.back * 1);
                    //access the sprite
                   if(this.gameObject.GetComponent<SpriteRenderer>() == null)
                   {
                       this.gameObject.AddComponent<SpriteRenderer>();
                       this.gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Pieces/knight");
                   }
                   else
                   {
                       Debug.Log("Sprite is not null");
                       this.gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Pieces/knight");
                   }
                   break;
               case PieceType.Bishop:
                   Gizmos.color = Color.yellow;
                   Gizmos.DrawLine(this.gameObject.transform.position, this.gameObject.transform.position + Vector3.forward * 2 - Vector3.right * -1.5f);
                   Gizmos.DrawLine(this.gameObject.transform.position, this.gameObject.transform.position + Vector3.forward * 2 - Vector3.left * -1.5f);
                   Gizmos.DrawLine(this.gameObject.transform.position, this.gameObject.transform.position + Vector3.back * 2 - Vector3.right * 1.5f);
                   Gizmos.DrawLine(this.gameObject.transform.position, this.gameObject.transform.position + Vector3.back * 2 - Vector3.left * 1.5f);
                    //access the sprite
                    if(this.gameObject.GetComponent<SpriteRenderer>() == null)
                    {
                        this.gameObject.AddComponent<SpriteRenderer>();
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Pieces/bishop");
                    }
                    else
                    {
                        Debug.Log("Sprite is not null");
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Pieces/bishop");
                    }
                    break;
               case PieceType.Queen:
                   Gizmos.color = Color.magenta;
                   Gizmos.DrawLine(this.gameObject.transform.position, this.gameObject.transform.position + Vector3.forward * 2); 
                   Gizmos.DrawLine(this.gameObject.transform.position, this.gameObject.transform.position + Vector3.right * 2);
                   Gizmos.DrawLine(this.gameObject.transform.position, this.gameObject.transform.position + Vector3.back * 2);
                   Gizmos.DrawLine(this.gameObject.transform.position, this.gameObject.transform.position + Vector3.left * 2);
                   Gizmos.DrawLine(this.gameObject.transform.position, this.gameObject.transform.position + Vector3.forward * 2 - Vector3.right * -1.5f);
                   Gizmos.DrawLine(this.gameObject.transform.position, this.gameObject.transform.position + Vector3.forward * 2 - Vector3.left * -1.5f);
                   Gizmos.DrawLine(this.gameObject.transform.position, this.gameObject.transform.position + Vector3.back * 2 - Vector3.right * 1.5f);
                   Gizmos.DrawLine(this.gameObject.transform.position, this.gameObject.transform.position + Vector3.back * 2 - Vector3.left * 1.5f);
                    //access the sprite
                    if(this.gameObject.GetComponent<SpriteRenderer>() == null)
                    {
                        this.gameObject.AddComponent<SpriteRenderer>();
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Pieces/queen");
                    }
                    else
                    {
                        Debug.Log("Sprite is not null");
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Pieces/queen");
                    }
                    break;
               case PieceType.King:
                   Gizmos.color = Color.cyan;
                   Gizmos.DrawLine(this.gameObject.transform.position, this.gameObject.transform.position + Vector3.forward * 1); 
                   Gizmos.DrawLine(this.gameObject.transform.position, this.gameObject.transform.position + Vector3.right * 1);
                   Gizmos.DrawLine(this.gameObject.transform.position, this.gameObject.transform.position + Vector3.back * 1);
                   Gizmos.DrawLine(this.gameObject.transform.position, this.gameObject.transform.position + Vector3.left * 1);
                   Gizmos.DrawLine(this.gameObject.transform.position, this.gameObject.transform.position + Vector3.forward * 1 - Vector3.right * -1.5f);
                   Gizmos.DrawLine(this.gameObject.transform.position, this.gameObject.transform.position + Vector3.forward * 1 - Vector3.left * -1.5f);
                   Gizmos.DrawLine(this.gameObject.transform.position, this.gameObject.transform.position + Vector3.back * 1 - Vector3.right * 1.5f);
                   Gizmos.DrawLine(this.gameObject.transform.position, this.gameObject.transform.position + Vector3.back * 1 - Vector3.left * 1.5f);
                    //access the sprite
                    if(this.gameObject.GetComponent<SpriteRenderer>() == null)
                    {
                        this.gameObject.AddComponent<SpriteRenderer>();
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Pieces/king");
                    }
                    else
                    {
                        Debug.Log("Sprite is not null");
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Pieces/king");
                    }
                    break;
           }
       }
        
}
    
    
    
    
