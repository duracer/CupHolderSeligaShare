using System;

namespace Keyence.IV.Sdk.Sample_CSharp.Parts
{
    public class ToolSelectedEventArgs : EventArgs
    {
        private readonly byte toolNo;

        public ToolSelectedEventArgs(byte toolNo){
            this.toolNo = toolNo;
        }

        public byte ToolNo{
            get { return toolNo; }
        }
    }
}