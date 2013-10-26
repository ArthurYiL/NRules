﻿using System;
using NRules.Dsl;

namespace NRules.Inline
{
    /// <summary>
    /// Rule activator that instantiates rules based on .NET types.
    /// Default activator uses .NET reflection activator.
    /// </summary>
    public interface IRuleActivator
    {
        /// <summary>
        /// Creates an instance of a rule from a .NET type.
        /// </summary>
        /// <param name="type">Rule type.</param>
        /// <returns>Rule instance.</returns>
        IRule Activate(Type type);
    }

    internal class RuleActivator : IRuleActivator
    {
        public IRule Activate(Type type)
        {
            return (IRule) Activator.CreateInstance(type);
        }
    }
}