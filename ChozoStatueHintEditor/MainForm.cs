using System.Text;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ChozoStatueHintEditor
{
    public partial class MainForm : Form
    {
        private FileStream ROM;
        private const int DataOffset = 0x40DF78;
        private const int DataSize = 0xC;

        private Path[] Paths = new Path[10];
        private Path Current;

        public MainForm()
        {
            InitializeComponent();
        }

        private void FeedData()
        {
            for (int i = 0; i < 10; i++)
            {
                ROM.Position = DataOffset + (DataSize * i);
                Paths[i] = new Path((Area)ROM.ReadByte(), (byte)ROM.ReadByte(), (byte)ROM.ReadByte(), (byte)ROM.ReadByte(), (byte)ROM.ReadByte(), (Icon)ROM.ReadByte(), (Area)ROM.ReadByte(), (byte)ROM.ReadByte(), (byte)ROM.ReadByte(), (Icon)ROM.ReadByte());
            }
            CbStatues.SelectedIndex = 0;
            BtnSave.Enabled = true;
            /*StringBuilder pathsData = new();
            for (int i = 0; i < 10; i++)
                pathsData.Append("ID : ").Append(i).Append(" ; Data : ").Append(Paths[i]).Append('\n');
            MessageBox.Show(pathsData.ToString());*/
        }

        private void WriteData()
        {
            // Bad code
            if (!byte.TryParse(TbXStart.Text, out byte xStart))
            {
                MessageBox.Show("The X Start isn't a valid value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!byte.TryParse(TbXEnd.Text, out byte xEnd))
            {
                MessageBox.Show("The X End isn't a valid value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!byte.TryParse(TbYStart.Text, out byte yStart))
            {
                MessageBox.Show("The Y Start isn't a valid value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!byte.TryParse(TbYEnd.Text, out byte yEnd))
            {
                MessageBox.Show("The Y End isn't a valid value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!byte.TryParse(TbXTarget.Text, out byte xTarget))
            {
                MessageBox.Show("The X Target isn't a valid value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!byte.TryParse(TbYTarget.Text, out byte yTarget))
            {
                MessageBox.Show("The Y Target isn't a valid value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ROM.Position = DataOffset + (DataSize * CbStatues.SelectedIndex);
            ROM.WriteByte((byte)CbStartArea.SelectedIndex);
            ROM.WriteByte(xStart);
            ROM.WriteByte(xEnd);
            ROM.WriteByte(yStart);
            ROM.WriteByte(yEnd);
            Icon startIcon = Path.IndexToIcon(CbStartIcon.SelectedIndex);
            ROM.WriteByte((byte)startIcon);
            ROM.WriteByte((byte)CbTargetArea.SelectedIndex);
            ROM.WriteByte(xTarget);
            ROM.WriteByte(yTarget);
            Icon targetIcon = Path.IndexToIcon(CbTargetIcon.SelectedIndex);
            ROM.WriteByte((byte)targetIcon);
            Paths[CbStatues.SelectedIndex] = new Path((Area)CbStartArea.SelectedIndex, xStart, xEnd, yStart, yEnd, startIcon, (Area)CbTargetArea.SelectedIndex, xTarget, yTarget, targetIcon);
        }

        private void MainForm_DragEnter(object sender, DragEventArgs e) { if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy; }

        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length != 1)
            {
                MessageBox.Show("Only one file per drop is allowed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FileInfo fileInfo = new FileInfo(files[0]);
            if (fileInfo.Extension != ".gba")
            {
                MessageBox.Show("Invalid file, provide a .gba file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ROM = new FileStream(fileInfo.FullName, FileMode.Open, FileAccess.ReadWrite);
            GbMain.Visible = true;
            FeedData();
        }

        private void BtnOpenROM_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog dialog = new()
            {
                InitialDirectory = Directory.GetCurrentDirectory(),
                Filter = "GBA ROM | *.gba",
                DefaultExt = ".gba"
            };
            if (dialog.ShowDialog() != DialogResult.OK) return;
            ROM = new FileStream(dialog.FileName, FileMode.Open, FileAccess.ReadWrite);
            GbMain.Visible = true;
            FeedData();
        }

        private void BtnSave_Click(object sender, System.EventArgs e) => WriteData();

        private void CbStatues_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Current = Paths[CbStatues.SelectedIndex];

            CbStartArea.SelectedIndex = (int)Current.StartArea;
            CbStartIcon.SelectedIndex = Path.IconToIndex(Current.StartIcon);
            TbXStart.Text = Current.XStart.ToString();
            TbYStart.Text = Current.YStart.ToString();
            TbXEnd.Text = Current.XEnd.ToString();
            TbYEnd.Text = Current.YEnd.ToString();

            CbTargetArea.SelectedIndex = (int)Current.TargetArea;
            CbTargetIcon.SelectedIndex = Path.IconToIndex(Current.TargetIcon);
            TbXTarget.Text = Current.XTarget.ToString();
            TbYTarget.Text = Current.YTarget.ToString();
        }
    }
}