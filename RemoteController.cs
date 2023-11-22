using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class RemoteController
    {
        ICommand[] slot;

        public RemoteController(int buttonCount)
        {
            slot = new ICommand[buttonCount];

            for (int i = 0; i < slot.Length; i++)
            {
                slot[i] = new NoCommand();
            }
        }

        public void setCommand(int remoteButtonIndex, ICommand command)
        {
            slot[remoteButtonIndex] = command;
        }
        public void buttonWasPressed(int remoteButtonIndex)
        {
            slot[remoteButtonIndex].execute();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(">>>>>>>>>> Control Buttons <<<<<<<<<<<\n");
            for (int i = 0; i < slot.Length; i++)
            {
                sb.Append("[press " + i + " to] " + slot[i].GetType().Name + "\n");
            }
            sb.Append("!!!!!!!!!!!!!!!!!!!!!!!!!!");
            return sb.ToString();
        }
    }
}
