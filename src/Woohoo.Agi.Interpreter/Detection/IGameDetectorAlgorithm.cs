// Copyright (c) Hugues Valois. All rights reserved.
// Licensed under the X11 license. See LICENSE in the project root for license information.

namespace Woohoo.Agi.Detection
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Woohoo.Agi.Interpreter;

    /// <summary>
    /// Game detection algorithm interface.
    /// </summary>
    public interface IGameDetectorAlgorithm
    {
        /// <summary>
        /// Detect a game in the specified folder.
        /// </summary>
        /// <param name="container">Game container.</param>
        /// <returns>Detection result.</returns>
        GameDetectorResult Detect(IGameContainer container);
    }
}
