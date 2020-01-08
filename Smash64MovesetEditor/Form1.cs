using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smash64MovesetEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Text Files|*.txt|BIN files|*.bin";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void HexCodeButton_click(object sender, EventArgs e)
        {

        }

        public Task<string> ConvertCodeToHex(string input)
        {
            string[] commands = input.Split('\n');
            string output = "";

            foreach (string command in commands)
            {
                //Split the command by spaces. The first element is the command. The next elements are the parameters. The first element of
                //Parameters is -1.
                string[] splitCmd = command.Split(' ');
                string opcode = splitCmd[0];

                uint[] parameters = splitCmd.Select(e => uint.TryParse(e, out _) ? uint.Parse(e) : 0).ToArray();
                uint hex;

                switch (opcode)
                {
                    case "Hitbox":
                        //HITBOX parameters in order: ID#1 DMG BKB FKB KBS Angle Bone X Y Z GT AT SD Clang Size Effect SoundType SoundLevel
                        hex = (0xC000000 | (parameters[1] * 0x800000)); //ID 1
                        hex = hex | (parameters[7] << 13); //Bone
                        hex = hex | (parameters[2] << 5); //Damage
                        hex = hex | (parameters[14] << 4); //Clang
                        parameters[16] = parameters[16] == 5 ? 7 : parameters[16]; //Effect. Change 5 into 7
                        hex += parameters[16]; //add effect
                        output = $"{hex:X8} ";

                        hex = 0 | (parameters[15] << 17); //Size
                        hex = hex | (parameters[8] & 0xFFFF); //X Position
                        output += $"{hex:X8} ";

                        hex = (parameters[9] << 16) & 0xFFFF0000; //Y Position
                        hex = hex | (parameters[10] & 0xFFFF); //Z position
                        output += $"{hex:X8} ";

                        hex = parameters[6] << 22; //Angle
                        hex += parameters[5] << 12; //Knockback Scaling
                        hex += parameters[4] * 4; //Fixed knocback
                        hex += parameters[11] * 2; //Grounded targets
                        hex += parameters[12]; //Aerial targets
                        output += $"{hex:X8} ";

                        hex = parameters[13] << 24; //Sheild Damage
                        hex += (parameters[17] * 2) << 20; //Sound level
                        hex += (parameters[18] * 2) << 16; //Sound type
                        hex += parameters[3] << 7;
                        output += $"{hex:X8} ";
                        break;
                    case "EndHitboxes":
                        //No parameters
                        output += $"{0x18000000:X8}";
                        break;
                    case "ReviveHitbox":
                        //Paramaters: Main
                        output += $"{0x2C000000 + parameters[1]:X8}";
                        break;
                    case "Wait":
                        //Paramters: Main
                        output += $"{0x04000000 + parameters[1]:X8}";
                        break;
                    case "After":
                        //Paramaters: Main
                        output += $"{0x08000000 + parameters[1]:X8}";
                        break;
                    case "SFX14":
                        //Paramaters: Main
                        output += $"{0x38000000 + parameters[1]:X8}";
                        break;
                    case "SFX19":
                        //Paramaters: Main
                        output += $"{0x4C000000 + parameters[1]:X8}";
                        break;
                    case "GenericVoice":
                        //No parameters
                        output += $"{0x50000000:X8}";
                        break;
                    case "Voice":
                        //Paramaters: Main
                        output += $"{0x44000000 + parameters[1]:X8}";
                        break;
                    case "BeginLoop":
                        //Paramaters: Main
                        output += $"{0x80000000 + parameters[1]:X8}";
                        break;
                    case "EndLoop":
                        //Paramaters: None
                        output += $"{0x84000000:X8}";
                        break;
                    case "SetFlag":
                        //Paramaters: Main
                        output += $"{0x58000000 + parameters[1]:X8}";
                        break;
                    case "SetHurtboxState":
                        //Paramaters: Main
                        output += $"{0x74000000 + parameters[1]:X8}";
                        break;
                    case "ResetHurtboxState":
                        //Paramaters: Main
                        output += $"{0x6C000000 + parameters[1]:X8}";
                        break;
                    case "SetTextureForm":
                        //Paramaters: Main
                        output += $"{0xAC000000 + parameters[1]:X8}";
                        break;
                    case "SetSlopeContourState":
                        //Paramaters: Main
                        output += $"{0xBC000000 + parameters[1]:X8}";
                        break;
                    case "ApplyThrow":
                        //Paramaters: Main
                        output += $"{0x5C000000 + parameters[1]:X8}";
                        break;
                    case "ThrowData":
                        //Paramaters: Main
                        output += $"{0x30000000 + parameters[1]:X8}";
                        break;
                    case "CreateProp":
                        //Paramaters: Main
                        output += $"{0x54000000 + parameters[1]:X8}";
                        break;
                    case "Goto":
                        //Paramaters: Main
                        output += $"{0x90000000 + parameters[1]:X8}";
                        break;
                    case "Return":
                        //Paramaters: None
                        output += $"{0x8C000000:X8}";
                        break;
                    case "Subroutine":
                        //Paramters: Main
                        output += $"{0x88000000 + parameters[1]:X8}";
                        break;

                }
            }

            return Task.FromResult(String.Format(output));
        }

        private async void CodeHexButton_Click(object sender, EventArgs e)
        {
            OutputBox.Text = String.Format("{0:X}\n", await ConvertCodeToHex(InputBox.Text));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Open the openfile dialog
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Open the file and read it
                Stream stream = openFileDialog1.OpenFile();
                byte[] bytes = new byte[stream.Length];

                for (int i = 0; i < stream.Length; i++)
                {
                    await stream.ReadAsync(bytes, 0, (int)stream.Length);
                }

                if (openFileDialog1.FileName.Contains(".txt"))
                {
                    InputBox.Text = Encoding.ASCII.GetString(bytes);
                }
                else
                {
                    string output = "";
                    for (int i = 0; i < bytes.Length; i++)
                    {
                        //Every four bytes, make a space. Make a new line every 16 bytes
                        if (i % 4 == 0)
                        {
                            output += " ";
                        }
                        if (i % 16 == 0)
                        {
                            output += Environment.NewLine;
                        }

                        output += $"{bytes[i]:X2}";
                    }

                    InputBox.AppendText(output);
                }
            }
        }

        /*
        public string ConvertHexToCode(byte[] input)
        {
            
        }*/
    }
}