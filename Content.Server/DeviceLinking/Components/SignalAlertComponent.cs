using Content.Server.DeviceLinking.Systems;
using Robust.Shared.Audio;
using Robust.Shared.Prototypes;
using Content.Shared.Radio;

namespace Content.Server.DeviceLinking.Components;

/// <summary>
///     Simple switch that will send message to security radio.
/// </summary>
[RegisterComponent, Access(typeof(SignalAlertSystem))]
public sealed partial class SignalAlertComponent : Component
{
    /// <summary>
    /// Имя комнаты, которая отображается в рации.
    /// </summary>
    [DataField("nameRoom")]
    public string NameRoom = "неизвестной комнате";

    [DataField("clickSound")]
    public SoundSpecifier? ClickSound = new SoundPathSpecifier(
        "/Audio/Machines/panic.ogg",
        AudioParams.Default.WithMaxDistance(4).WithVolume(-8).WithPitchScale(0.5f)
        );

    [DataField("radioChannel")]
    public ProtoId<RadioChannelPrototype> RadioChannel = "Security";
}
