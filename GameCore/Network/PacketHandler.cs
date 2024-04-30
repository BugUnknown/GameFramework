using GameFramework.Network;
using System;

namespace GameCore.Network
{
    internal class PacketHandler : IPacketHandler
    {
        public int Id => throw new NotImplementedException();

        public void Handle(object sender, Packet packet)
        {
            throw new NotImplementedException();
        }
    }
}
