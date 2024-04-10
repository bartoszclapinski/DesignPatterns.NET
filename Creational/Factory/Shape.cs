﻿namespace DesignPatternsNET.Creational.Factory;

public abstract class Shape
{
    public int x { get; set; }
    public int y { get; set; }
    
    public abstract void Render();
}