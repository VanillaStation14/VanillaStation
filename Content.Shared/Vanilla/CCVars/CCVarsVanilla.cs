using Robust.Shared.Configuration;
using Robust.Shared;

namespace Content.Shared.Vanilla.CCVars;

[CVarDefs]
public sealed class CCVarsVanilla
{

    /// <summary>
    /// URL вебхука, используемого для отправки сообщений о банах на Discord сервер.
    /// </summary>
    public static readonly CVarDef<string> DiscordServerBansWebhook = CVarDef.Create("discord.server_bans_webhook", "", CVar.SERVERONLY);

    /// <summary>
    ///     Controls if the connections queue is enabled. If enabled stop kicking new players after `SoftMaxPlayers` cap and instead add them to queue.
    /// </summary>
    public static readonly CVarDef<bool> QueueEnabled = CVarDef.Create("queue.enabled", false, CVar.SERVERONLY);

    /// <summary>
    ///     Enabled Discord linking, show linking button and modal window
    /// </summary>
    public static readonly CVarDef<bool> DiscordAuthEnabled = CVarDef.Create("discord_auth.enabled", false, CVar.SERVERONLY);

    /// <summary>
    ///     URL of the Discord auth server API
    /// </summary>
    public static readonly CVarDef<string> DiscordAuthApiUrl = CVarDef.Create("discord_auth.api_url", "", CVar.SERVERONLY);

    /// <summary>
    ///     Secret key of the Discord auth server API
    /// </summary>
    public static readonly CVarDef<string> DiscordAuthApiKey = CVarDef.Create("discord_auth.api_key", "", CVar.SERVERONLY | CVar.CONFIDENTIAL);    

    /// <summary>
    /// разрешено ли голосование за ez mode?
    /// </summary>
    public static readonly CVarDef<bool> VoteEzmodeEnabled = CVarDef.Create("vote.ezmode_enabled", true, CVar.SERVERONLY);

    /// <summary>
    ///     Максимально-допустимое количество игроков для запуска голосования
    /// </summary>
    public static readonly CVarDef<int> VoteEzmodeMaxPlayers = CVarDef.Create("vote.ezmode_max_players", 10, CVar.SERVERONLY);

    /// <summary>
    ///     Устанавливает длительность голосование за лёгкий режим
    /// </summary>
    public static readonly CVarDef<int> EzmodeTimer = CVarDef.Create("ezmode.timer", 30, CVar.SERVERONLY);

    /// <summary>
    ///     Количество голосов "ЗА" для успешного прохождения
    /// </summary>
    public static readonly CVarDef<float> EzmodeRequiredRatio = CVarDef.Create("ezmode.required_ratio", 0.6f, CVar.SERVERONLY);
}