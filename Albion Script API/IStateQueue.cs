﻿using System.Collections.Generic;

namespace Ennui.Api
{
    public interface IStateQueue
    {
        /// <summary>
        /// TODO remove muh abstraction
        /// </summary>
        object CurrentState { get; }

        /// <summary>
        /// TODO remove muh abstraction
        /// </summary>
        Dictionary<int, object> States { get; }

        /// <summary>
        /// The state index. This can be used as a key.
        /// </summary>
        int StateIndex { get; }
    }
}
