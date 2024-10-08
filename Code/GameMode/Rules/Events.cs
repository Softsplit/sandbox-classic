﻿using Sandbox.Events;
using Softsplit;

/// <summary>
/// Called on the host when a new player joins, before NetworkSpawn is called.
/// </summary>
public record PlayerConnectedEvent( PlayerState PlayerState ) : IGameEvent;

/// <summary>
/// Called on the host when a new player joins, after NetworkSpawn is called.
/// </summary>
public record PlayerJoinedEvent( PlayerState Player ) : IGameEvent;

/// <summary>
/// Called on the host when a player (re)spawns.
/// </summary>
public record PlayerSpawnedEvent( PlayerPawn Player ) : IGameEvent;

/// <summary>
/// Called on the host when all scores should be reset.
/// </summary>
public record ResetScoresEvent : IGameEvent;

/// <summary>
/// Dispatches a <see cref="ResetScoresEvent"/> when this state is entered.
/// </summary>
/*
public sealed class ResetScores : Component,
	IGameEventHandler<EnterStateEvent>
{
	void IGameEventHandler<EnterStateEvent>.OnGameEvent( EnterStateEvent eventArgs )
	{
		Scene.Dispatch( new ResetScoresEvent() );
	}
}
*/
