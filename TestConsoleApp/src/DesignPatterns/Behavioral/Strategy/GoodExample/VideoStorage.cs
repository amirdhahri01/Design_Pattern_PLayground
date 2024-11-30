using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestConsoleApp.src.DesignPatterns.Behavioral.Strategy.GoodExample
{
    public class VideoStorage
    {
        private ICompressor _compressor;
        private IOverlay _overlay;

        public VideoStorage(ICompressor _compressor, IOverlay _overlay)
        {
            this._compressor = _compressor;
            this._overlay = _overlay;
        }

        public void SetCompressor(ICompressor _compressor)
        {
            this._compressor = _compressor;
        }

        public void SetOverlays(IOverlay _overlay)
        {
            this._overlay = _overlay;
        }

        public void Store(string FileName)
        {
            _compressor.Compress();  
            _overlay.Applay(); 
            //Storing logic
            System.Console.WriteLine("Storing video to " + FileName + "." + _compressor.GetExtension());
        }
    }
}
