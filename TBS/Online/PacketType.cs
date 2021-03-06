﻿namespace TeamStor.TBS.Online
{
    /// <summary>
    /// Online packet type.
    /// </summary>
    public enum PacketType : byte
    {
        /// <summary>
        /// If sent by server -> Add new player to game data
        /// If sent by client -> Read name, add and send player and send list of all players
        /// Called in lobby
        /// </summary>
        PlayerConnected,
        
        /// <summary>
        /// If sent by server -> Remove player from game data
        /// Called in lobby and in-game
        /// </summary>
        PlayerDisconnected,
        
        /// <summary>
        /// If sent by server -> new GameData with map specified, disconnect if map is not found in maps/[name]
        /// Called in lobby
        /// </summary>
        LoadMap,
        
        /// <summary>
        /// If sent by server -> Switches to GameplayState and starts the game
        /// Called in lobby
        /// </summary>
        StartGameplay
    }
}