using GameFramework.Network;
using System;

namespace GameCore.Network
{
    internal class PacketHeader : IPacketHeader
    {
        public int PacketLength => throw new NotImplementedException();
    }
}
