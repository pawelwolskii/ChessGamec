using UnityEngine;
using System.Collections.Generic;

public class Bishop : ChessPiece
{
    public override List<Vector2Int> GetAvailableMoves(ref ChessPiece[,] board, int TILE_COUNT_X,int TILE_COUNT_Y)
    {
        List<Vector2Int> r = new List<Vector2Int>();

        // Top Right
        for (int x = currentX + 1, y = currentY + 1; x < TILE_COUNT_X && y < TILE_COUNT_Y;x++, y++)
        {
            if(board[x,y] == null)
                r.Add(new Vector2Int(x,y));
            else
            {
                if(board[x,y].team != team)
                    r.Add(new Vector2Int(x,y));

                break;
            }
        }
        // Top Left
        for (int x = currentX - 1, y = currentY + 1; x >= 0 && y < TILE_COUNT_Y;x--, y++)
        {
            if(board[x,y] == null)
                r.Add(new Vector2Int(x,y));
            else
            {
                if(board[x,y].team != team)
                    r.Add(new Vector2Int(x,y));

                break;
            }
        }

        // Bottom right
        for (int x = currentX + 1, y = currentY - 1; x < TILE_COUNT_X && y >= 0;x++, y--)
        {
            if(board[x,y] == null)
                r.Add(new Vector2Int(x,y));
            else
            {
                if(board[x,y].team != team)
                    r.Add(new Vector2Int(x,y));

                break;
            }
        }

        // Bottom left
        for (int x = currentX - 1, y = currentY - 1; x >= 0 && y >= 0;x--, y--)
        {
            if(board[x,y] == null)
                r.Add(new Vector2Int(x,y));
            else
            {
                if(board[x,y].team != team)
                    r.Add(new Vector2Int(x,y));

                break;
            }
        }


        return r;
    }

}
