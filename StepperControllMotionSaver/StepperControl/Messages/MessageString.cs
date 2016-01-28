﻿using System;

namespace StepperControl.Messages
{
    public class MessageString : EventArgs
    {
        public string Message { get; private set; }

        public MessageString(string message)
        {
            this.Message = message;
        }
    }
}
