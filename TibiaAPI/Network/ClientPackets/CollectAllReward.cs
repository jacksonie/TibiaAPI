using OXGaming.TibiaAPI.Constants;
using OXGaming.TibiaAPI.Utilities;

namespace OXGaming.TibiaAPI.Network.ClientPackets
{
    public class CollectAllReward : ClientPacket
    {

        public Position Position { get; set; }

        public ushort ObjectId { get; set; }

        public byte StackPosition { get; set; }

        public CollectAllReward(Client client)
        {
            Client = client;
            PacketType = ClientPacketType.CollectAllReward;
        }

        public override void ParseFromNetworkMessage(NetworkMessage message)
        {
            Position = message.ReadPosition();
            ObjectId = message.ReadUInt16();
            StackPosition = message.ReadByte();
        }

        public override void AppendToNetworkMessage(NetworkMessage message)
        {
            message.Write((byte)ClientPacketType.CollectAllReward);
            message.Write(Position);
            message.Write(ObjectId);
            message.Write(StackPosition);
        }
    }
}
