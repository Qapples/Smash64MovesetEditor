using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Smash64MovesetEditor
{
    public partial class Form1 : Form
    {

        string[] data;

        public Form1()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Text Files|*.txt|BIN files|*.bin";
            saveFileDialog1.Filter = "Text Files|*.txt|BIN files|*.bin";
            data = new string[]
            {
                ActionIdBox.Text, DamageThrowDataBox.Text, AngleThrowDataBox.Text, KBSThrowDataBox.Text,
                FKBThrowDataBox.Text, BKBThrowDataBox.Text, DamageEffectThrowBox.Text, DamageReleaseDataBox.Text,
                AngleReleaseDataBox.Text, KBSReleaseDataBox.Text, FKBReleaseDataBox.Text, BKBReleaseDataBox.Text,
                DamageEffectReleaseBox.Text
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }


        private async void CodeHexButton_Click(object sender, EventArgs e)
        {
            OutputBox.Text = $"{await ConvertCodeToHex(InputBox.Text):X}\n";
        }

        private async void HexCodeButton_click(object sender, EventArgs e)
        {
            //Convert input box to byte array
            List<byte> bytes = new List<byte>();
            for (int i = 0; i < InputBox.Text.Length - 1; i += 2)
            {
                bytes.Add(Convert.ToByte($"{InputBox.Text[i]}{InputBox.Text[i + 1]}", 16));
            }

            OutputBox.AppendText(await ConvertHexToCode(bytes.ToArray()));
        }

        /// <summary>
        /// Convert code to hexadecimal
        /// </summary>
        /// <param name="input">Input</param>
        /// <returns></returns>
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

                switch (opcode)
                {
                    case "Hitbox":
                        //HITBOX parameters in order: ID#1 DMG BKB FKB KBS Angle Bone X Y Z GT AT SD Clang Size Effect SoundType SoundLevel
                        var hex = (0xC000000 | (parameters[1] * 0x800000));
                        hex |= (parameters[7] << 13); //Bone
                        hex |= (parameters[2] << 5); //Damage
                        hex |= (parameters[14] << 4); //Clang
                        parameters[16] = parameters[16] == 5 ? 7 : parameters[16]; //Effect. Change 5 into 7
                        hex += parameters[16]; //add effect
                        output = $"{hex:X8} ";

                        hex = 0 | (parameters[15] << 17); //Size
                        hex |= (parameters[8] & 0xFFFF); //X Position
                        output += $"{hex:X8} ";

                        hex = (parameters[9] << 16) & 0xFFFF0000; //Y Position
                        hex |= (parameters[10] & 0xFFFF); //Z position
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
                        hex += parameters[3] << 7; //Base Knockbck
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


        /// <summary>
        /// Converts hexadecimal data into code
        /// </summary>
        /// <param name="input">Input in bytes</param>
        /// <returns></returns>
        public Task<string> ConvertHexToCode(byte[] input)
        {
            string output = "";

            for (int i = 0; i < input.Length; i++)
            {
                switch (input[i])
                {
                    case 0x0D:
                    case 0x0C: //Hitbox
                        output += "Hitbox ";

                        byte[] bytes = new byte[20];
                        int count = i + 19;
                        int index = 0;
                        for (; i < count; i++)
                        {
                            bytes[index] = input[i];
                            index++;
                        }

                        int ID = ((bytes[1] >> 4) + (bytes[0] << 4) - 0xC0) / 8;

                        int damage = ((bytes[3] >> 4) + ((bytes[2] << 4) & 0xFF)) / 2;
                        int BKB = ((bytes[19] >> 4) + (bytes[18] << 4)) / 8;
                        int FKB = (bytes[15] + ((bytes[14] << 8) & 0xFFF)) / 4;
                        int KBS = ((bytes[14] >> 4) & 0xF) + ((bytes[13] << 4) & 0xFF);
                        int angle = ((bytes[12] << 4) + (bytes[13] >> 4)) / 4;
                        int bone = (((bytes[1] << 4) & 0xFF) + (bytes[2] >> 4)) / 2;

                        int x = bytes[7] + (bytes[6] << 8);
                        int y = bytes[9] + (bytes[8] << 8);
                        int z = bytes[11] + (bytes[10] << 8);

                        int AT = bytes[15] & 1;
                        int GT = (bytes[15] >> 1) & 1;
                        int SD = bytes[16];
                        int clang = (bytes[3] >> 4) & 1;
                        int size = bytes[5] / 2;

                        int effect = bytes[3] & 0xF;
                        int soundType = (bytes[17] & 0xF) / 2;
                        int soundLevel = (bytes[17] >> 4) / 2;

                        output +=
                            $"{ID} {damage} {BKB} {FKB} {KBS} {angle} {bone} {x} {y} {z} {GT} {AT} {SD} {clang} {size} {effect} {soundType} {soundLevel}" +
                            Environment.NewLine;

                        break;
                    case 0x18: //End hitbox
                        output += "EndHitboxes" + Environment.NewLine;
                        break;
                    case 0x2C: //Revive hitbox
                        int main = input[i += 3];
                        output += $"ReviveHitbox {main}" + Environment.NewLine;
                        break;
                    case 0x04: //Wait
                        main = input[i += 3];
                        output += $"Wait {main}" + Environment.NewLine;
                        break;
                    case 0x08: //After
                        main = input[i += 3];
                        output += $"After {main}" + Environment.NewLine;
                        break;
                    case 0x38: //SFX [14]
                        main = input[i += 3];
                        output += $"SFX14 {main}" + Environment.NewLine;
                        break;
                    case 0x4C: //SFX [19]
                        main = input[i += 3];
                        output += $"SFX19 {main}" + Environment.NewLine;
                        break;
                    case 0x50: //Generic Voice FX
                        output += "GenericVoice" + Environment.NewLine;
                        break;
                    case 0x44: //Voice FX
                        main = input[i += 3];
                        output += $"Voice {main}" + Environment.NewLine;
                        break;
                    case 0x80: //BeginLoop
                        main = input[i += 3];
                        output += $"BeginLoop {main}" + Environment.NewLine;
                        break;
                    case 0x84: //End loop
                        output += "EndLoop" + Environment.NewLine;
                        break;
                    case 0x58: //Set flag
                        main = input[i += 3];
                        output += $"SetFlag {main}" + Environment.NewLine;
                        break;
                    case 0x74: //SetHurtboxState
                        main = input[i += 3];
                        output += $"SetHurtboxState {main}" + Environment.NewLine;
                        break;
                    case 0x6C: //ResetHurtboxState
                        main = input[i += 3];
                        output += $"ResetHurtboxState {main}" + Environment.NewLine;
                        break;
                    case 0xAC: //SetTextureForm
                        main = input[i += 3];
                        output += $"SetTextureForm {main}" + Environment.NewLine;
                        break;
                    case 0xBC: //SetSlopeContourState
                        main = input[i += 3];
                        output += $"SetSlopeCountourState {main}" + Environment.NewLine;
                        break;
                    case 0x5C: //ApplyThrow
                        main = input[i += 3];
                        output += $"ApplyThrow {main}" + Environment.NewLine;
                        break;
                    case 0x30: //ThrowData
                        main = input[i += 3];
                        output += $"ThrowData {main}" + Environment.NewLine;
                        break;
                    case 0x54: //CreateProp
                        main = input[i += 3];
                        output += $"CreateProp {main}" + Environment.NewLine;
                        break;
                    case 0x90: //Goto
                        main = input[i += 3];
                        output += $"Goto {main}" + Environment.NewLine;
                        break;
                    case 0x8C: //Return
                        output += "Return" + Environment.NewLine;
                        break;
                    case 0x88: //Subrotinue
                        main = input[i += 3];
                        output += $"Subroutine {main}" + Environment.NewLine;
                        break;
                }
            }

            return Task.FromResult(output);
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Open the openfile dialog
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;

            byte[] bytes = File.ReadAllBytes(openFileDialog1.FileName);


            if (openFileDialog1.FileName.Contains(".txt"))
            {
                InputBox.Text = Encoding.ASCII.GetString(bytes);
            }
            else
            {
                if (MovesetTab.Visible)
                {
                    string output = "";
                    for (int i = 0; i < bytes.Length; i++)
                    {
                        output += $"{bytes[i]:X2}";
                    }

                    InputBox.AppendText(output);
                }
                else
                {
                    int value = 0;
                    int multiplicity = 3;
                    int index = 0;
                    int[] values = new int[13];

                    for (int i = 0; i < bytes.Length; i++)
                    {
                        //Skip the rows of F
                        if (i == 0x1C)
                        {
                            i = 0x20;
                        }

                        if (multiplicity == -1)
                        {
                            values[index] = value;
                            value = 0;
                            index++;
                            multiplicity = 3;
                        }

                        value +=  bytes[i] << (multiplicity * 8);
                        multiplicity--;

                    }

                    string[] valueStrings = values.Select(s => s.ToString()).ToArray();

                    //There's probably a better way of doing this
                    (ActionIdBox.Text, DamageThrowDataBox.Text, AngleThrowDataBox.Text, KBSThrowDataBox.Text,
                        FKBThrowDataBox.Text,
                        BKBThrowDataBox.Text, DamageEffectThrowBox.Text, DamageReleaseDataBox.Text,
                        AngleReleaseDataBox.Text, KBSReleaseDataBox.Text,
                        FKBReleaseDataBox.Text, BKBReleaseDataBox.Text, DamageEffectReleaseBox.Text) = (valueStrings[0],
                        valueStrings[1], valueStrings[2], valueStrings[3], valueStrings[4], valueStrings[5],
                        valueStrings[6], valueStrings[7], valueStrings[8], valueStrings[9], valueStrings[10],
                        valueStrings[11], valueStrings[12]);
                }
            }
        }

        private async void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;

            //Save as txt file.
            if (saveFileDialog1.FileName.Contains(".txt"))
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog1.FileName))
                {
                    await writer.WriteAsync(OutputBox.Text);
                    await writer.FlushAsync();
                }
            }
            //Save as .bin file
            else if (saveFileDialog1.FileName.Contains(".bin"))
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog1.FileName))
                {
                    for (int i = 0; i < OutputBox.TextLength - 1; i += 2)
                    {
                        await writer.WriteAsync(
                            (char) Convert.ToByte($"{OutputBox.Text[i]}{OutputBox.Text[i + 1]}", 16));
                    }

                    await writer.FlushAsync();
                }
            }
        }

        private void GenerateThrowDataButton_Click(object sender, EventArgs e)
        {
            byte[] bytes = new byte[56];
            for (int i = 0x1C; i < 0x20; i++)
            {
                bytes[i] = 0xFF;
            }

            string[] data = new string[]
            {
                ActionIdBox.Text, DamageThrowDataBox.Text, AngleThrowDataBox.Text, KBSThrowDataBox.Text,
                FKBThrowDataBox.Text, BKBThrowDataBox.Text, DamageEffectThrowBox.Text, DamageReleaseDataBox.Text,
                AngleReleaseDataBox.Text, KBSReleaseDataBox.Text, FKBReleaseDataBox.Text, BKBReleaseDataBox.Text,
                DamageEffectReleaseBox.Text
            };

            int stringIndex = 0;
            for (int i = 3; i < bytes.Length; i += 4)
            {
                //Make sure the byte does not overflow
                bool isFKB = stringIndex == 4 || stringIndex == 10;

                //There is 4 bytes of FF's seperating throw data and grab release data.
                //Change I so that it does not change the variables
                if (i == 0x1F)
                {
                    i += 4;
                }

                int value;
                if (int.TryParse(data[stringIndex], out value))
                {
                    if (isFKB)
                        value *= 4;

                    bytes[i] = (byte) (value & 0xFF);
                    if (value > 0xFF)
                    {
                        bytes[i - 1] = (byte)(value >> 8);
                    }
                }
                else if (stringIndex == 6 || stringIndex == 12)
                {
                    Effects enumValue;
                    if (Enum.TryParse(data[stringIndex], true, out enumValue))
                    {
                        bytes[i] = (byte)enumValue;
                    }
                }


                stringIndex++;
            }

            OutputBoxThrow.Text = BitConverter.ToString(bytes).Replace("-", string.Empty);
        }
    }
}