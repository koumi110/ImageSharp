// Copyright (c) Six Labors and contributors.
// Licensed under the GNU Affero General Public License, Version 3.

using SixLabors.ImageSharp.PixelFormats;

using Xunit;

namespace SixLabors.ImageSharp.Tests.Processing.Processors.Filters
{
    using SixLabors.ImageSharp.Processing;

    [GroupOutput("Filters")]
    public class HueTest
    {
        public static readonly TheoryData<int> HueValues
        = new TheoryData<int>
        {
            180,
            -180
        };

        [Theory]
        [WithTestPatternImages(nameof(HueValues), 48, 48, PixelTypes.Rgba32)]
        public void ApplyHueFilter<TPixel>(TestImageProvider<TPixel> provider, int value)
            where TPixel : unmanaged, IPixel<TPixel>
        {
            provider.RunValidatingProcessorTest(x => x.Hue(value), value);
        }
    }
}
