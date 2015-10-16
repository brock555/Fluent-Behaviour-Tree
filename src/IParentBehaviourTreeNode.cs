﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fluent_behaviour_tree
{
    /// <summary>
    /// Interface for behaviour tree nodes.
    /// </summary>
    public interface IParentBehaviourTreeNode : IBehaviourTreeNode
    {
        /// <summary>
        /// Add a child to the parent node.
        /// </summary>
        void AddChild(IBehaviourTreeNode child);
    }
}