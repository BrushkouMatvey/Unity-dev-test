﻿using Entitas;
using UnityEngine;

public class InitLevelSystem : IInitializeSystem  {
	private Contexts _contexts;
	
    public InitLevelSystem(Contexts contexts) {
    	_contexts = contexts;
    }

	public void Initialize()
	{
		spawnRing();
		var spawnBallTimerEntitty = _contexts.game.CreateEntity();
		spawnBallTimerEntitty.AddTimer(2);
		spawnBallTimerEntitty.isTimerState = true;
		//
		// var scoreEntity = _contexts.game.CreateEntity();
		// scoreEntity.AddResource(_contexts.game.globals.value.scorePrefab);
		// scoreEntity.AddScore(0);
	}
	private void spawnRing()
	{
		var ringEntity = _contexts.game.CreateEntity();
		ringEntity.AddResource(_contexts.game.globals.value.RingPrefab);
		ringEntity.isRing = true;
		ringEntity.ReplacePosition(new Vector2(0, 0));
	}
}