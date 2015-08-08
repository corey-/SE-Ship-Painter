using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SE_Ship_Painter
{
    public partial class MainForm : Form
    {
        private Color shipColor;
        private string blueprintFilename;

        public MainForm() {
            InitializeComponent();

            shipColor = Color.FromArgb(167, 50, 0);
            btnPaint.Enabled = false;
        }

        private void btnPaint_Click(object sender, EventArgs e) {
            XDocument blueprint = XDocument.Load(blueprintFilename);

            //convert ship color to HSV (c# color lies, it's actually HSL, not HSB)
            float hue = shipColor.GetHue() / 360f;
            float sat = shipColor.GetSaturation();

            //can't have lightness == 0, so lazy cheat instead of case structure
            float l = Math.Max(shipColor.GetBrightness(), 0.000001f);
            float val;

            sat *= (l <= 0.5) ? l : 1 - l;
            val = l + sat;
            sat = (2 * sat) / (l + sat);

            //now map saturation and value to Space Engineer's bizarre ranges
            sat = (sat * 2f) - 1f;
            val = (val * 1.6f) - 0.6f;

            foreach (var node in blueprint.Descendants("CubeBlocks").Descendants("MyObjectBuilder_CubeBlock")) {
                string type = node.Element("SubtypeName").Value;
                if (!type.Contains("Armor")) { continue; }

                var oldElement = node.Element("ColorMaskHSV");

                var element = new XElement("ColorMaskHSV",
                    new XAttribute("x", hue),
                    new XAttribute("y", sat),
                    new XAttribute("z", val));

                if (type.Contains("Heavy")) {
                    if (checkedListArmorTypes.GetItemChecked(1)) {
                        if (oldElement != null) {
                            oldElement.Remove();
                        }
                        node.Add(element);
                    }
                }
                else {
                    if (checkedListArmorTypes.GetItemChecked(0)) {
                        if (oldElement != null) {
                            oldElement.Remove();
                        }
                        node.Add(element);
                    }
                }
            }

            blueprint.Save(blueprintFilename);

            MessageBox.Show("Ship has been repainted!");
        }

        private void btnLoadBlueprint_Click(object sender, EventArgs e) {
            var file = new OpenFileDialog();
            file.Filter = "SE Blueprint (.sbc)|*.sbc";
            file.InitialDirectory = "%appdata%/SpaceEngineers/Blueprints";

            if (file.ShowDialog() == DialogResult.OK) {
                blueprintFilename = file.FileName;
                labelBlueprint.Text = file.SafeFileName;
                btnPaint.Enabled = true;
            }
        }

        private void pictureBoxShipColor_Click(object sender, EventArgs e) {
            var color = new ColorDialog();
            color.FullOpen = true;

            if (color.ShowDialog() == DialogResult.OK) {
                shipColor = color.Color;
                pictureBoxShipColor.Invalidate();
            }
        }

        private void pictureBoxShipColor_Paint(object sender, PaintEventArgs e) {
            var color = (PictureBox)sender;
            using (SolidBrush b = new SolidBrush(shipColor)) {
                Rectangle r = new Rectangle(0, 0, color.Width, color.Height);
                e.Graphics.FillRectangle(b, r);
            }
        }
    }
}
