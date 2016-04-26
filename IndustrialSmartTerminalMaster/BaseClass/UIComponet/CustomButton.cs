﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WfGUI.Forms
{
    public class CustomButton : System.Windows.Forms.Button
    {
        public delegate void ButtonTouchDownHandler(object sender,EventArgs e);
        public event ButtonTouchDownHandler buttonTouchDownEvent;
        public delegate void ButtonTouchUpHandler(object sender, EventArgs e);
        public event ButtonTouchUpHandler buttonTouchUpEvent;
        public event Action<object, EventArgs> customerevent;
         

        public CustomButton()
        {
        }
        protected override void WndProc(ref System.Windows.Forms.Message msg)
        {
            const int WM_POINTERDOWN = 0x0246;
            const int WM_POINTERUP = 0x247;
            switch (msg.Msg)
            {
                case WM_POINTERDOWN:
                    Debug.WriteLine("DOWN");
                    this.buttonTouchDownEvent(this, new EventArgs());
                    
                    break;
                case WM_POINTERUP:
                    Debug.WriteLine("UP");
                    this.buttonTouchUpEvent(this, new EventArgs());
                    break;
            }
            base.WndProc(ref msg);
        }
    }
}
