using GameFramework.Network;
using System;
using System.IO;

namespace GameCore.Network
{
    internal class NetworkChannelHelper : INetworkChannelHelper
    {
        public int PacketHeaderLength => throw new NotImplementedException();

        public Packet DeserializePacket(IPacketHeader packetHeader, Stream source, out object customErrorData)
        {
            throw new NotImplementedException();
        }

        public IPacketHeader DeserializePacketHeader(Stream source, out object customErrorData)
        {
            throw new NotImplementedException();
        }

        public void Initialize(INetworkChannel networkChannel)
        {
            throw new NotImplementedException();
        }

        public void PrepareForConnecting()
        {
            throw new NotImplementedException();
        }

        public bool SendHeartBeat()
        {
            throw new NotImplementedException();
        }

        public bool Serialize<T>(T packet, Stream destination) where T : Packet
        {
            throw new NotImplementedException();
        }

        public void Shutdown()
        {
            throw new NotImplementedException();
        }
    }
}
