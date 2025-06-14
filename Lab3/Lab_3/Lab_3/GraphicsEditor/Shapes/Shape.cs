﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Shape
{
    protected IRenderer renderer;
    public Shape(IRenderer renderer) => this.renderer = renderer;
    public abstract void Draw();
}
