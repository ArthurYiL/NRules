﻿namespace NRules.Rule
{
    /// <summary>
    /// Production rule definition.
    /// </summary>
    public interface IRuleDefinition
    {
        /// <summary>
        /// Rule name.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Rule priority.
        /// </summary>
        int Priority { get; }

        /// <summary>
        /// Rule left hand side (conditions).
        /// </summary>
        GroupElement LeftHandSide { get; }

        /// <summary>
        /// Rule right hand side (actions).
        /// </summary>
        ActionGroupElement RightHandSide { get; }
    }

    internal class RuleDefinition : IRuleDefinition
    {
        public static int DefaultPriority
        {
            get { return 0; }
        }

        public RuleDefinition(string name, int priority, GroupElement leftHandSide, ActionGroupElement rightHandSide)
        {
            Name = name;
            Priority = priority;
            LeftHandSide = leftHandSide;
            RightHandSide = rightHandSide;
        }

        public string Name { get; private set; }
        public int Priority { get; private set; }

        public GroupElement LeftHandSide { get; private set; }
        public ActionGroupElement RightHandSide { get; private set; }
    }
}