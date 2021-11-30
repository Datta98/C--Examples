using System;
using System.Collections.Generic;
using System.Text;

namespace ImageSenderApplication
{
    public class ImageGallery
    {
        ISender _sender;
        public void Share(ISender Sender)
        {
            this._sender = Sender;
            Sender.Send();

        }
    }
}
