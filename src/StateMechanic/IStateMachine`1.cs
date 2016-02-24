﻿namespace StateMechanic
{
    internal interface IStateMachine<TState> : IStateMachine, IEventDelegate where TState : IState<TState>
    {
        new TState InitialState { get; }
        new TState CurrentState { get; }
        void SetCurrentState(TState state);
    }
}