using System;

[Serializable]
public class FSMTransition
{
    public FSMDecision Decision; // PlayerInRangeOfAttack -> True or False
    public string TrueState; // CurrentState -> AttackState
    public string FalseState; // CurrentState -> PatrolState
}