using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Cell
{
    private int x, z;
    private bool isTaken;
    private CellObjectType objectType;

    public int X { get => x; }
    public int Z { get => z; }
    public bool IsTaken { get => isTaken; set => isTaken = value; }
    public CellObjectType ObjectType { get => objectType; set => objectType = value; }

    public Cell(int x, int z)
    {
        this.x = x;
        this.z = z;
        this.objectType = CellObjectType.Empty;
        isTaken = false;
    }
}

public enum CellObjectType
{
    Empty = -1,
    Plain = 0,
    Forest = 1,
    Hill = 2,
    Mountain = 3
}
