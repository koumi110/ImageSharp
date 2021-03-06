// Copyright (c) Six Labors and contributors.
// Licensed under the GNU Affero General Public License, Version 3.

using System.Collections.Generic;

namespace SixLabors.ImageSharp.Tests.TestUtilities
{
    public class GraphicsOptionsComparer : IEqualityComparer<GraphicsOptions>
    {
        public bool Equals(GraphicsOptions x, GraphicsOptions y)
        {
            return x.AlphaCompositionMode == y.AlphaCompositionMode
                && x.Antialias == y.Antialias
                && x.AntialiasSubpixelDepth == y.AntialiasSubpixelDepth
                && x.BlendPercentage == y.BlendPercentage
                && x.ColorBlendingMode == y.ColorBlendingMode;
        }

        public int GetHashCode(GraphicsOptions obj) => obj.GetHashCode();
    }
}
