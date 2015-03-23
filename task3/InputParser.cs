using System;
using System.Text.RegularExpressions;

namespace task3
{
    public class InputParser
    {
        private IPociagowaFabryka fabric;
        private bool flOsi;

        public InputParser()
        {
        }

        public IWagon createWagon(String typStr, String dlugoscStr)
        {
            int dlugosc = parseDlugosc(dlugoscStr);
            String typ = parseTypWagonu(typStr);

            if (flOsi) {
                this.fabric = new OsiowaFabryka();
            } else {
                this.fabric = new ZwyklaFabryka();
            }

            if (typ == "Towarowy") {
                return this.fabric.createTowarowyWagon(dlugosc);
            } else if (typ == "Osobowy") {
                return this.fabric.createOsobowyWagon(dlugosc);
            }

            return null;
        }

        public ILokomotywa createLokomotywa(String typStr, String dlugoscStr)
        {
            int dlugosc = parseDlugosc(dlugoscStr);
            String typ = parseTypLokomotywy(typStr);

            if (flOsi) {
                this.fabric = new OsiowaFabryka();
            } else {
                this.fabric = new ZwyklaFabryka();
            }

            if (typ == "Elektryczna") {
                return this.fabric.createElektrycznaLokomotywa(dlugosc);
            } else if (typ == "Spalinowa") {
                return this.fabric.createSpalinowaLokomotywa(dlugosc);
            }

            return null;
        }

        protected static int parseDlugosc(String s)
        {
            return Int32.Parse(s);
        }

        protected static String parseTypLokomotywy(String s)
        {
            Match match = Regex.Match(s, @"^(O)?\s*(E|S)$");
            String typ = "";

            this.flOsi = false;

            if (match.Success) {
                if (match.Groups[1] == "O") {
                    this.flOsi = true;
                }

                if (match.Groups[2] == "E") {
                    typ = "Elektryczna";
                } else if (match.Groups[2] == "S") {
                    typ = "Spalinowa";
                } else {
                    typ = "Unknown";
                }
            }

            return typ;
        }

        protected static String parseTypWagonu(String s)
        {
            Match match = Regex.Match(s, @"^(O)?\s*(T|B)$");
            String typ = "";

            this.flOsi = false;

            if (match.Success) {
                if (match.Groups[1] == "O") {
                    this.flOsi = true;
                } 

                if (match.Groups[2] == "T") {
                    typ = "Towarowy";
                } else if (match.Groups[2] == "B") {
                    typ = "Osobowy";
                } else {
                    typ = "Unknown";
                }
            }

            return typ;
        }
    }
}

