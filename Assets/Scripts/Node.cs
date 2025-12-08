using UnityEngine;

public class Node
{
    public bool walkable;
    public Vector3 worldPosition;
    public int gridX;
    public int gridY;

    // gCost = distance from starting node
    public int gCost;
    // hCost (heuristic) = distance from end node
    public int hCost;

    public Node parent;

    public Node(bool _walkable, Vector3 _worldPos, int _gridX, int _gridY)
    {
        walkable = _walkable;
        worldPosition = _worldPos;
        gridX = _gridX;
        gridY = _gridY;
    }
    // fCost = gCost + hCost
    public int fCost 
    {
        get 
        {
            return gCost + hCost;
        }
    }
}
