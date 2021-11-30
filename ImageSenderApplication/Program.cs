using System;

namespace ImageSenderApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Gmail _mailAccount = new Gmail();
            ImageGallery _imageGallery = new ImageGallery();
            _imageGallery.Share(_mailAccount);

            Bluetooth _blueToothDevice = new Bluetooth();
            _imageGallery.Share(_blueToothDevice);

            WhatsUp _messanger = new WhatsUp();
            _imageGallery.Share(_messanger);
        }
    }
   
   
   
   
    
}
