using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
[ExecuteInEditMode]

public class piece_Gizmos : MonoBehaviour
{
    private class Piece
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

        [SerializeField] 
        private GameObject thisPiece;
   
        public void OnDrawGizmos()
        {
            switch (pieceType)
            {
                case PieceType.Pawn:
                    Gizmos.color = Color.red;
                    Gizmos.DrawLine(thisPiece.transform.position, thisPiece.transform.position + Vector3.forward * 2);
                    
                    break;
                case PieceType.Rook:
                    Gizmos.color = Color.blue;
                    Gizmos.DrawLine(thisPiece.transform.position, thisPiece.transform.position + Vector3.forward * 8);
                    Gizmos.DrawLine(thisPiece.transform.position, thisPiece.transform.position + Vector3.right * 8);
                    Gizmos.DrawLine(thisPiece.transform.position, thisPiece.transform.position + Vector3.back * 8);
                    Gizmos.DrawLine(thisPiece.transform.position, thisPiece.transform.position + Vector3.left * 8);
                    break;
                case PieceType.Knight:
                    Gizmos.color = Color.green;
                    Gizmos.DrawLine(thisPiece.transform.position, thisPiece.transform.position + Vector3.forward * 2);
                    break;
                case PieceType.Bishop:
                    Gizmos.color = Color.yellow;
                    Gizmos.DrawLine(thisPiece.transform.position, thisPiece.transform.position + Vector3.forward * 0.5f);
                    break;
                case PieceType.Queen:
                    Gizmos.color = Color.magenta;
                    Gizmos.DrawLine(thisPiece.transform.position, thisPiece.transform.position + Vector3.forward * 0.5f);
                    break;
                case PieceType.King:
                    Gizmos.color = Color.cyan;
                    Gizmos.DrawLine(thisPiece.transform.position, thisPiece.transform.position + Vector3.forward * 0.5f);
                    break;
            }
        }
        
    }
    /*
    private class Pawn:Pieces
    {
        
        private void OnDrawGizmos()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawLine(Vector3.zero, 0.5f);
        }
    }
    
    private class Rook:Pieces
    {
        private void OnDrawGizmos()
        {
            Gizmos.color = Color.blue;
            Gizmos.DrawLine(Vector3.zero, 0.5f);
        }
    }
    
    private class Knight:Pieces
    {
        private void OnDrawGizmos()
        {
            Gizmos.color = Color.green;
            Gizmos.DrawLine(Vector3.zero, 0.5f);
        }
    }
    
    private class Bishop:Pieces
    {
        private void OnDrawGizmos()
        {
            Gizmos.color = Color.yellow;
            Gizmos.DrawLine(Vector3.zero, 0.5f);
        }
    }
    
    private class Queen:Pieces
    {
        private void OnDrawGizmos()
        {
            Gizmos.color = Color.magenta;
            Gizmos.DrawLine(Vector3.zero, 0.5f);
        }
    }
    
    private class King:Pieces
    {
        private void OnDrawGizmos()
        {
            Gizmos.color = Color.cyan;
            Gizmos.DrawLine(Vector3.zero, 0.5f);
        }
    }
    */
    
    
    
}
