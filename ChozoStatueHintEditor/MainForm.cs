using System.Text;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ChozoStatueHintEditor
{
    public partial class MainForm : Form
    {
        private FileStream ROM;

        private const int HintDataOffset = 0x40DF78;
        private const int HintDataSize = 0xC;
        private Path[] Paths = new Path[10];
        private Path CurrentPath;

        private const int PairsDataOffset = 0x345934;
        private const int PairsDataSize = 0x8;
        private Pair[] Pairs = new Pair[9];
        private Pair CurrentPair;

        public MainForm()
        {
            InitializeComponent();
        }

        private void FeedData()
        {
            for (int i = 0; i < 10; i++)
            {
                ROM.Position = HintDataOffset + (HintDataSize * i);
                Paths[i] = new((Area)ROM.ReadByte(), (byte)ROM.ReadByte(), (byte)ROM.ReadByte(), (byte)ROM.ReadByte(), (byte)ROM.ReadByte(), (Icon)ROM.ReadByte(), (Area)ROM.ReadByte(), (byte)ROM.ReadByte(), (byte)ROM.ReadByte(), (Icon)ROM.ReadByte());
            }
            for (int i = 0; i < 9; i++)
            {
                ROM.Position = PairsDataOffset + (PairsDataSize * i);
                Pairs[i] = new((Area)ROM.ReadByte(), (byte)ROM.ReadByte(), (byte)ROM.ReadByte(), (byte)ROM.ReadByte(), (Area)ROM.ReadByte(), (byte)ROM.ReadByte(), (byte)ROM.ReadByte(), (byte)ROM.ReadByte());
            }
            CbStatues.SelectedIndex = 0;
            CbPairID.SelectedIndex = 0;
            GbHint.Visible = true;
            TSMIHint.Enabled = true;
            TSMIPair.Enabled = true;
            BtnSave.Enabled = true;
            /*StringBuilder pathsData = new();
            for (int i = 0; i < 10; i++)
                pathsData.Append("ID : ").Append(i).Append(" ; Data : ").Append(Paths[i]).Append('\n');
            MessageBox.Show(pathsData.ToString());*/
        }

        private void WriteData()
        {
            if (GbHint.Visible)
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

                ROM.Position = HintDataOffset + (HintDataSize * CbStatues.SelectedIndex);
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
                Paths[CbStatues.SelectedIndex] = new((Area)CbStartArea.SelectedIndex, xStart, xEnd, yStart, yEnd, startIcon, (Area)CbTargetArea.SelectedIndex, xTarget, yTarget, targetIcon);
            }
            else
            {
                if (CbAreaID1.SelectedIndex == -1)
                {
                    MessageBox.Show("The Area ID 1 isn't a valid value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (CbAreaID2.SelectedIndex == -1)
                {
                    MessageBox.Show("The Area ID 2 isn't a valid value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!byte.TryParse(TbRoomID1.Text, out byte roomID1))
                {
                    MessageBox.Show("The Room ID 1 isn't a valid value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!byte.TryParse(TbRoomID2.Text, out byte roomID2))
                {
                    MessageBox.Show("The Area ID 2 isn't a valid value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!byte.TryParse(TbMapX1.Text, out byte mapX1))
                {
                    MessageBox.Show("The Map X 1 isn't a valid value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!byte.TryParse(TbMapX2.Text, out byte mapX2))
                {
                    MessageBox.Show("The Map X 2 isn't a valid value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!byte.TryParse(TbMapY1.Text, out byte mapY1))
                {
                    MessageBox.Show("The Map Y 1 isn't a valid value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!byte.TryParse(TbMapY2.Text, out byte mapY2))
                {
                    MessageBox.Show("The Map Y 2 isn't a valid value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                ROM.Position = PairsDataOffset + (PairsDataSize * CbPairID.SelectedIndex);
                ROM.WriteByte((byte)CbAreaID1.SelectedIndex);
                ROM.WriteByte(roomID1);
                ROM.WriteByte(mapX1);
                ROM.WriteByte(mapY1);
                ROM.WriteByte((byte)CbAreaID2.SelectedIndex);
                ROM.WriteByte(roomID2);
                ROM.WriteByte(mapX2);
                ROM.WriteByte(mapY2);
                Pairs[CbStatues.SelectedIndex] = new((Area)CbAreaID1.SelectedIndex, roomID1, mapX1, mapY1, (Area)CbAreaID2.SelectedIndex, roomID2, mapX2, mapY2);
            }
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
            ROM = new(fileInfo.FullName, FileMode.Open, FileAccess.ReadWrite);
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
            FeedData();
        }

        private void BtnSave_Click(object sender, System.EventArgs e) => WriteData();

        private void CbStatues_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            CurrentPath = Paths[CbStatues.SelectedIndex];

            CbStartArea.SelectedIndex = (int)CurrentPath.StartArea;
            CbStartIcon.SelectedIndex = Path.IconToIndex(CurrentPath.StartIcon);
            TbXStart.Text = CurrentPath.XStart.ToString();
            TbYStart.Text = CurrentPath.YStart.ToString();
            TbXEnd.Text = CurrentPath.XEnd.ToString();
            TbYEnd.Text = CurrentPath.YEnd.ToString();

            CbTargetArea.SelectedIndex = (int)CurrentPath.TargetArea;
            CbTargetIcon.SelectedIndex = Path.IconToIndex(CurrentPath.TargetIcon);
            TbXTarget.Text = CurrentPath.XTarget.ToString();
            TbYTarget.Text = CurrentPath.YTarget.ToString();
        }

        private void TSMIHint_Click(object sender, System.EventArgs e)
        {
            GbHint.Visible = true;
            GbPair.Visible = false;
            CbStatues.SelectedIndex = 0;
        }
        private void TSMIPair_Click(object sender, System.EventArgs e)
        {
            GbHint.Visible = false;
            GbPair.Visible = true;
            CbPairID.SelectedIndex = 0;
        }

        private void CbPairID_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            CurrentPair = Pairs[CbPairID.SelectedIndex];
            int areaID1 = (int)CurrentPair.AreaID1;
            CbAreaID1.SelectedIndex = areaID1 < 7 ? areaID1 : -1;
            TbRoomID1.Text = CurrentPair.RoomID1.ToString();
            TbMapX1.Text = CurrentPair.MapX1.ToString();
            TbMapY1.Text = CurrentPair.MapY1.ToString();

            int areaID2 = (int)CurrentPair.AreaID2;
            CbAreaID2.SelectedIndex = areaID2 < 7 ? areaID2 : -1;
            TbRoomID2.Text = CurrentPair.RoomID2.ToString();
            TbMapX2.Text = CurrentPair.MapX2.ToString();
            TbMapY2.Text = CurrentPair.MapX2.ToString();
        }
    }
}