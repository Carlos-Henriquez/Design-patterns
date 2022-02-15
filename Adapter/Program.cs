namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            MessageBox.Show("Configurando la entrada HDMI para el monitor.");
            VGAGraphicsCard vgaGraphicsCard = new VGAGraphicsCard();
            HDMIMonitor hdmiMonitor = new HDMIMonitor();
            VGAGraphicsCardAdapter vgaGraphicsCardAdapter = new VGAGraphicsCardAdapter(vgaGraphicsCard);
            hdmiMonitor.SetInput(vgaGraphicsCardAdapter.GetHDMIStream());
        }
    }

    class VGAStream
    {
        private byte[] _stream;

        public void SetData(byte[] data)
        {
            _stream = data;
        }

        public byte[] GetData()
        {
            return _stream;
        
        }
    }

    class HDMIStream
    {
        private byte[] _stream;

        public void SetData(byte[] data)
        {
            _stream = data;
        }

        public byte[] GetData()
        {
            return _stream;

        }
    }

    class VGAGraphicsCard
    {
        public VGAStream GetVGAStream()
        {
            VGAStream vgaStream = new VGAStream();
            vgaStream.SetData(new byte[] {});
            return vgaStream;
        }
    }

    class HDMIMonitor
    {
        private byte[] _inputStream;
        public void SetInput(HDMIStream inputStream)
        {
            _inputStream = inputStream.GetData();

        }
    }

    class VGAGraphicsCardAdapter
    {
        private VGAGraphicsCard _vgaGraphicsCard;

        public VGAGraphicsCardAdapter(VGAGraphicsCard vgaGraphicsCard)
        {
            _vgaGraphicsCard = vgaGraphicsCard;
        }

        public HDMIStream GetHDMIStream()
        {
            byte[] data = _vgaGraphicsCard.GetVGAStream().GetData();

            byte[] hdmiVideoData = ConvertFromVGAToHDMI(data);
            HDMIStream hdmiStream = new HDMIStream();
            hdmiStream.SetData(hdmiVideoData);
            return hdmiStream;
        }

        private byte[] ConvertFromVGAToHDMI(byte[] input)
        {
            MessageBox.Show("Se ha adaptado el video de VGA a HDMI con exito.");

            return new byte[] {};
        }
    }
}