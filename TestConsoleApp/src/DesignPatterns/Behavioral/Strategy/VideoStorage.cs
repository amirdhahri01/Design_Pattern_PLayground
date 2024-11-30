using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestConsoleApp.src.DesignPatterns.Behavioral.Strategy
{
    public class VideoStorage
    {
        private Compressors _compressor;
        private Overlays _overlay;

        public VideoStorage(Compressors _compressor, Overlays _overlay = Overlays.None)
        {
            this._compressor = _compressor;
            this._overlay = _overlay;
        }

        public void SetCompressor(Compressors _compressor)
        {
            this._compressor = _compressor;
        }

        public void SetOverlays(Overlays _overlay)
        {
            this._overlay = _overlay;
        }

        public void Sotre(string filename)
        {
            //Compressor logic
            if (_compressor == Compressors.MOV)
            {
                System.Console.WriteLine("Compressing using MOV");
            }
            else if (_compressor == Compressors.MP4)
            {
                System.Console.WriteLine("Compressing using MP4");
            }
            else if (_compressor == Compressors.WEBM)
            {
                System.Console.WriteLine("Compressing using WEBM");
            }
            //Overlay logic
            if (_overlay == Overlays.BlackAndWhite)
            {
                System.Console.WriteLine("Applaying black and white overlay");
            }
            else if (_overlay == Overlays.Blur)
            {
                System.Console.WriteLine("Applaying blur overlay");
            }
            else if (_overlay == Overlays.None)
            {
                System.Console.WriteLine("Not applaying an overlay");
            }
            //Storing logic
            System.Console.WriteLine("Storing video to " + filename + "." + _compressor);
        }
    }
}
