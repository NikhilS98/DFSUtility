using System;

namespace DFSUtility
{
    [Serializable]
    public class Response
    {
        public Command Command { get; set; }
        public Request Request { get; set; }
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public string Data { get; set; }
        public byte[] Bytes { get; set; }

    }
}
