using System;

namespace DFSUtility
{
    [Serializable]
    public class Request
    {
        public int Id { get; set; }
        public Command Command { get; set; }
        public string Type { get; set; }       
        public string Method { get; set; }
        public object[] Parameters { get; set; }
        public byte[] Bytes { get; set; }
    }
}
