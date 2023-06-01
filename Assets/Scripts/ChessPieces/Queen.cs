using UnityEngine;
using System.Collections.Generic;
public class Queen : ChessPiece
{
    public override List<Vector2Int> GetAvailableMoves(ref ChessPiece[,] board, int TILE_COUNT_X,int TILE_COUNT_Y)
    {
        List<Vector2Int> r = new List<Vector2Int>();

            //Down
        for(int i = currentY-1; i>=0 ;i--)
        {
            if(board[currentX,i]==null)
                r.Add(new Vector2Int(currentX,i));

            if(board[currentX,i] != null)
                {
                    if(board[currentX,i].team != team)
                        r.Add(new Vector2Int(currentX,i));
                    break;
                }
                
        }

        //Up
        for(int i = currentY+1;i < TILE_COUNT_Y;i++)
        {
            if(board[currentX,i]==null)
                r.Add(new Vector2Int(currentX,i));

            if(board[currentX,i] != null)
                {
                    if(board[currentX,i].team != team)
                        r.Add(new Vector2Int(currentX,i));
                    break;
                }
                
        }
        //Left
        for(int i = currentX -1;i>=0;i--)
        {
            if(board[i,currentY]==null)
                r.Add(new Vector2Int(i,currentY));

            if(board[i,currentY] != null)
                {
                    if(board[i,currentY].team != team)
                        r.Add(new Vector2Int(i,currentY));
                    break;
                }
                
        }

        //Right
        for(int i = currentX +1;i< TILE_COUNT_X;i++)
        {
            if(board[i,currentY]==null)
                r.Add(new Vector2Int(i,currentY));

            if(board[i,currentY] != null)
                {
                    if(board[i,currentY].team != team)
                        r.Add(new Vector2Int(i,currentY));
                    break;
                }
                
        }

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
