﻿// Copyright (c) Six Labors and contributors.
// Licensed under the GNU Affero General Public License, Version 3.

using SixLabors.ImageSharp.PixelFormats;

using Xunit;
using Xunit.Abstractions;

namespace SixLabors.ImageSharp.Tests.PixelFormats.PixelOperations
{
    public partial class PixelOperationsTests
    {
        public class L8OperationsTests : PixelOperationsTests<L8>
        {
            public L8OperationsTests(ITestOutputHelper output)
                : base(output)
            {
            }

            [Fact]
            public void IsSpecialImplementation() => Assert.IsType<L8.PixelOperations>(PixelOperations<L8>.Instance);
        }
    }
}
