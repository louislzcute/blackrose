﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using WorldOfTank.Class.Components;

namespace WorldOfTank.Class.Model
{
    abstract class DynamicObject : ObjectGame
    {
        public DynamicObject(Image Image, TypeObject Type)
            : base(Image, Type)
        {
        }

        public void RotateLeft(float value)
        {
            this.Direction -= value;
        }

        public void RotateRight(float value)
        {
            this.Direction += value;
        }

        public void MoveForward(float value)
        {
            double rad = Math.PI * this.Direction / 180;
            this.Position.X += (float)Math.Sin(rad) * value;
            this.Position.Y -= (float)Math.Cos(rad) * value;
        }

        public void MoveBackward(float value)
        {
            double rad = Math.PI * this.Direction / 180;
            this.Position.X -= (float)Math.Sin(rad) * value;
            this.Position.Y += (float)Math.Cos(rad) * value;
        }
    }
}
