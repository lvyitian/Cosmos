using System;
using Cosmos.HAL;
using static Cosmos.HAL.VGADriver;

namespace Cosmos.System.Graphics
{
    public class VGAScreen
    {

        private static readonly VGADriver _Screen = new VGADriver();

        public static void SetGraphicsMode(ScreenSize aScreenSize, ColorDepth aColorDepth)
        {
            var vgaColorDepth = aColorDepth switch
            {
                ColorDepth.ColorDepth4 => VGADriver.ColorDepth.BitDepth4,
                ColorDepth.ColorDepth8 => VGADriver.ColorDepth.BitDepth8,
                ColorDepth.ColorDepth16 => VGADriver.ColorDepth.BitDepth16,
                ColorDepth.ColorDepth24 => throw new NotImplementedException(),
                ColorDepth.ColorDepth32 => throw new NotImplementedException(),
                _ => throw new NotImplementedException(),
            };
            _Screen.SetGraphicsMode(aScreenSize, vgaColorDepth);
        }

        public static void SetTextMode(TextSize aSize)
        {
            switch (aSize)
            {
                case TextSize.Size40x25:
                    _Screen.SetTextMode(TextSize.Size40x25);
                    break;
                case TextSize.Size40x50:
                    _Screen.SetTextMode(TextSize.Size40x50);
                    break;
                case TextSize.Size80x25:
                    _Screen.SetTextMode(TextSize.Size80x25);
                    break;
                case TextSize.Size80x50:
                    _Screen.SetTextMode(TextSize.Size80x50);
                    break;
                case TextSize.Size90x30:
                    _Screen.SetTextMode(TextSize.Size90x30);
                    break;
                case TextSize.Size90x60:
                    _Screen.SetTextMode(TextSize.Size90x60);
                    break;
                default:
                    throw new Exception("This situation is not implemented!");
            }
        }

        public static int PixelHeight = _Screen.PixelHeight;

        public static int PixelWidth = _Screen.PixelWidth;

        public static int Colors = _Screen.Colors;
    }
}
