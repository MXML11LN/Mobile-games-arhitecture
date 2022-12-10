using System;

namespace CodeBase.Infrastructure.StateMachine
{
    public class BootstrapState : IGameState
    {
        private const string BootSceneName = "Boot";
        private const string GameSceneName = "Game";
        private readonly GameStateMachine _gameStateMachine;
        private SceneLoader _sceneLoader;

        public BootstrapState(GameStateMachine gameStateMachine, SceneLoader sceneLoader)
        {
            _gameStateMachine = gameStateMachine;
            _sceneLoader = sceneLoader;
        }

        public void Enter() => 
            _sceneLoader.Load(BootSceneName,onLoaded: EnterLoadLevel);

        private void EnterLoadLevel() => 
            _gameStateMachine.Enter<LoadLevelState,string>(GameSceneName);

        public void Exit()
        {
           
        }
    }
}