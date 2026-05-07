using KinkLinkCommon.Domain.Wardrobe;
using MessagePack;

namespace KinkLinkCommon.Domain.Network.SyncPairState;

[MessagePackObject(keyAsPropertyName: true)]
public record SyncPairStateCommand(
    string TargetFriendCode,
    UserPermissions GrantedTo,
    PairWardrobeStateDto WardrobeState,
    List<LockInfoDto> LockStates
);
