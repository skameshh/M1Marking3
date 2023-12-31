﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCSMarkingDLL.cr
{
    public class MainCR0P090
    {
        //============ start ===============
        //19th July 2022


        public static String getCR0()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(0)");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("G01 X[V174-0.0386] Y-0.045 F[V178]");
            sb.AppendLine("G01 Z[V26+0.13]");
            sb.AppendLine("G01 X[V174-0.0257] Y-0.0407");
            sb.AppendLine("G01 X[V174-0.0171] Y-0.0279");
            sb.AppendLine("G01 X[V174-0.0129] Y-0.0064");
            sb.AppendLine("G01 X[V174-0.0129] Y0.0064");
            sb.AppendLine("G01 X[V174-0.0171] Y0.0279");
            sb.AppendLine("G01 X[V174-0.0257] Y0.0407");
            sb.AppendLine("G01 X[V174-0.0386] Y0.045");
            sb.AppendLine("G01 X[V174-0.0471] Y0.045");
            sb.AppendLine("G01 X[V174-0.06] Y0.0407");
            sb.AppendLine("G01 X[V174-0.0686] Y0.0279");
            sb.AppendLine("G01 X[V174-0.0729] Y0.0064");
            sb.AppendLine("G01 X[V174-0.0729] Y-0.0064");
            sb.AppendLine("G01 X[V174-0.0686] Y-0.0279");
            sb.AppendLine("G01 X[V174-0.06] Y-0.0407");
            sb.AppendLine("G01 X[V174-0.0471] Y-0.045");
            sb.AppendLine("G01 X[V174-0.0386] Y-0.045");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("NOEX V174 = V174 - 0.1 (NEXT CHARACTER)");
            sb.AppendLine("");
            return sb.ToString();
        }

        public static String getCR1()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(1)");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("G01 X[V174-0.0257] Y-0.0279 F[V178]");
            sb.AppendLine("G01 Z[V26+0.13]");
            sb.AppendLine("G01 X[V174-0.0343] Y-0.0321");
            sb.AppendLine("G01 X[V174-0.0471] Y-0.045");
            sb.AppendLine("G01 X[V174-0.0471] Y0.045");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("NOEX V174 = V174 - 0.1 (NEXT CHARACTER)");
            sb.AppendLine("");
            return sb.ToString();
        }

        public static String getCR2()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(2)");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("G01 X[V174-0.0171] Y-0.0236 F[V178]");
            sb.AppendLine("G01 Z[V26+0.13]");
            sb.AppendLine("G01 X[V174-0.0171] Y-0.0279");
            sb.AppendLine("G01 X[V174-0.0214] Y-0.0364");
            sb.AppendLine("G01 X[V174-0.0257] Y-0.0407");
            sb.AppendLine("G01 X[V174-0.0343] Y-0.045");
            sb.AppendLine("G01 X[V174-0.0514] Y-0.045");
            sb.AppendLine("G01 X[V174-0.06] Y-0.0407");
            sb.AppendLine("G01 X[V174-0.0643] Y-0.0364");
            sb.AppendLine("G01 X[V174-0.0686] Y-0.0279");
            sb.AppendLine("G01 X[V174-0.0686] Y-0.0193");
            sb.AppendLine("G01 X[V174-0.0643] Y-0.0107");
            sb.AppendLine("G01 X[V174-0.0557] Y0.0021");
            sb.AppendLine("G01 X[V174-0.0129] Y0.045");
            sb.AppendLine("G01 X[V174-0.0729] Y0.045");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("NOEX V174 = V174 - 0.1 (NEXT CHARACTER)");
            sb.AppendLine("");
            return sb.ToString();
        }

        public static String getCR3()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(3)");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("G01 X[V174-0.0214] Y-0.045 F[V178]");
            sb.AppendLine("G01 Z[V26+0.13]");
            sb.AppendLine("G01 X[V174-0.0686] Y-0.045");
            sb.AppendLine("G01 X[V174-0.0429] Y-0.0107");
            sb.AppendLine("G01 X[V174-0.0557] Y-0.0107");
            sb.AppendLine("G01 X[V174-0.0643] Y-0.0064");
            sb.AppendLine("G01 X[V174-0.0686] Y-0.0021");
            sb.AppendLine("G01 X[V174-0.0729] Y0.0107");
            sb.AppendLine("G01 X[V174-0.0729] Y0.0193");
            sb.AppendLine("G01 X[V174-0.0686] Y0.0321");
            sb.AppendLine("G01 X[V174-0.06] Y0.0407");
            sb.AppendLine("G01 X[V174-0.0471] Y0.045");
            sb.AppendLine("G01 X[V174-0.0343] Y0.045");
            sb.AppendLine("G01 X[V174-0.0214] Y0.0407");
            sb.AppendLine("G01 X[V174-0.0171] Y0.0364");
            sb.AppendLine("G01 X[V174-0.0129] Y0.0279");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("NOEX V174 = V174 - 0.1 (NEXT CHARACTER)");
            sb.AppendLine("");
            return sb.ToString();
        }

        public static String getCR4()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(4)");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("G01 X[V174-0.0557] Y0.045  F[V178]");
            sb.AppendLine("G01 Z[V26+0.13]");
            sb.AppendLine("G01 X[V174-0.0557] Y-0.045");
            sb.AppendLine("G01 X[V174-0.0129] Y0.015");
            sb.AppendLine("G01 X[V174-0.0771] Y0.015");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("NOEX V174 = V174 - 0.1 (NEXT CHARACTER)");
            sb.AppendLine("");
            return sb.ToString();
        }

        public static String getCR5()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(5)");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("G01 X[V174-0.0643] Y-0.045");
            sb.AppendLine("G01 Z[V26+0.13] F[V178]");
            sb.AppendLine("G01 X[V174-0.0214] Y-0.045");
            sb.AppendLine("G01 X[V174-0.0171] Y-0.0064");
            sb.AppendLine("G01 X[V174-0.0214] Y-0.0107");
            sb.AppendLine("G01 X[V174-0.0343] Y-0.015");
            sb.AppendLine("G01 X[V174-0.0471] Y-0.015");
            sb.AppendLine("G01 X[V174-0.06] Y-0.0107");
            sb.AppendLine("G01 X[V174-0.0686] Y-0.0021");
            sb.AppendLine("G01 X[V174-0.0729] Y0.0107");
            sb.AppendLine("G01 X[V174-0.0729] Y0.0193");
            sb.AppendLine("G01 X[V174-0.0686] Y0.0321");
            sb.AppendLine("G01 X[V174-0.06] Y0.0407");
            sb.AppendLine("G01 X[V174-0.0471] Y0.045");
            sb.AppendLine("G01 X[V174-0.0343] Y0.045");
            sb.AppendLine("G01 X[V174-0.0214] Y0.0407");
            sb.AppendLine("G01 X[V174-0.0171] Y0.0364");
            sb.AppendLine("G01 X[V174-0.0129] Y0.0279");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("NOEX V174 = V174 - 0.1 (NEXT CHARACTER)");
            sb.AppendLine("");
            return sb.ToString();
        }

        public static String getCR6()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(6)");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("G01 X[V174-0.0686] Y-0.0321");
            sb.AppendLine("G01 Z[V26+0.13] F[V178]");
            sb.AppendLine("G01 X[V174-0.0643] Y-0.0407");
            sb.AppendLine("G01 X[V174-0.0514] Y-0.045");
            sb.AppendLine("G01 X[V174-0.0429] Y-0.045");
            sb.AppendLine("G01 X[V174-0.03] Y-0.0407");
            sb.AppendLine("G01 X[V174-0.0214] Y-0.0279");
            sb.AppendLine("G01 X[V174-0.0171] Y-0.0064");
            sb.AppendLine("G01 X[V174-0.0171] Y0.015");
            sb.AppendLine("G01 X[V174-0.0214] Y0.0321");
            sb.AppendLine("G01 X[V174-0.03] Y0.0407");
            sb.AppendLine("G01 X[V174-0.0429] Y0.045");
            sb.AppendLine("G01 X[V174-0.0471] Y0.045");
            sb.AppendLine("G01 X[V174-0.06] Y0.0407");
            sb.AppendLine("G01 X[V174-0.0686] Y0.0321");
            sb.AppendLine("G01 X[V174-0.0729] Y0.0193");
            sb.AppendLine("G01 X[V174-0.0729] Y0.015");
            sb.AppendLine("G01 X[V174-0.0686] Y0.0021");
            sb.AppendLine("G01 X[V174-0.06] Y-0.0064");
            sb.AppendLine("G01 X[V174-0.0471] Y-0.0107");
            sb.AppendLine("G01 X[V174-0.0429] Y-0.0107");
            sb.AppendLine("G01 X[V174-0.03] Y-0.0064");
            sb.AppendLine("G01 X[V174-0.0214] Y0.0021");
            sb.AppendLine("G01 X[V174-0.0171] Y0.015");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("NOEX V174 = V174 - 0.1 (NEXT CHARACTER)");
            sb.AppendLine("");
            return sb.ToString();
        }

        public static String getCR7()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(7)");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("G01 X[V174-0.03] Y0.045");
            sb.AppendLine("G01 Z[V26+0.13] F[V178]");
            sb.AppendLine("G01 X[V174-0.0729] Y-0.045");
            sb.AppendLine("G01 X[V174-0.0129] Y-0.045");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("NOEX V174 = V174 - 0.1 (NEXT CHARACTER)");
            sb.AppendLine("");
            return sb.ToString();
        }

        public static String getCR8()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(8)");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("G01 X[V174-0.0343] Y-0.045");
            sb.AppendLine("G01 Z[V26+0.13] F[V178]");
            sb.AppendLine("G01 X[V174-0.0214] Y-0.0407");
            sb.AppendLine("G01 X[V174-0.0171] Y-0.0321");
            sb.AppendLine("G01 X[V174-0.0171] Y-0.0236");
            sb.AppendLine("G01 X[V174-0.0214] Y-0.015");
            sb.AppendLine("G01 X[V174-0.03] Y-0.0107");
            sb.AppendLine("G01 X[V174-0.0471] Y-0.0064");
            sb.AppendLine("G01 X[V174-0.06] Y-0.0021");
            sb.AppendLine("G01 X[V174-0.0686] Y0.0064");
            sb.AppendLine("G01 X[V174-0.0729] Y0.015");
            sb.AppendLine("G01 X[V174-0.0729] Y0.0279");
            sb.AppendLine("G01 X[V174-0.0686] Y0.0364");
            sb.AppendLine("G01 X[V174-0.0643] Y0.0407");
            sb.AppendLine("G01 X[V174-0.0514] Y0.045");
            sb.AppendLine("G01 X[V174-0.0343] Y0.045");
            sb.AppendLine("G01 X[V174-0.0214] Y0.0407");
            sb.AppendLine("G01 X[V174-0.0171] Y0.0364");
            sb.AppendLine("G01 X[V174-0.0129] Y0.0279");
            sb.AppendLine("G01 X[V174-0.0129] Y0.015");
            sb.AppendLine("G01 X[V174-0.0171] Y0.0064");
            sb.AppendLine("G01 X[V174-0.0257] Y-0.0021");
            sb.AppendLine("G01 X[V174-0.0386] Y-0.0064");
            sb.AppendLine("G01 X[V174-0.0557] Y-0.0107");
            sb.AppendLine("G01 X[V174-0.0643] Y-0.015");
            sb.AppendLine("G01 X[V174-0.0686] Y-0.0236");
            sb.AppendLine("G01 X[V174-0.0686] Y-0.0321");
            sb.AppendLine("G01 X[V174-0.0643] Y-0.0407");
            sb.AppendLine("G01 X[V174-0.0514] Y-0.045");
            sb.AppendLine("G01 X[V174-0.0343] Y-0.045");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("NOEX V174 = V174 - 0.1 (NEXT CHARACTER)");
            sb.AppendLine("");
            return sb.ToString();
        }

        public static String getCR9()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(9)");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("G01 X[V174-0.0686] Y-0.015");
            sb.AppendLine("G01 Z[V26+0.13] F[V178]");
            sb.AppendLine("G01 X[V174-0.0643] Y-0.0021");
            sb.AppendLine("G01 X[V174-0.0557] Y0.0064");
            sb.AppendLine("G01 X[V174-0.0429] Y0.0107");
            sb.AppendLine("G01 X[V174-0.0386] Y0.0107");
            sb.AppendLine("G01 X[V174-0.0257] Y0.0064");
            sb.AppendLine("G01 X[V174-0.0171] Y-0.0021");
            sb.AppendLine("G01 X[V174-0.0129] Y-0.015");
            sb.AppendLine("G01 X[V174-0.0129] Y-0.0193");
            sb.AppendLine("G01 X[V174-0.0171] Y-0.0321");
            sb.AppendLine("G01 X[V174-0.0257] Y-0.0407");
            sb.AppendLine("G01 X[V174-0.0386] Y-0.045");
            sb.AppendLine("G01 X[V174-0.0429] Y-0.045");
            sb.AppendLine("G01 X[V174-0.0557] Y-0.0407");
            sb.AppendLine("G01 X[V174-0.0643] Y-0.0321");
            sb.AppendLine("G01 X[V174-0.0686] Y-0.015");
            sb.AppendLine("G01 X[V174-0.0686] Y0.0064");
            sb.AppendLine("G01 X[V174-0.0643] Y0.0279");
            sb.AppendLine("G01 X[V174-0.0557] Y0.0407");
            sb.AppendLine("G01 X[V174-0.0429] Y0.045");
            sb.AppendLine("G01 X[V174-0.0343] Y0.045");
            sb.AppendLine("G01 X[V174-0.0214] Y0.0407");
            sb.AppendLine("G01 X[V174-0.0171] Y0.0321");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("NOEX V174 = V174 - 0.1 (NEXT CHARACTER)");
            sb.AppendLine("");
            return sb.ToString();
        }

        public static String getCRA()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(A)");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("G01 X[V174-0.0043] Y0.045");
            sb.AppendLine("G01 Z[V26+0.13] F[V178]");
            sb.AppendLine("G01 X[V174-0.0386] Y-0.045");
            sb.AppendLine("G01 X[V174-0.0729] Y0.045");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("G01 X[V174-0.0171] Y0.015");
            sb.AppendLine("G01 Z[V26+0.13] F[V178]");
            sb.AppendLine("G01 X[V174-0.06] Y0.015");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("NOEX V174 = V174 - 0.1 (NEXT CHARACTER)");
            sb.AppendLine("");
            return sb.ToString();
        }

        public static String getCRAMP()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(&)");
            sb.AppendLine("G00G00 Z[V26+0.25]");
            sb.AppendLine("G01 X[V174-0.0986] Y-0.0064");
            sb.AppendLine("G01 Z[V26+0.13]F[V178]");
            sb.AppendLine("G01 X[V174-0.0986] Y-0.0107");
            sb.AppendLine("G01 X[V174-0.0943] Y-0.015");
            sb.AppendLine("G01 X[V174-0.09] Y-0.015");
            sb.AppendLine("G01 X[V174-0.0857] Y-0.0107");
            sb.AppendLine("G01 X[V174-0.0814] Y-0.0021");
            sb.AppendLine("G01 X[V174-0.0729] Y0.0193");
            sb.AppendLine("G01 X[V174-0.0643] Y0.0321");
            sb.AppendLine("G01 X[V174-0.0557] Y0.0407");
            sb.AppendLine("G01 X[V174-0.0471] Y0.045");
            sb.AppendLine("G01 X[V174-0.03] Y0.045");
            sb.AppendLine("G01 X[V174-0.0214] Y0.0407");
            sb.AppendLine("G01 X[V174-0.0171] Y0.0364");
            sb.AppendLine("G01 X[V174-0.0129] Y0.0279");
            sb.AppendLine("G01 X[V174-0.0129] Y0.0193");
            sb.AppendLine("G01 X[V174-0.0171] Y0.0107");
            sb.AppendLine("G01 X[V174-0.0214] Y0.0064");
            sb.AppendLine("G01 X[V174-0.0514] Y-0.0107");
            sb.AppendLine("G01 X[V174-0.0557] Y-0.015");
            sb.AppendLine("G01 X[V174-0.06] Y-0.0236");
            sb.AppendLine("G01 X[V174-0.06] Y-0.0321");
            sb.AppendLine("G01 X[V174-0.0557] Y-0.0407");
            sb.AppendLine("G01 X[V174-0.0471] Y-0.045");
            sb.AppendLine("G01 X[V174-0.0386] Y-0.0407");
            sb.AppendLine("G01 X[V174-0.0343] Y-0.0321");
            sb.AppendLine("G01 X[V174-0.0343] Y-0.0236");
            sb.AppendLine("G01 X[V174-0.0386] Y-0.0107");
            sb.AppendLine("G01 X[V174-0.0471] Y0.0021");
            sb.AppendLine("G01 X[V174-0.0686] Y0.0321");
            sb.AppendLine("G01 X[V174-0.0771] Y0.0407");
            sb.AppendLine("G01 X[V174-0.0857] Y0.045");
            sb.AppendLine("G01 X[V174-0.0943] Y0.045");
            sb.AppendLine("G01 X[V174-0.0986] Y0.0407");
            sb.AppendLine("G01 X[V174-0.0986] Y0.0364");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("NOEX V174 = V174 - 0.118 (NEXT CHARACTER)");
            sb.AppendLine("");
            return sb.ToString();
        }

        public static String getCRB()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(B)");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("G01 X[V174-0.0171] Y0.045");
            sb.AppendLine("G01 Z[V26+0.13] F[V178]");
            sb.AppendLine("G01 X[V174-0.0171] Y-0.045");
            sb.AppendLine("G01 X[V174-0.0557] Y-0.045");
            sb.AppendLine("G01 X[V174-0.0686] Y-0.0407");
            sb.AppendLine("G01 X[V174-0.0729] Y-0.0364");
            sb.AppendLine("G01 X[V174-0.0771] Y-0.0279");
            sb.AppendLine("G01 X[V174-0.0771] Y-0.0193");
            sb.AppendLine("G01 X[V174-0.0729] Y-0.0107");
            sb.AppendLine("G01 X[V174-0.0686] Y-0.0064");
            sb.AppendLine("G01 X[V174-0.0557] Y-0.0021");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("G01 X[V174-0.0171] Y-0.0021");
            sb.AppendLine("G01 Z[V26+0.13] F[V178]");
            sb.AppendLine("G01 X[V174-0.0557] Y-0.0021");
            sb.AppendLine("G01 X[V174-0.0686] Y0.0021");
            sb.AppendLine("G01 X[V174-0.0729] Y0.0064");
            sb.AppendLine("G01 X[V174-0.0771] Y0.015");
            sb.AppendLine("G01 X[V174-0.0771] Y0.0279");
            sb.AppendLine("G01 X[V174-0.0729] Y0.0364");
            sb.AppendLine("G01 X[V174-0.0686] Y0.0407");
            sb.AppendLine("G01 X[V174-0.0557] Y0.045");
            sb.AppendLine("G01 X[V174-0.0171] Y0.045");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("NOEX V174 = V174 - 0.1 (NEXT CHARACTER)");
            sb.AppendLine("");
            return sb.ToString();
        }

        public static String getCRCR()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(NEXT LINE)");
            sb.AppendLine("V179 = V172 * V177");
            sb.AppendLine("A[V179]");
            sb.AppendLine("NOEX V172 = V172 + 1");
            sb.AppendLine("NOEX V174 = V24 (MARKING X VALUE CALCULATOR)");
            sb.AppendLine("");
            return sb.ToString();
        }

        public static String getCRC()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(C)");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("G01 X[V174-0.0771] Y-0.0236");
            sb.AppendLine("G01 Z[V26+0.13] F[V178]");
            sb.AppendLine("G01 X[V174-0.0729] Y-0.0321");
            sb.AppendLine("G01 X[V174-0.0643] Y-0.0407");
            sb.AppendLine("G01 X[V174-0.0557] Y-0.045");
            sb.AppendLine("G01 X[V174-0.0386] Y-0.045");
            sb.AppendLine("G01 X[V174-0.03] Y-0.0407");
            sb.AppendLine("G01 X[V174-0.0214] Y-0.0321");
            sb.AppendLine("G01 X[V174-0.0171] Y-0.0236");
            sb.AppendLine("G01 X[V174-0.0129] Y-0.0107");
            sb.AppendLine("G01 X[V174-0.0129] Y0.0107");
            sb.AppendLine("G01 X[V174-0.0171] Y0.0236");
            sb.AppendLine("G01 X[V174-0.0214] Y0.0321");
            sb.AppendLine("G01 X[V174-0.03] Y0.0407");
            sb.AppendLine("G01 X[V174-0.0386] Y0.045");
            sb.AppendLine("G01 X[V174-0.0557] Y0.045");
            sb.AppendLine("G01 X[V174-0.0643] Y0.0407");
            sb.AppendLine("G01 X[V174-0.0729] Y0.0321");
            sb.AppendLine("G01 X[V174-0.0771] Y0.0236");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("NOEX V174 = V174 - 0.1 (NEXT CHARACTER)");
            sb.AppendLine("");
            return sb.ToString();
        }

        public static String getCRCOLON()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(:)");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("G01 X[V174-0.0214] Y-0.015");
            sb.AppendLine("G01 Z[V26+0.13] F[V178]");
            sb.AppendLine("G01 X[V174-0.0171] Y-0.0107");
            sb.AppendLine("G01 X[V174-0.0214] Y-0.0064");
            sb.AppendLine("G01 X[V174-0.0257] Y-0.0107");
            sb.AppendLine("G01 X[V174-0.0214] Y-0.015");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("G01 X[V174-0.0214] Y0.0364");
            sb.AppendLine("G01 Z[V26+0.13] F[V178]");
            sb.AppendLine("G01 X[V174-0.0171] Y0.0407");
            sb.AppendLine("G01 X[V174-0.0214] Y0.045");
            sb.AppendLine("G01 X[V174-0.0257] Y0.0407");
            sb.AppendLine("G01 X[V174-0.0214] Y0.0364");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("NOEX V174 = V174 - 0.045 (NEXT CHARACTER)");
            sb.AppendLine("");
            return sb.ToString();
        }

        public static String getCRCOMMA()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(,)");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("G01 X[V174-0.0171] Y0.0407");
            sb.AppendLine("G01 Z[V26+0.13] F[V178]");
            sb.AppendLine("G01 X[V174-0.0129] Y0.045");
            sb.AppendLine("G01 X[V174-0.0086] Y0.0407");
            sb.AppendLine("G01 X[V174-0.0129] Y0.0364");
            sb.AppendLine("G01 X[V174-0.0171] Y0.0407");
            sb.AppendLine("G01 X[V174-0.0171] Y0.0493");
            sb.AppendLine("G01 X[V174-0.0129] Y0.0579");
            sb.AppendLine("G01 X[V174-0.0086] Y0.0621");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("NOEX V174 = V174 - 0.037 (NEXT CHARACTER)");
            sb.AppendLine("");
            return sb.ToString();
        }

        public static String getCRD()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(D)");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("G01 X[V174-0.0171] Y0.045");
            sb.AppendLine("G01 Z[V26+0.13] F[V178]");
            sb.AppendLine("G01 X[V174-0.0171] Y-0.045");
            sb.AppendLine("G01 X[V174-0.0471] Y-0.045");
            sb.AppendLine("G01 X[V174-0.06] Y-0.0407");
            sb.AppendLine("G01 X[V174-0.0686] Y-0.0321");
            sb.AppendLine("G01 X[V174-0.0729] Y-0.0236");
            sb.AppendLine("G01 X[V174-0.0771] Y-0.0107");
            sb.AppendLine("G01 X[V174-0.0771] Y0.0107");
            sb.AppendLine("G01 X[V174-0.0729] Y0.0236");
            sb.AppendLine("G01 X[V174-0.0686] Y0.0321");
            sb.AppendLine("G01 X[V174-0.06] Y0.0407");
            sb.AppendLine("G01 X[V174-0.0471] Y0.045");
            sb.AppendLine("G01 X[V174-0.0171] Y0.045");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("NOEX V174 = V174 - 0.1 (NEXT CHARACTER)");
            sb.AppendLine("");
            return sb.ToString();
        }

        public static String getCRDOT()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(.)");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("G01 X[V174-0.0214] Y0.0364");
            sb.AppendLine("G01 Z[V26+0.13] F[V178]");
            sb.AppendLine("G01 X[V174-0.0171] Y0.0407");
            sb.AppendLine("G01 X[V174-0.0214] Y0.045");
            sb.AppendLine("G01 X[V174-0.0257] Y0.0407");
            sb.AppendLine("G01 X[V174-0.0214] Y0.0364");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("NOEX V174 = V174 - 0.045 (NEXT CHARACTER)");
            sb.AppendLine("");
            return sb.ToString();
        }

        public static String getCRE()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(E)");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("G01 X[V174-0.0171] Y0.045");
            sb.AppendLine("G01 Z[V26+0.13] F[V178]");
            sb.AppendLine("G01 X[V174-0.0171] Y-0.045");
            sb.AppendLine("G01 X[V174-0.0729] Y-0.045");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("G01 X[V174-0.0171] Y-0.0021");
            sb.AppendLine("G01 Z[V26+0.13] F[V178]");
            sb.AppendLine("G01 X[V174-0.0514] Y-0.0021");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("G01 X[V174-0.0171] Y0.045");
            sb.AppendLine("G01 Z[V26+0.13] F[V178]");
            sb.AppendLine("G01 X[V174-0.0729] Y0.045");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("NOEX V174 = V174 - 0.1 (NEXT CHARACTER)");
            sb.AppendLine("");
            return sb.ToString();
        }

        public static String getCRF()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(F)");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("G01 X[V174-0.0171] Y0.045");
            sb.AppendLine("G01 Z[V26+0.13] F[V178]");
            sb.AppendLine("G01 X[V174-0.0171] Y-0.045");
            sb.AppendLine("G01 X[V174-0.0729] Y-0.045");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("G01 X[V174-0.0171] Y-0.0021");
            sb.AppendLine("G01 Z[V26+0.13] F[V178]");
            sb.AppendLine("G01 X[V174-0.0514] Y-0.0021");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("NOEX V174 = V174 - 0.1 (NEXT CHARACTER)");
            sb.AppendLine("");
            return sb.ToString();
        }

        public static String getCRFOOTER()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(END)");
            sb.AppendLine("M09");
            sb.AppendLine("M05");
			sb.AppendLine("G00 Z25.0");
			sb.AppendLine("A0.0");
			sb.AppendLine("M30");
			sb.AppendLine("");
            return sb.ToString();
        }

        public static String getCRG()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(G)");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("G01 X[V174-0.0771] Y-0.0236");
            sb.AppendLine("G01 Z[V26+0.13] F[V178]");
            sb.AppendLine("G01 X[V174-0.0729] Y-0.0321");
            sb.AppendLine("G01 X[V174-0.0643] Y-0.0407");
            sb.AppendLine("G01 X[V174-0.0557] Y-0.045");
            sb.AppendLine("G01 X[V174-0.0386] Y-0.045");
            sb.AppendLine("G01 X[V174-0.03] Y-0.0407");
            sb.AppendLine("G01 X[V174-0.0214] Y-0.0321");
            sb.AppendLine("G01 X[V174-0.0171] Y-0.0236");
            sb.AppendLine("G01 X[V174-0.0129] Y-0.0107");
            sb.AppendLine("G01 X[V174-0.0129] Y0.0107");
            sb.AppendLine("G01 X[V174-0.0171] Y0.0236");
            sb.AppendLine("G01 X[V174-0.0214] Y0.0321");
            sb.AppendLine("G01 X[V174-0.03] Y0.0407");
            sb.AppendLine("G01 X[V174-0.0386] Y0.045");
            sb.AppendLine("G01 X[V174-0.0557] Y0.045");
            sb.AppendLine("G01 X[V174-0.0643] Y0.0407");
            sb.AppendLine("G01 X[V174-0.0729] Y0.0321");
            sb.AppendLine("G01 X[V174-0.0771] Y0.0236");
            sb.AppendLine("G01 X[V174-0.0771] Y0.0107");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("G01 X[V174-0.0557] Y0.0107");
            sb.AppendLine("G01 Z[V26+0.13] F[V178]");
            sb.AppendLine("G01 X[V174-0.0771] Y0.0107");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("NOEX V174 = V174 - 0.11 (NEXT CHARACTER)");
            sb.AppendLine("");
            return sb.ToString();
        }

        public static String getCRH()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(H)");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("G01 X[V174-0.0171] Y-0.045");
            sb.AppendLine("G01 Z[V26+0.13] F[V178]");
            sb.AppendLine("G01 X[V174-0.0171] Y0.045");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("G01 X[V174-0.0771] Y-0.045");
            sb.AppendLine("G01 Z[V26+0.13] F[V178]");
            sb.AppendLine("G01 X[V174-0.0771] Y0.045");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("G01 X[V174-0.0171] Y-0.0021");
            sb.AppendLine("G01 Z[V26+0.13] F[V178]");
            sb.AppendLine("G01 X[V174-0.0771] Y-0.0021");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("NOEX V174 = V174 - 0.1 (NEXT CHARACTER)");
            sb.AppendLine("");
            return sb.ToString();
        }

        public static String getCRHASH()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(#)");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("G01 X[V174-0.0471] Y-0.0621");
            sb.AppendLine("G01 Z[V26+0.13] F[V178]");
            sb.AppendLine("G01 X[V174-0.0171] Y0.075");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("G01 X[V174-0.0729] Y-0.0621");
            sb.AppendLine("G01 Z[V26+0.13] F[V178]");
            sb.AppendLine("G01 X[V174-0.0429] Y0.075");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("G01 X[V174-0.0171] Y-0.0064");
            sb.AppendLine("G01 Z[V26+0.13] F[V178]");
            sb.AppendLine("G01 X[V174-0.0771] Y-0.0064");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("G01 X[V174-0.0129] Y0.0193");
            sb.AppendLine("G01 Z[V26+0.13] F[V178]");
            sb.AppendLine("G01 X[V174-0.0729] Y0.0193");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("NOEX V174 = V174 - 0.092 (NEXT CHARACTER)");
            sb.AppendLine("");
            return sb.ToString();
        }

        public static String getCRHEADER(string pstr)
        {
            return CMON.getHEADER(pstr, Consts.P090);
        }

        public static String getCRHYPHEN()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(-)");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("G01 X[V174-0.0171] Y0.0064");
            sb.AppendLine("G01 Z[V26+0.13] F[V178]");
            sb.AppendLine("G01 X[V174-0.0943] Y0.0064");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("NOEX V174 = V174 - 0.11 (NEXT CHARACTER)");
            sb.AppendLine("");
            return sb.ToString();
        }

        public static String getCRI()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(I)");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("G01 X[V174-0.0171] Y-0.045");
            sb.AppendLine("G01 Z[V26+0.13] F[V178]");
            sb.AppendLine("G01 X[V174-0.0171] Y0.045");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("NOEX V174 = V174 - 0.04 (NEXT CHARACTER)");
            sb.AppendLine("");
            return sb.ToString();
        }

        public static String getCRJ()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(J)");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("G01 X[V174-0.0514] Y-0.045");
            sb.AppendLine("G01 Z[V26+0.13] F[V178]");
            sb.AppendLine("G01 X[V174-0.0514] Y0.0236");
            sb.AppendLine("G01 X[V174-0.0471] Y0.0364");
            sb.AppendLine("G01 X[V174-0.0429] Y0.0407");
            sb.AppendLine("G01 X[V174-0.0343] Y0.045");
            sb.AppendLine("G01 X[V174-0.0257] Y0.045");
            sb.AppendLine("G01 X[V174-0.0171] Y0.0407");
            sb.AppendLine("G01 X[V174-0.0129] Y0.0364");
            sb.AppendLine("G01 X[V174-0.0086] Y0.0236");
            sb.AppendLine("G01 X[V174-0.0086] Y0.015");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("NOEX V174 = V174 - 0.08 (NEXT CHARACTER)");
            sb.AppendLine("");
            return sb.ToString();
        }

        public static String getCRK()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(K)");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("G01 X[V174-0.0171] Y-0.045");
            sb.AppendLine("G01 Z[V26+0.13] F[V178]");
            sb.AppendLine("G01 X[V174-0.0171] Y0.045");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("G01 X[V174-0.0771] Y-0.045");
            sb.AppendLine("G01 Z[V26+0.13] F[V178]");
            sb.AppendLine("G01 X[V174-0.0171] Y0.015");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("G01 X[V174-0.0386] Y-0.0064");
            sb.AppendLine("G01 Z[V26+0.13] F[V178]");
            sb.AppendLine("G01 X[V174-0.0771] Y0.045");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("NOEX V174 = V174 - 0.1 (NEXT CHARACTER)");
            sb.AppendLine("");
            return sb.ToString();
        }

        public static String getCRL()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(L)");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("G01 X[V174-0.0171] Y-0.045");
            sb.AppendLine("G01 Z[V26+0.13] F[V178]");
            sb.AppendLine("G01 X[V174-0.0171] Y0.045");
            sb.AppendLine("G01 X[V174-0.0686] Y0.045");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("NOEX V174 = V174 - 0.9 (NEXT CHARACTER)");
            sb.AppendLine("");
            return sb.ToString();
        }

        public static String getCRM()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(M)");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("G01 X[V174-0.0171] Y0.045  F[V178]");
            sb.AppendLine("G01 Z[V26+0.13]");
            sb.AppendLine("G01 X[V174-0.0171] Y-0.045");
            sb.AppendLine("G01 X[V174-0.0514] Y0.045");
            sb.AppendLine("G01 X[V174-0.0857] Y-0.045");
            sb.AppendLine("G01 X[V174-0.0857] Y0.045");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("NOEX V174 = V174 - 0.11 (NEXT CHARACTER)");
            sb.AppendLine("");
            return sb.ToString();
        }

        public static String getCRN()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(N)");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("G01 X[V174-0.0171] Y0.045");
            sb.AppendLine("G01 Z[V26+0.13] F[V178]");
            sb.AppendLine("G01 X[V174-0.0171] Y-0.045");
            sb.AppendLine("G01 X[V174-0.0771] Y0.045");
            sb.AppendLine("G01 X[V174-0.0771] Y-0.045");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("NOEX V174 = V174 - 0.1 (NEXT CHARACTER)");
            sb.AppendLine("");
            return sb.ToString();
        }

        public static String getCRO()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(O)");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("G01 X[V174-0.0386] Y-0.045");
            sb.AppendLine("G01 Z[V26+0.13] F[V178]");
            sb.AppendLine("G01 X[V174-0.03] Y-0.0407");
            sb.AppendLine("G01 X[V174-0.0214] Y-0.0321");
            sb.AppendLine("G01 X[V174-0.0171] Y-0.0236");
            sb.AppendLine("G01 X[V174-0.0129] Y-0.0107");
            sb.AppendLine("G01 X[V174-0.0129] Y0.0107");
            sb.AppendLine("G01 X[V174-0.0171] Y0.0236");
            sb.AppendLine("G01 X[V174-0.0214] Y0.0321");
            sb.AppendLine("G01 X[V174-0.03] Y0.0407");
            sb.AppendLine("G01 X[V174-0.0386] Y0.045");
            sb.AppendLine("G01 X[V174-0.0557] Y0.045");
            sb.AppendLine("G01 X[V174-0.0643] Y0.0407");
            sb.AppendLine("G01 X[V174-0.0729] Y0.0321");
            sb.AppendLine("G01 X[V174-0.0771] Y0.0236");
            sb.AppendLine("G01 X[V174-0.0814] Y0.0107");
            sb.AppendLine("G01 X[V174-0.0814] Y-0.0107");
            sb.AppendLine("G01 X[V174-0.0771] Y-0.0236");
            sb.AppendLine("G01 X[V174-0.0729] Y-0.0321");
            sb.AppendLine("G01 X[V174-0.0643] Y-0.0407");
            sb.AppendLine("G01 X[V174-0.0557] Y-0.045");
            sb.AppendLine("G01 X[V174-0.0386] Y-0.045");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("NOEX V174 = V174 - 0.1 (NEXT CHARACTER)");
            sb.AppendLine("");
            return sb.ToString();
        }

        public static String getCRP()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(P)");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("G01 X[V174-0.0171] Y0.045 F[V178]");
            sb.AppendLine("G01 Z[V26+0.13]");
            sb.AppendLine("G01 X[V174-0.0171] Y-0.045");
            sb.AppendLine("G01 X[V174-0.0557] Y-0.045");
            sb.AppendLine("G01 X[V174-0.0686] Y-0.0407");
            sb.AppendLine("G01 X[V174-0.0729] Y-0.0364");
            sb.AppendLine("G01 X[V174-0.0771] Y-0.0279");
            sb.AppendLine("G01 X[V174-0.0771] Y-0.015");
            sb.AppendLine("G01 X[V174-0.0729] Y-0.0064");
            sb.AppendLine("G01 X[V174-0.0686] Y-0.0021");
            sb.AppendLine("G01 X[V174-0.0557] Y0.0021");
            sb.AppendLine("G01 X[V174-0.0171] Y0.0021");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("NOEX V174 = V174 - 0.1 (NEXT CHARACTER)");
            sb.AppendLine("");
            return sb.ToString();
        }

        public static String getCRQ()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(Q)");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("G01 X[V174-0.0386] Y-0.045");
            sb.AppendLine("G01 Z[V26+0.13] F[V178]");
            sb.AppendLine("G01 X[V174-0.03] Y-0.0407");
            sb.AppendLine("G01 X[V174-0.0214] Y-0.0321");
            sb.AppendLine("G01 X[V174-0.0171] Y-0.0236");
            sb.AppendLine("G01 X[V174-0.0129] Y-0.0107");
            sb.AppendLine("G01 X[V174-0.0129] Y0.0107");
            sb.AppendLine("G01 X[V174-0.0171] Y0.0236");
            sb.AppendLine("G01 X[V174-0.0214] Y0.0321");
            sb.AppendLine("G01 X[V174-0.03] Y0.0407");
            sb.AppendLine("G01 X[V174-0.0386] Y0.045");
            sb.AppendLine("G01 X[V174-0.0557] Y0.045");
            sb.AppendLine("G01 X[V174-0.0643] Y0.0407");
            sb.AppendLine("G01 X[V174-0.0729] Y0.0321");
            sb.AppendLine("G01 X[V174-0.0771] Y0.0236");
            sb.AppendLine("G01 X[V174-0.0814] Y0.0107");
            sb.AppendLine("G01 X[V174-0.0814] Y-0.0107");
            sb.AppendLine("G01 X[V174-0.0771] Y-0.0236");
            sb.AppendLine("G01 X[V174-0.0729] Y-0.0321");
            sb.AppendLine("G01 X[V174-0.0643] Y-0.0407");
            sb.AppendLine("G01 X[V174-0.0557] Y-0.045");
            sb.AppendLine("G01 X[V174-0.0386] Y-0.045");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("G01 X[V174-0.0514] Y0.0279");
            sb.AppendLine("G01 Z[V26+0.13] F[V178]");
            sb.AppendLine("G01 X[V174-0.0771] Y0.0536");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("NOEX V174 = V174 - 0.1 (NEXT CHARACTER)");
            sb.AppendLine("");
            return sb.ToString();
        }

        public static String getCRR()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(R)");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("G01 X[V174-0.0171] Y0.045");
            sb.AppendLine("G01 Z[V26+0.13] F[V178]");
            sb.AppendLine("G01 X[V174-0.0171] Y-0.045");
            sb.AppendLine("G01 X[V174-0.0557] Y-0.045");
            sb.AppendLine("G01 X[V174-0.0686] Y-0.0407");
            sb.AppendLine("G01 X[V174-0.0729] Y-0.0364");
            sb.AppendLine("G01 X[V174-0.0771] Y-0.0279");
            sb.AppendLine("G01 X[V174-0.0771] Y-0.0193");
            sb.AppendLine("G01 X[V174-0.0729] Y-0.0107");
            sb.AppendLine("G01 X[V174-0.0686] Y-0.0064");
            sb.AppendLine("G01 X[V174-0.0557] Y-0.0021");
            sb.AppendLine("G01 X[V174-0.0171] Y-0.0021");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("G01 X[V174-0.0471] Y-0.0021");
            sb.AppendLine("G01 Z[V26+0.13] F[V178]");
            sb.AppendLine("G01 X[V174-0.0771] Y0.045");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("NOEX V174 = V174 - 0.1 (NEXT CHARACTER)");
            sb.AppendLine("");
            return sb.ToString();
        }

        public static String getCRS()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(S)");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("G01 X[V174-0.0729] Y-0.0321");
            sb.AppendLine("G01 Z[V26+0.13] F[V178]");
            sb.AppendLine("G01 X[V174-0.0643] Y-0.0407");
            sb.AppendLine("G01 X[V174-0.0514] Y-0.045");
            sb.AppendLine("G01 X[V174-0.0343] Y-0.045");
            sb.AppendLine("G01 X[V174-0.0214] Y-0.0407");
            sb.AppendLine("G01 X[V174-0.0129] Y-0.0321");
            sb.AppendLine("G01 X[V174-0.0129] Y-0.0236");
            sb.AppendLine("G01 X[V174-0.0171] Y-0.015");
            sb.AppendLine("G01 X[V174-0.0214] Y-0.0107");
            sb.AppendLine("G01 X[V174-0.03] Y-0.0064");
            sb.AppendLine("G01 X[V174-0.0557] Y0.0021");
            sb.AppendLine("G01 X[V174-0.0643] Y0.0064");
            sb.AppendLine("G01 X[V174-0.0686] Y0.0107");
            sb.AppendLine("G01 X[V174-0.0729] Y0.0193");
            sb.AppendLine("G01 X[V174-0.0729] Y0.0321");
            sb.AppendLine("G01 X[V174-0.0643] Y0.0407");
            sb.AppendLine("G01 X[V174-0.0514] Y0.045");
            sb.AppendLine("G01 X[V174-0.0343] Y0.045");
            sb.AppendLine("G01 X[V174-0.0214] Y0.0407");
            sb.AppendLine("G01 X[V174-0.0129] Y0.0321");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("NOEX V174 = V174 - 0.1 (NEXT CHARACTER)");
            sb.AppendLine("");
            return sb.ToString();
        }

        public static String getCRSLASH()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(/)");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("G01 X[V174-0.0129] Y0.045");
            sb.AppendLine("G01 Z[V26+0.13] F[V178]");
            sb.AppendLine("G01 X[V174-0.0729] Y-0.045");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("NOEX V174 = V174 - 0.093 (NEXT CHARACTER)");
            sb.AppendLine("");

            return sb.ToString();
        }

        public static String getCRSPACE()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(" (SPACE)");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("NOEX V174 = V174 - 0.08 (NEXT CHARACTER)");
            sb.AppendLine("");
            sb.AppendLine("");
            return sb.ToString();
        }

        public static String getCRT()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(T)");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("G01 X[V174-0.0343] Y-0.045");
            sb.AppendLine("G01 Z[V26+0.13] F[V178]");
            sb.AppendLine("G01 X[V174-0.0343] Y0.045");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("G01 X[V174-0.0043] Y-0.045");
            sb.AppendLine("G01 Z[V26+0.13] F[V178]");
            sb.AppendLine("G01 X[V174-0.0643] Y-0.045");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("NOEX V174 = V174 - 0.09 (NEXT CHARACTER)");
            sb.AppendLine("");
            return sb.ToString();
        }

        public static String getCRU()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(U)");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("G01 X[V174-0.0171] Y-0.045");
            sb.AppendLine("G01 Z[V26+0.13] F[V178]");
            sb.AppendLine("G01 X[V174-0.0171] Y0.0193");
            sb.AppendLine("G01 X[V174-0.0214] Y0.0321");
            sb.AppendLine("G01 X[V174-0.03] Y0.0407");
            sb.AppendLine("G01 X[V174-0.0429] Y0.045");
            sb.AppendLine("G01 X[V174-0.0514] Y0.045");
            sb.AppendLine("G01 X[V174-0.0643] Y0.0407");
            sb.AppendLine("G01 X[V174-0.0729] Y0.0321");
            sb.AppendLine("G01 X[V174-0.0771] Y0.0193");
            sb.AppendLine("G01 X[V174-0.0771] Y-0.045");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("NOEX V174 = V174 - 0.1 (NEXT CHARACTER)");
            sb.AppendLine("");
            return sb.ToString();
        }

        public static String getCRV()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(V)");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("G01 X[V174-0.0043] Y-0.045");
            sb.AppendLine("G01 Z[V26+0.13] F[V178]");
            sb.AppendLine("G01 X[V174-0.0386] Y0.045");
            sb.AppendLine("G01 X[V174-0.0729] Y-0.045");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("NOEX V174 = V174 - 0.1 (NEXT CHARACTER)");
            sb.AppendLine("");
            return sb.ToString();
        }

        public static String getCRW()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(W)");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("G01 X[V174-0.0086] Y-0.045");
            sb.AppendLine("G01 Z[V26+0.13] F[V178]");
            sb.AppendLine("G01 X[V174-0.03] Y0.045");
            sb.AppendLine("G01 X[V174-0.0514] Y-0.045");
            sb.AppendLine("G01 X[V174-0.0729] Y0.045");
            sb.AppendLine("G01 X[V174-0.0943] Y-0.045");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("NOEX V174 = V174 - 0.111 (NEXT CHARACTER)");
            sb.AppendLine("");
            return sb.ToString();
        }

        public static String getCRX()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(X)");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("G01 X[V174-0.0129] Y-0.045");
            sb.AppendLine("G01 Z[V26+0.13] F[V178]");
            sb.AppendLine("G01 X[V174-0.0729] Y0.045");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("G01 X[V174-0.0729] Y-0.045");
            sb.AppendLine("G01 Z[V26+0.13] F[V178]");
            sb.AppendLine("G01 X[V174-0.0129] Y0.045");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("NOEX V174 = V174 - 0.1 (NEXT CHARACTER)");
            sb.AppendLine("");
            return sb.ToString();
        }

        public static String getCRY()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(Y)");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("G01 X[V174-0.0043] Y-0.045");
            sb.AppendLine("G01 Z[V26+0.13] F[V178]");
            sb.AppendLine("G01 X[V174-0.0386] Y-0.0021");
            sb.AppendLine("G01 X[V174-0.0386] Y0.045");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("G01 X[V174-0.0729] Y-0.045");
            sb.AppendLine("G01 Z[V26+0.13] F[V178]");
            sb.AppendLine("G01 X[V174-0.0386] Y-0.0021");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("NOEX V174 = V174 - 0.1 (NEXT CHARACTER)");
            sb.AppendLine("");
            return sb.ToString();
        }

        public static String getCRZ()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(Z)");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("G01 X[V174-0.0129] Y-0.045  F[V178]");
            sb.AppendLine("G01 Z[V26+0.13]");
            sb.AppendLine("G01 X[V174-0.0729] Y-0.045");
            sb.AppendLine("G01 X[V174-0.0129] Y0.045");
            sb.AppendLine("G01 X[V174-0.0729] Y0.045");
            sb.AppendLine("G00 Z[V26+0.25]");
            sb.AppendLine("NOEX V174 = V174 - 0.1 (NEXT CHARACTER)");
            sb.AppendLine("");
            return sb.ToString();
        }




        //========= END ======================
    }
}
