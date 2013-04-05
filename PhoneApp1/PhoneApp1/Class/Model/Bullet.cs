﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using PhoneApp1.Resources;
using PhoneApp1.Class.Components;
using PhoneApp1.Class.Model;
using System.Windows.Automation;

namespace PhoneApp1.Class.Model {
    class Bullet: DynamicObject {
        public float Damage;
        public float Speed;
        public int TankIndex;
        public int index;

        public Bullet(string url, int TankIndex, int index)
            : base(url, TypeObject.Bullet) {
            this.Damage = 1;
            this.Speed = 1;
            this.setSize(new Size(20, 20));
            this.TankIndex = TankIndex;
            this.index = index;
            
        }
    }
}
