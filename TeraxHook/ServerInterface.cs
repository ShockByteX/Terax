using System;

namespace TeraxHook
{
    public class ServerInterface : MarshalByRefObject
    {
        public void IsInstalled(int clientPId) { }
        public void ReportMessages(int clientPID, string[] messages) { }
        public void ReportMessage(int clientPID, string message) { }
        public void ReportException(Exception e) { }
        public void Ping() { }
    }
}