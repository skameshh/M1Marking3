using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCSMarkingDLL.cr
{
    public class CMON
    {
        static String NL = Environment.NewLine;

        public static String getHEADER(string pstr, string charsize)
        {
           // string line5 = "";
            //string line6 = "";
            //string line7 = "";


            // string[] ss = pstr.Split("\n");
            string[] lines = pstr.Split(new string[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
            // (material_num + NL + old_material_number + NL + serial_num + NL + marking_locationX +NL+ partDia + NL);

            for(int x = 0; x < lines.Length; x++)
            {
                Console.WriteLine("" + lines[x]);
            }

            double marking_location = Double.Parse(lines[3]);
            double part_dia = Double.Parse(lines[4]);

            /* string line0 = lines[0];
             string line1 = lines[1];
             string line2 = lines[2];
             string line3 = lines[3];
             string line4 = lines[4];
             if (lines.Length > 5)
             {
                 line5 = lines[5];
             }
             if (lines.Length > 6)
             {
                 line6 = lines[6];
             }

             if (lines.Length > 7)
             {
                 line7 = lines[7];
             }*/


            StringBuilder sb = new StringBuilder();
            //No need for M1
            /* sb.AppendLine("M0 ( DATE: " + DateTime.Now.ToString("yyyy-MM-dd") + " AND TIME: " + DateTime.Now.ToString("HH:mm:ss") + ")"); //
             sb.AppendLine("M0 (THIS IS MARKING PROGRAM)");
             sb.AppendLine("M0 (PLEASE CONFIRM THE MARKING LOCATION BEFORE PROCEED)");
             sb.AppendLine("M0 (MAKE SURE THE MARKING TOOL IS AT LEAST 5 MM CLEARANCE FROM THE PART)");
             sb.AppendLine("M0 (USE SNAP GAUGE TO CHECK THE CLEARANCE)");
             sb.AppendLine("M0 (MARKING TEXTS)");
             sb.AppendLine("(********************)");
             sb.AppendLine("M0 (" + line0 + ")");
             sb.AppendLine("M0 (" + line1 + ")");
             sb.AppendLine("M0 (" + line2 + ")");
             sb.AppendLine("M0 (" + line3 + ")");
             sb.AppendLine("M0 (" + line4 + ")");
             if (lines.Length > 5)
             {
                 sb.AppendLine("M0 (" + line5 + ")");
             }
             if (lines.Length > 6)
             {
                 if (!line6.Contains("DLL"))
                     sb.AppendLine("M0 (" + line6 + ")");
             }
             if (lines.Length > 7)
             {
                 //length
                 if (!line7.Contains("DLL"))
                     sb.AppendLine("M0 (" + line7 + ")");
             }*/


            // sb.AppendLine("");
            sb.AppendLine("(********************)");
            sb.AppendLine("NOEX V171 = " + charsize + " (FONT SIZE)");
            sb.AppendLine("NOEX V24 = "+ marking_location + " (MARKING X START POSITION)");//Marking Location X 
            sb.AppendLine("NOEX V26 = "+ (part_dia/2) + " (MARKING Z LEVEL IN RADIUS)"); // User input in app (Part Diameter) radius = Part Diameter/2
            sb.AppendLine("NOEX V175 = " + charsize + " * 2 (FONT SIZE *2)");
            sb.AppendLine("NOEX V176 = V175/V26");
            sb.AppendLine("NOEX V177 = V176*57.325");
            sb.AppendLine("NOEX V178 = 35.0  (FEEDRATE)");
            sb.AppendLine("NOEX V172 = 1 (LINE COUNTER)");
            sb.AppendLine("NOEX V173 = 1 (CHARACTER COUNTER)");
            sb.AppendLine("NOEX V174 = V24 (MARKING X VALUE CALCULATOR)");
            sb.AppendLine("M64 ");
            sb.AppendLine("T05");
            sb.AppendLine("M06");
            sb.AppendLine("M64");
            sb.AppendLine("G90");
			sb.AppendLine("G15 H03");
			sb.AppendLine("G94");
            sb.AppendLine("G56 H28");
            sb.AppendLine("G0 X[V24] Z5.0");
            sb.AppendLine("M0 (PLEASE CHECK Z 5.0)");
            sb.AppendLine("M51");
			sb.AppendLine("M03 S10");
            sb.AppendLine("");
            return sb.ToString();
        }




    }
}
