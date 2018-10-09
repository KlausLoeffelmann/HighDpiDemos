using System.Drawing;
using System.Windows.Forms;
using System;
using PerMonitorDemo.Properties;
using System.IO;
using Newtonsoft.Json;

namespace PerMonitorAware
{
    public partial class ScaleButtonImages : Form
    {
        public ScaleButtonImages()
        {
            InitializeComponent();
            errorButton.OriginalIcon = new Icon(new MemoryStream(JsonConvert.
                DeserializeObject<byte[]>(File.ReadAllText(".\\Resources\\wfc.json"))));
            propertiesButton.OriginalIcon = new Icon(new MemoryStream(JsonConvert.
                DeserializeObject<byte[]>(File.ReadAllText(".\\Resources\\Wrench.json"))));
        }
    }

    internal class ImageButton : Button
    {
        public ImageButton() : base()
        {
        }

        private Icon originalIcon;
        public Icon OriginalIcon 
        {
            private get 
            {
                return originalIcon;
            }

            set 
            {
                originalIcon = value;
                Image = GetScaledBitmapFromIcon(originalIcon);
            }
        }

        private Bitmap GetScaledBitmapFromIcon(Icon icon)
        {
            Icon scaledIcon = new Icon(icon, GetScaledSize());
            Bitmap bitmap = scaledIcon.ToBitmap();
            scaledIcon.Dispose();

            return bitmap;
        }

        private Size GetScaledSize()
        {
            int dimention = LogicalToDeviceUnits(32);
            return new Size(dimention, dimention);
        }

        protected override void OnDpiChangedAfterParent(EventArgs e)
        {
            base.OnDpiChangedAfterParent(e);
            Image = GetScaledBitmapFromIcon(originalIcon);
        }
    }
}
