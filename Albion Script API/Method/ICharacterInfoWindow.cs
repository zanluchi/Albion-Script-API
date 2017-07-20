﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api.Method
{
    /// <summary>
	/// Provides a set of utilities for interfacing with the character info window in game.
	/// </summary>
    public interface ICharacterInfoWindow : IApiModule
    {
        /// <summary><c>true</c> if the character info window is currently open; otherwise, <c>false</c>.</summary>
        bool IsOpen { get; }
    }
}
