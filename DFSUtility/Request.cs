using System;

namespace DFSUtility
{
    [Serializable]
    public class Request
    {
        //Set by client
        public int Id { get; set; }
        public Command Command { get; set; }
        public string Type { get; set; }       
        public string Method { get; set; }
        public object[] Parameters { get; set; }
        public byte[] Bytes { get; set; }

        //Server sets this and uses it to uniquely identify forwarded requests
        public Guid Guid { get; set; } 
    }
}
