﻿using Ennui.Api.Util;
using System.Collections.Generic;

namespace Ennui.Api
{
    public interface ISpellEffectArea
    {
        IGeometryDescriptor GeometryDescriptor { get; }

        /// <summary>
        /// Builds meshes based on this spell effect area's geometry.
        /// </summary>
        /// <returns>A list of built meshes.</returns>
        List<IMesh> BuildMeshes();
    }
}
